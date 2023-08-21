# This is an Alpha
I'm trying to adapt the program to be able to auto-fill garmoth for the user as much as possible. It's not tested much, but feel free to test it for yourself if you wanna. There **should**™ be no hard crashes.<br />
Each push will be a part of the process finalized.<br />
## Roadmap:
I'll try to stick to this, but no promises!
- ✓ Alpha 1: Give the program the capability to read how many items are in a stack.
  - Done! I was able to add this without any major performance impact. I'm using the UI thread to do the stack number by essentially "brute-forcing OCR". I have .bmp files with each digit on a transparent pixel background, I try to find the digit .bmp in the .bmp of the lower part of each item slot. I've mathed it out so that the user doesn't need to register another pixel with the Alignment tool. From preliminary testing it has a 100% correctness rate and it seems to be quite quick, about 1 second. This will probably increase the more UI Scale and resolution goes up, but oh well.
- ✗ Alpha 2: Create a mode specifically for garmoth farming. Add timer and procedure for starting a new grind session. Add appropriate controls.
- ✗ Alpha 3: Add auto-filling to garmoth, as much as it can.
- ✗ Alpha 4: Complete folder and .bmp structure. Add a way to auto-download the folder into the appropriate place.
- ✗ Alpha 5: Testing and bugfixing.<br />
### Download
The folder goes in your `Documents folder\BDO Item Sorter Data\`<br />
[Alpha 1.zip](https://github.com/ErisLoona/BDO-Item-Sorter/files/12402838/Alpha.1.zip)
