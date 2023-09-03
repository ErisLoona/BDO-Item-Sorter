# **First Time Setup**
Quick note: **There is no chance of bans, and this does not break the ToS.** The sorter doesn't interact with the game directly in any way. It doesn't even check whether the game is running, it simply takes a screenshot of the screen you selected in the Settings.<br />
Follow the video. If you get the Windows protected your PC warning, Click on More info:<br />
<img src="https://github.com/ErisLoona/BDO-Item-Sorter/assets/142046400/4df1dd15-fab6-4f0b-8c92-9ae207593b97" width="314" height="294" />  <img src="https://github.com/ErisLoona/BDO-Item-Sorter/assets/142046400/54d74e3f-ed1c-4d54-b4dc-74ecc7a1fd42" width="314" height="294"/><br />
and then on Run anyway.<br />
This happens because my program is not signed, which would be very expensive, $1k+ every 2 years. Feel free to Google this to assure yourself it is not indicative of a threat at all.<br />

Click the image below for the video:<br />
[![https://youtu.be/UFuHvLmkZ1Y](http://img.youtube.com/vi/UFuHvLmkZ1Y/0.jpg)](http://www.youtube.com/watch?v=UFuHvLmkZ1Y "First time setup and quick tutorial")
## **Limitations**
Because the program works by detecting the items' icons, it has several limitations.
- The program does not work at all with the Classic theme because it's transparent, meaning the item slots will never have the exact same background, making item detection impossible
- If an item has an overlay on it in your inventory or any other effect that changes its icon, the item will not be recognized, for example an item on cooldown or simply hovering your mouse over it
- Items with animated icons can't *really* be added. Technically it would be possible if you were to add every frame of the animation as a "new" item with the same name, but I CBA usually and just look them up in the drop-down. Most notable example would be Black Stones, both Armor and Weapon
- Moving the inventory in-game or changing the UI Scale will break it as the coordinates in the `Position Settings.csv` file are no longer accurate, update them with the Alignment button in Settings
- It cannot distinguish between items with the same icon by default, you need to tell it that a certain icon may be different items and set them accordingly
- Items, categories and cities cannot have commas (",") in their name
- The timer in Farming Mode is not 100% accurate
- The programming is probably about as robust as a puff of smoke
## **Info**
Heyo! I'm Eris, newbie programmer who really likes C#. I made this item sorter for myself, but decided to share it with others as it can come in handy for those obsessed with order in their inventories. I really tried my best when making it, but I'm sure it has a ton of flaws in the programming.<br />
The way the program works is by associating the items' icons with the "known items" that you've added previously and categorizing them accordingly. It then displays in its virtual inventory the items detected and tell you where that particular item should go. I'm using multi-threading to work through the items faster, 4 BackgroundWorkers take one quarter of the inventory each. I'm using `.csv` files as "databses" for the configurable stuff, associating an item ID to each item and having its icon with the same ID as its name to associate them. The header for the `Item Attributions.csv` file, which is the main item database, would be Item ID,Item Name,Should the item be ignored?,Does the item share an icon? so if you ever look into that, that's what's happening. Why is the `Problematic Items` file a .txt and not a .csv? A lack of forethought and being too lazy to change it in all of its appearances in code. Actually this answer probably applies for pretty much all the weird stuff you may or may not find. Anyway, this has made my life so much easier when sorting through my inventory in BDO and I hope it helps you too! Feel free to change the code however you want, just link back here and give me credit if you share it. Have a nice day <3<br />
<br />
I've worked long and hard on this, especially for 2.0. If you wanna, drop me a donation, any amount is greatly appreciated!<br />
[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/N4N0OTIEV)
<br />
## **Tutorial**<br />
### Normal (Sorting) Mode
<img src="https://github.com/ErisLoona/BDO-Item-Sorter/assets/142046400/ec478b6c-f913-4d6e-a818-1eb0fcf89211" /><br />
1. The virtual inventory, this is where the analysis results are displayed as buttons of 4 possible colors.<br />
- Red = The item was not recognized<br />
- Green = The item was recognized and categorized<br />
- Orange = The item was recognized but it shares an icon with another item, double-check that it's the correct one<br />
- White = The item was recognized and ignored, not categorized. The color is overriden if the item is marked as sharing an icon<br />
You can click on any of them to change their name, assigned category and/or attributes:<br />
<img src="https://github.com/ErisLoona/BDO-Item-Sorter/assets/142046400/002268c6-fc06-4208-a203-16a1b6a20c32" /><br />
<br />
If the item slot is orange, i.e. is marked as sharing an icon, you can right click it to select the correct item. If you haven't added the desired item yet write in its name and hit Done, afterwards you can left click the item to assign it a category.<br />
<br />
2. The Analyze button and the loading bar. Click this button whenever you want the program to take a look at your inventory and sort the items. The loading bar shows the progress of the analysis.<br />
<br />
3. The item destination list, this is where the analysis results are displayed as a list of items and their destination city. The order is displayed in order of detection, so top to bottom left to right, and shows the item name -> destination city. If you hover over a detected non-ignored item (so Green or Orange) the corresponding entry will be highlighted for ease of use.<br />
<br />
4. The Category overview, exactly what it says on the tin, it shows all categories added grouped by the order of the cities.<br />
<br />
5. The Edit Category button. This button will open the following menu: <br />
<img src="https://github.com/ErisLoona/BDO-Item-Sorter/assets/142046400/beeba341-a1dc-4839-943d-c230a0e861ac" /><br />
<br />
- On the left there is a list of all the added categories, in the order they were added (except (none) which cannot be removed or changed). By right clicking on any of them you can delete them or move them in the list. When a category is deleted all the items that were assigned to it will be assigned to (none) automatically.<br />
- At the top there are the New category and New location boxes, type in the name of the category or location and click the little + button by them to add them. New categories are automatically attributed to the location (none).<br />
- In the center there is the attribution menu, select the category from the drop-down, the city it's currently attributed to will automatically be selected in the City drop-down, and if you want to change that attribution select the new City from the drop-down and click the "attribute to" arrow button. Click Done when you're done.<br />
<br />
6. The item lookup. This drop-down will let you search any item and show you its assigned category and the city it would go to. You can also type the name you're looking for and it will be suggested from the available entries. Useful if you don't wanna mess up your analysis or just as a one-off curiosity, or whatever. Keep in mind the suggestion you will be showed is not very advanced and needs you to type out the item exactly as you put it in, minus capitalization. For example, if you added the item "[Event] Elion's Tear" and simply search "elion's tear" will not show it in the suggestions. However typing "[eve" or more will.<br />
<br />
7. The settings button. It opens the same menu you saw during the initial setup:<br />
<img src="https://github.com/ErisLoona/BDO-Item-Sorter/assets/142046400/46c15b48-e473-4f14-8e1a-b870ec6adea3" /><br />
<br />
- The Screens drop-down will initially show the screen it's set to. If BDO is not running on your primary monitor select the correct one and hit Set Screen.<br />
- The Set Alignment button re-aligns the program to the correct pixel coordinates. Refer to the video for how to use it, much easier shown than said.<br />
- The checkbox in the middle allows the program to use icons instead of colors. An example of a before and after:<br />
<img src="https://github.com/ErisLoona/BDO-Item-Sorter/assets/142046400/5c1d8aa4-ea94-4653-82f3-818b8656fa9f" /><br />
- Greyed out items are ignored, items with an orange question mark are marked as sharing their icon and items with a red exclamation mark are unknown.<br />
- The Donate button opens my ko-fi page.<br />
<br />
The other fields are only used if you want the Sorter to auto-fill garmoth for you after your farming session.<br />
  - The bottom left button is an update button. Hit it if you want the program to update its garmoth scripts. If the website makes changes, I will try to update the scripts asap, and that button will update them to the latest version I made.<br />
  - The Garmoth ID field allows you to set your unique URL from garmoth. Head over to garmoth's Grind Tracker, if you look in your URL bar the link will look something like ht<span>tps://</span>garmoth.com/grind-tracker/Alphanumeric Mess/summary. Paste that alphanumeric mess in the text box and hit Set ID.<br />
  - The Website Load Delay (s) allows you set the number of seconds to wait for garmoth to load when ending a farming session, with three decimal precision. So 1.500 would mean one and a half seconds.<br />
  - The Calibrate Digits button is only needed if you've changed the UI Scale from the default 100%. The Help button next to it will open a YouTube link with a more in-depth explanation of how to use it.<br />
  <br />
  8. The mode checkbox. This switches between the Normal (Sorting) Mode and Farming Mode.
