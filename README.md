# This is an Alpha
I'm trying to adapt the program to be able to auto-fill garmoth for the user as much as possible. It's not tested much, but feel free to test it for yourself if you wanna. There **should**™ be no hard crashes.<br />
Each push will be a part of the process finalized.<br />
## Roadmap:
I'll try to stick to this, but no promises!
- ✓ Alpha 1: Give the program the capability to read how many items are in a stack.
  - Done! I was able to add this without any major performance impact. I'm using the UI thread to do the stack number by essentially "brute-forcing OCR". I have .bmp files with each digit on a transparent pixel background, I try to find the digit .bmp in the .bmp of the lower part of each item slot. I've mathed it out so that the user doesn't need to register another pixel with the Alignment tool. From preliminary testing it has a 100% correctness rate and it seems to be quite quick, about 1 second. This will probably increase the more UI Scale and resolution goes up, but oh well.
- ✓ Alpha 2: Create a mode specifically for garmoth farming. Add timer and procedure for starting a new grind session. Add appropriate controls.
  - Done! Added all UI and relevant controls. The program takes as input from the user the farming location, then get the relevant items as directed by a script I will manually write for each location available on garmoth. This is easily expandable by just creating a new script for a new location, or editing one that is already available. Fixed the digit `3.bmp` having one extra pixel, leading to bad detection. The user can start a session by clicking Analyze after having selected their location, then pause it by hitting Analyze again. This provides a before and after so I can subtract any relevant items previously there. If it's paused, the user can end the session and push it to garmoth (autofill coming in Alpha 3), or choose to resume it after checking their progress. They can also clear it at any point in time. To switch between normal (sorting) mode and farming mode, a new checkBox has been added to the bottom left.
- ✓ Alpha 3: Add auto-filling to garmoth, as much as it can.
  - Done! While Alpha 2 was the longest, ~~this was the most difficult~~ (actually Alpha 4 was the most difficult, this is second). It took a lot of research, but I've managed to make something truly great, it's actually fun to watch. So far I've only made the script for the first location, but it works great. Unfortunately I need the user to input their ID, taken from the URL of garmoth's Grind Tracker Summary, the alphanumeric mess. I couldn't find another way to grab it myself directly, so this will have to do for now at least. However, it can now push the elapsed time in the session as well as the number of items obtained of each item, which I think is great. I've added a variable delay that the user can set regarding how long it takes for the webpage to load, since I need to open a new tab each time to ensure that the user is on the right page, as well as to bring their default browser in focus, so I don't have to check for each browser to find out which one they're using. Also unfortunately I had to use bmp matching again to find the +Add button on garmoth, since the website scales weirdly depending on resolution. Furthermore I have to maximize the browser window because the number of tab presses varies by the resolution of the window, unless it's maximized, which makes no sense, but oh well it's out of my control. However, it works, and greatly at that. Condensed all the itemButton methods, from 192 down to 3, removing over 6k lines of code in the process and making it easier for me to work on it. Overall I'm really proud of this Alpha version honestly.
- ✓ Alpha 4: Complete folder and .bmp structure. Add a way to auto-download the folder into the appropriate place.
  - This has *a lot* of stuff added into it! So much so that I've decided the full release will be v2.0. In order to avoid creating almost a thousand .bmp files, one for each digit for each UI scale value for each resolution, I found a way to allow the user to create them for themselves instead. I found a pattern in every digit, when looking at the colors used, they're always either R = G = B, or most commonly R > G = B, with the R value being at most 5 higher. This allowed me to separate those colors and paste them into a separate Bitmap, with the rest being transparent. However, because pixels of colors that meet that condition may be present elsewhere I have devised a (in my opinion) really cool algorithm which gets the average number of pixels found in each row and column in the aforementioned Bitmap and eliminates the rows and columns which have numbers of pixels less than or equal to half of the average, effectively tightly cropping the Bitmap around the digit. I was very aggressive with what I crop because missing pixels are preferrable to extra pixels, as the former leads to less accuracy while the latter leads to failed detection. Honestly I'm very very proud of this algorithm, I think it's awesome. Added a Help button that opens a YouTube tutorial for the Digit Calibration. Next up, I've created a new repo to hold support files like the Sorting Mode folder. This allows me to have a static download link from which the program can grab those files, especially for first-time setup. I will just delete the current file and upload the new one with the same name to be able to keep the same link to it. This change is retroactive as well, so that current users of version v1.X don't need to do anything extra to get their BDO Item Sorter Data folder up to date with the latest file structure. Also added an update button in Settings which will allow the user to update only the garmoth scripts (which I have finished making by the way), because the website obviously evolves and changes things, so I need to be able to update those too without always changing code and expecting users to check github. Also added a check on whether garmoth is up, as I've found it to be down on more than one occasion, if it's down it will just cancel the push. NEXT UP I've added an Icons Mode, instead of only using colored buttons to communicate the state of a detection in the virtual inventory, it will now show the item as it is in game. Basically, it just sets the background image of the button to a screenshot of that slot in-game and adds an overlay to show its state (i.e. ignored is slightly greyed out, problematic has an orange question mark overlay and unknown has a red exclamation mark overlay). I think this can prove very useful to some who are better with visual cues like that. Of course, it's not great for performance but in my experience the change is tiny as I just use existing screenshots that the program took previously, so it's just a matter of cropping it and setting the button's backgroundImage and Image properties. And lastly, I've added a Donate button. It's small and out of the way in Settings, this project took a lot of time and effort to develop, and will forever be free, so I might as well attempt to get a couple bucks out of it. Also added a donate button at the bottom of this readme, and I will do that in the main branch as well once I fully release this. Speaking of, I expect a full release some time next week, I'll see how much time testing takes although it shouldn't take long as I've been extensively testing it along the way, but I just wanna make sure. If it's not released until Wednesday then it will be during the weekend, as I have my Bachelor's final exam next week.
- ✗ Alpha 5: Testing and bugfixing.<br />
### Download
**DELETE YOUR OLD SORTING MODE FOLDER!** The new one will be downloaded automatically.<br />
[Alpha 4.zip](https://github.com/ErisLoona/BDO-Item-Sorter/files/12505719/Alpha.4.zip)
<br />
<br />
[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/N4N0OTIEV)
