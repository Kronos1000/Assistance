package com.patrick.lab12;

import android.content.ContentValues;
import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

class MyDatabaseHelper extends SQLiteOpenHelper {

    private static final String DB_NAME = "lab12";
    private static final int DB_VERSION = 3;

    MyDatabaseHelper(Context context) {
        super(context, DB_NAME, null, DB_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase sqLiteDatabase) {
        sqLiteDatabase.execSQL("CREATE TABLE COUNTRY (_id INTEGER PRIMARY KEY AUTOINCREMENT, NAME TEXT, DESCRIPTION TEXT, IMAGE_RESOURCE_ID INTEGER)");

        // Prepopulate data
        ContentValues countryValues = new ContentValues();
        countryValues.put("NAME", "Australia");
        countryValues.put("DESCRIPTION", "Australia is a country and continent located in the Southern Hemisphere, known for its unique wildlife and diverse landscapes.");
        countryValues.put("IMAGE_RESOURCE_ID", R.drawable.australia);
        sqLiteDatabase.insert("COUNTRY", null, countryValues);

        ContentValues countryValues2 = new ContentValues();
        countryValues2.put("NAME", "Brazil");
        countryValues2.put("DESCRIPTION", "Brazil is the largest country in South America, famous for its annual carnival in Rio de Janeiro and its passion for football.");
        countryValues2.put("IMAGE_RESOURCE_ID", R.drawable.brazil);
        sqLiteDatabase.insert("COUNTRY", null, countryValues2);

        ContentValues countryValues3 = new ContentValues();
        countryValues3.put("_id", 3);
        countryValues3.put("NAME", "Canada");
        countryValues3.put("DESCRIPTION", "Canada is the second largest country by land area, renowned for its vast wilderness areas and multicultural cities.");
        countryValues3.put("IMAGE_RESOURCE_ID", R.drawable.canada);
        sqLiteDatabase.insert("COUNTRY", null, countryValues3);

        ContentValues countryValues4 = new ContentValues();
        countryValues4.put("_id", 4);
        countryValues4.put("NAME", "Denmark");
        countryValues4.put("DESCRIPTION", "Denmark is a Nordic country known for its minimalist design, cycling culture, and being the home of the famous writer Hans Christian Andersen.");
        countryValues4.put("IMAGE_RESOURCE_ID", R.drawable.denmark);
        sqLiteDatabase.insert("COUNTRY", null, countryValues4);

        ContentValues countryValues5 = new ContentValues();
        countryValues5.put("_id", 5);
        countryValues5.put("NAME", "Egypt");
        countryValues5.put("DESCRIPTION", "Egypt is located in North Africa and is famous for its ancient civilization, including the pyramids and the Nile River.");
        countryValues5.put("IMAGE_RESOURCE_ID", R.drawable.egypt);
        sqLiteDatabase.insert("COUNTRY", null, countryValues5);

        ContentValues countryValues6 = new ContentValues();
        countryValues6.put("_id", 6);
        countryValues6.put("NAME", "France");
        countryValues6.put("DESCRIPTION", "France is renowned for its culture, gastronomy, fashion, and landmarks including the Eiffel Tower and the Louvre, the world's largest art museum.");
        countryValues6.put("IMAGE_RESOURCE_ID", R.drawable.france);
        sqLiteDatabase.insert("COUNTRY", null, countryValues6);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        // Handle database upgrades if necessary
    }
}
