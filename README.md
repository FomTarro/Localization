# Tom's Cool Localization Tools!

Thank you for taking a look at my cool set of homespun localization tools. 

In general, I think the library is pretty lightweight and very effective at making life easy for both you and your translators! 

My usecase for building this was a desire to be able to store all my key/value pairs in a spreadsheet. But not just any spreadsheet! Specifically, a Google Sheet, so that multiple people could edit the sheet simultaneously, with no need to worry about "checking in" changes or having merge conflicts with others. 

In addition, having everything in one place lets us easily see which keys still need translations in which languages at a quick glance. It also helps translators reference across languages when they're trying to determine the best way to phrase a translation.

So, what's in the library?

## What's in the Library

There are two basic sections to this library:

### The First Section: The Editor Plugin

* CSVPuller
The Editor script (in the Editor folder) is some small menu extenions for Unity that let you input a Google Sheets sharing URL, select a text asset in your Assets folder, and then pull the content of the Sheet into the asset with a single click.

### The Second Section: The Component Scripts

* LocalizationManager
* LocalizedText

### The Bonus Third Section: Misc

* Singleton
* Ordered Initializer