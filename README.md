# **First Time Setup**
This is a bit of a pain, I'm sorry. The default is my personal setup, BDO running in fullscreen with default UI Scale on a 1080p monitor. If any of these are different for you, I'm sorry but you have to set it up.<br />
First download the latest release. Unzip the file and move the `BDO Item Sorter Data` folder to your local Documents folder. Afterwards, open the file `Position Settings.csv` with something like Notepad. Now in-game, open your Inventory and take a screenshot (default keybind PrtSc), and open it with an editing software, like paint.net (screenshots are stored by default in your Documents\Black Desert\ScreenShot).<br />
Select an area from the top left corner of the top left inventory slot, ***inside the border***, down to just above the start of the stack number's pixels, and note the Selection top left coordinates and the Bounding rectangle size. If the top-left slot doesn't have a stack number just take the slot width and height from one that does.<br />
![image](https://github.com/ErisLoona/BDO-Item-Sorter/assets/142046400/5e77b546-5562-45ec-8ac6-2e1d81b8362e)<br />
<br />
Type in the first number of the coordinates in the `Position Settings.csv` file on the first line, after the comma, instead of the default number. Make sure to not add any spaces before or after the number. Type the second number on the second line, similarly. On the fourth and fifth lines add the Bounding rectangle size numbers respectively. This next bit is only necessary if you changed the UI Scale. Select the top left corner of the next slot, and subtract the coordinates from the first slot's selection. For example in my case:<br />
![image](https://github.com/ErisLoona/BDO-Item-Sorter/assets/142046400/ba9bdc42-38f5-4456-ac81-f2b50473b776)<br />
<br />
The second slot's coordinate is 1521, while the first's was 1467, so do `1521 - 1467 = 54`, which is what you'll write for the 3rd line's number as the Step.<br/>
Almost done, I swear!<br />
Now launch the program, `BDO Item Sorter.exe`, and hit the Analyze button while BDO is open and you have your Inventory open. A bunch of red buttons will appear in the program, click one that corresponds to an empty slot in your BDO Inventory and name it (empty), you don't have to name it that way but I did. Next up, click on the button that corresponds to the Add Inventory Slot in your inventory, the one with the + and name it whatever, I named it (add slot). If you didn't have that on-screen in BDO when you hit Analyze, just scroll your inventory and hit the button again. And lastly, click a button that corresponds to a locked slot in your inventory and name it, I named it (locked slot). None of the other options are taken into account, the first 3 items added to the sorter are hardcoded to be intentionally ignored, since there's nothing to sort for those 3 special icons.<br />
**You're done!** Sorry it took so long, but it's the only time you'll have to do this. Now you can start adding and categorizing items in the sorter! Refer to the Tutorial section for more detailed info on how to use the program.<br />
## **Limitations**
Because of the way the program works and my lack of skill, it has several limitations.
- Items with animated icons can't *really* be added. Technically it would be possible if you were to add every frame of the animation as a "new" item with the same name, but I CBA. Most notable example would be Black Stones, both Armor and Weapon
- If an item has a cooldown overlay on it in your inventory or any other effect that changes its icon, the item will not be recognized
- Switching UI Themes will break all the known items as the background color of the slots changes
- Moving the inventory in-game or changing the UI Scale will break it as the coordinates in the `Position Settings.csv` file are no longer accurate, you need to update those
- It cannot distinguish between items with the same icon by default, you need to tell it that a certain icon may be different items and set them accordingly
- Items, categories and cities cannot have commas (",") in their name
- BDO must be running on the primary screen of your system
- The programming is probably about as robust as a ring of smoke
## **Info**
Heyo! I'm Eris, newbie programmer who really likes C#. I made this item sorter for myself, but decided to share it with others as it can come in handy for those obsessed with order in their inventories. I really tried my best when making it, but I'm sure it has a ton of flaws in the programming.<br />
The way the program works is by associating the items' icons with the "known items" that you've added previously and categorizing them accordingly. It then displays in its virtual inventory the items detected and tell you where that particular item should go. I'm using multi-threading to work through the items faster, 4 BackgroundWorkers take one quarter of the inventory each. I'm using `.csv` files as "databses" for the configurable stuff, associating an item ID to each item and having its icon with the same ID as its name to associate them. The header for the `Item Attributions.csv` file, which is the main item database, would be Item ID,Item Name,Should the item be ignored?,Does the item share an icon? so if you ever look into that, that's what's happening. Why is the `Problematic Items` file a .txt and not a .csv? A lack of forethought and being too lazy to change it in all of its appearances in code. Actually this answer probably applies for pretty much all the weird stuff you may or may not find. Anyway, this has made my life so much easier when sorting through my inventory in BDO and I hope it helps you too! Have a nice day <3<br />
## **Tutorial**<br />
![image](https://github.com/ErisLoona/BDO-Item-Sorter/assets/142046400/fc55228c-6726-4b4d-888a-85e612f11050)<br />
1. The virtual inventory, this is where the analysis results are displayed as buttons of 4 possible colors.
- Red = The item was not recognized
- Green = The item was recognized and categorized
- Orange = The item was recognized but it shares an icon with another item, double-check that it's the correct one
- White = The item was recognized and ignored, not categorized. The color is overriden if the item is marked as sharing an icon<br />
You can click on any of them to change their name, assigned category and/or attributes:<br />
![image](https://github.com/ErisLoona/BDO-Item-Sorter/assets/142046400/e0dd78a8-843a-47ce-9609-92ecb5604091)<br />
<br />
If the item slot is orange, i.e. is marked as sharing an icon, you can right click it to select the correct item. If you haven't added the desired item yet write in its name and hit Done, afterwards you can left click the item to assign it a category.<br />
<br />
2. The Analyze button and the loading bar. Click this button whenever you want the program to take a look at your inventory and sort the items. The loading bar shows the progress of the analysis.<br />
<br />
3. The item destination list, this is where the analysis results are displayed as a list of items and their destination city. The order is displayed in order of detection, so top to bottom left to right, and shows the item name -> destination city. If you hover over a detected *non-ignored* item (so Green or Orange) the corresponding entry will be highlighted for ease of use.<br />
<br />
4. The Category overview, exactly what it says on the tin, it shows all categories added grouped by the order of the cities.<br />
<br />
5. The Edit Category button. This button will open the following menu:
  
![image](https://github.com/ErisLoona/BDO-Item-Sorter/assets/142046400/d23250fc-faf5-4a65-adc1-6a6200bb8df4)<br />
- On the left there is a list of all the added categories, in the order they were added (except (none) which cannot be removed or changed). By right clicking on any of them you can delete them or move them in the list. When a category is deleted all the items that were assigned to it will be assigned to (none) automatically.
- At the top there are the New category and New location boxes, type in the name of the category or location and click the little + button by them to add them. New categories are automatically attributed to the location (none).
- In the center there is the attribution menu, select the category from the drop-down, the city it's currently attributed to will automatically be selected in the City drop-down, and if you want to change that attribution select the new City from the drop-down and click the "attribute to" arrow button. Click Done when you're done.<br />
<br />
6. The item lookup. This drop-down will let you search any item and show you its assigned category and the city it would go to. You can also type the name you're looking for and it will be suggested from the available entries. Useful if you don't wanna mess up your analysis or just as a one-off curiosity, or whatever. Keep in mind the suggestion you will be showed is not very advanced and needs you to type out the item exactly as you put it in, minus capitalization. For example, if you added the item "\[Event\] Elion's Tear" and simply search "elion's tear" will not show it in the suggestions. However typing "\[eve" or more will.
