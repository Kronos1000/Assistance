package com.patrick.lab12;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteException;
import android.database.sqlite.SQLiteOpenHelper;
import android.os.Bundle;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;
import android.widget.Toast;

public class CountryActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_country);

        ListView listView = findViewById(R.id.list_view);
        SQLiteOpenHelper databaseHelper = new MyDatabaseHelper(this);

        try {
            SQLiteDatabase db = databaseHelper.getReadableDatabase();

            // Query the database for country information
            Cursor cursor = db.query("COUNTRY", new String[]{"_id", "NAME", "DESCRIPTION"},
                    null, null, null, null, null);

            SimpleCursorAdapter cursorAdapter = new SimpleCursorAdapter(this,
                    R.layout.list_item_country,
                    cursor,
                    new String[]{"NAME"},
                    new int[]{R.id.text_view_name},
                    0);

            listView.setAdapter(cursorAdapter);

            // Set item click listener
            listView.setOnItemClickListener((parent, view, position, id) -> {
                // Retrieve the selected country's information from the cursor
                Cursor selectedCursor = (Cursor) parent.getItemAtPosition(position);
                String name = selectedCursor.getString(selectedCursor.getColumnIndex("NAME"));
                String description = selectedCursor.getString(selectedCursor.getColumnIndex("DESCRIPTION"));

                // Start new activity and pass country information as extras
                Intent intent = new Intent(CountryActivity.this, CountryDetailsActivity.class);
                intent.putExtra("name", name);
                intent.putExtra("description", description);
                startActivity(intent);
            });

        } catch (SQLiteException ex) {
            Toast.makeText(this, "SQL Error", Toast.LENGTH_SHORT).show();
        }
    }
}
