# Tom's Cool Localization Tools!

Thank you for taking a look at my cool set of homespun localization tools. 

In general, I think the library is pretty lightweight and very effective at making life easy for both you and your translators! 

My usecase for building this was a desire to be able to store all my key/value pairs in a spreadsheet. But not just any spreadsheet! Specifically, a Google Sheet, so that multiple people could edit the sheet simultaneously, with no need to worry about "checking in" changes or having merge conflicts with others. 

In addition, having everything in one place lets us easily see which keys still need translations in which languages at a quick glance. It also helps translators reference across languages when they're trying to determine the best way to phrase a translation.

So, what's in the library?

## What's in the Library

There are two basic sections to this library:

### The First Section: The Editor Plugin

* <b>CSVPuller</b>: A small menu extenion for Unity that lets you input a Google Sheets sharing URL, select a text asset in your Assets folder, and then pull the content of the Sheet into the asset with a single click.

### The Second Section: The Component Scripts

* <b>LocalizationManager</b>: The heart and soul of the localization. Almost all of its internals are carefully documented, but this is essentially a singleton that houses the dictionaries that are your language sets. Interface with this when you need to lookup strings, change the language, or add more key/value pairs to the language set.
* <b>LocalizedText</b>: A component that you should attach to existing Text components. These are supplied a string key to display. In addition, they automatically register themselves with the LocalizationManager and are automatically told to update their contents when the language changes.

Okay, there's also a third section that I use personally for QOL, but isn't core to the library:

### The Bonus Third Section: Misc

* <b>Singleton</b>: An all-purpose singleton implementation for Unity. You certainly don't need this for the library to function, though I find it helpful. The LocalizationManager extends this class.
* <b>Ordered Initializer</b>: The progenitor of the Singleton implementation, this class lets you initialize your singletons in a particular order, and fires a callback on each of them when they finish initialization. Again, not needed, but I find it handy

## Additional References

### Arabic/Right-To-Left Fixup

Unity is bad at right-to-left text display. Fortunately, this is a problem someone way more qualified than me has solved. 

I recommend checking out the OSS plugin: https://github.com/Konash/arabic-support-unity