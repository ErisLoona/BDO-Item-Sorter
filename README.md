## **An update**
Heyo! So uh, long time no see. The project went through a *major* rewrite since last time y'all saw it. I cut out the sorting completely in favor of entirely focusing on automatically uploading farming sessions to Garmoth. Unfortunately, the project is now in limbo and will stay there likely indefinitely. *I think* it should be in full working order with everything, except for the actual uploading to Garmoth bit, and also missing a lot of polish. As it turns out Garmoth does have an API for pulling the grind locations and items, but not for pushing farming sessions. Here's what's new compared to the previous version, as far as I can remember:
- Inventory automatically aligns itself
- Drastically streamlined code
- Program only works on UI scale 100%
- Program detects what font you're using, what theme and what UI scale you have, so you can just click Analyze and it does the stuff or tells you to change them appropriately
- Now detects Black Stones (was a pain, but hey)
- Redesigned UI
- Slightly changed item database, no longer compatible with old model
- Fewer menus, but better
- Sped up a lot by loading the icon database to memory instead of just reading from files all the time
- Always in icon mode, performance impact was minimal</br>
On this branch I will just.. dump the files and code, as-is. If someone wants to iterate on it or improve it etc feel free, if you want explanations please ask me on Discord (or issues). To-dos for this version as far as I can think of right now, apart from the whole pushing to garmoth, would include consolidating the python script into a sinlge .exe instead of downloading and using the entire Python environment and running its script in it as I'm currently doing (see method `GetBlackStones()`, line 1623) which should be easy enough; look into parallelization instead of the current BackgroundWorker method (could be problematic for performance as it could briefly freeze other windows due to the influx of tasks? idk, but odds are it would be faster than just 4/5 threads as it is now), low prio; adjust the counting algorithm to account for dumping items in storage and add to total instead of what it is now which iirc is `if(nr items in new snapshot < nr items in old snapshot) then ignore it` lol.</br>
### The support files can be found in my other repo, or the program will download them itself on first run, you can find them in your Documents folder.
To download the .exe [click here](https://github.com/ErisLoona/BDO-Item-Sorter/blob/garmoth-autofiller/bin/Release/Garmoth%20Autofiller.exe) then hit Download Raw (the little download icon top-left).
