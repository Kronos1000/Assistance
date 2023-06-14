package com.patrick.lab12;

import android.os.Bundle;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class CountryDetailsActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_country_details);

        // Retrieve country information from intent extras
        String name = getIntent().getStringExtra("name");
        String description = getIntent().getStringExtra("description");
        int flagImageResourceID = getIntent().getIntExtra("Image_Resource_ID", 0);


        TextView nameTextView = findViewById(R.id.text_view_name);
        TextView descriptionTextView = findViewById(R.id.text_view_description);
        ImageView flagImageView = findViewById(R.id.imageViewFlag);

        nameTextView.setText(name);
        descriptionTextView.setText(description);
        flagImageView.setImageResource(flagImageResourceID);
    }
}
