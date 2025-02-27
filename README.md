# Terraria 16-Bit RGB Animation Builder
Worlds First FULL 16-Bit Color Display In Terraria.

[![RGB Display](https://github.com/user-attachments/assets/3742ed39-6e9e-4863-a00a-71bbd0c3947f)](https://www.youtube.com/watch?v=c_R4L266D3M "Worlds First FULL 16-Bit Color Display In Terraria!")

![Vanilla_Terraria_16-Bit_Shrek](https://github.com/user-attachments/assets/f6074bed-9a12-4519-9cca-ead9a8b0e359)

## How It Works?

The way this technology works is by using a few of the games different principles. The first one we need to start with is what RGB is and what the current methods of obtaining it is.

### What is RGB?
`RGB` stands for Red, Green, Blue and are the essential primary color building blocks for making all the unique colors you see on any modern display. Some displays even include a fourth color, and that's yellow.

The way modern displays use RGBY, is by activating a unique set of the four colors. From a far, these colors will seem to "blend" together to form a new secondary color. Such like combining blue & red, it gives purple.

You might have already figured it out by now, but when it comes to video games, this principle is much harder to execute due to the ability to make *really* small pixels. Games like Terraria have it much worse as the ability to shove pixels close together is limited by the players zoom and the fact all logic must be done on a 2D plane. Games like Minecraft can take advantage of a 3D plane for wiring and players can move further away to better blend the colors.

### How does RGB displays work?
When it comes to video games, many games offer a mechanical item such as a lamp that has two states, on and off. This is very useful when trying to make a single bit (color) black and white display. However, when it comes to displaying more than one state of color, many games do not offer items that could be used in a meaningful manner to display more than one color state on demand. On demand refers to the ability to pick any display color, in any order, based on a wire input. For this reason, many players have to get very creative regardless of the game they are playing on.

For Terraria, the options are limited. Because of the inability to zoom out very far, this leaves normal mechanical devices such as torches off the table due to the space required to run wires in-between them. This only leaves tiles that can be displayed on the large map such as gemspark blocks. Using correctly spaced gemspark blocks with some color algorithms, it is possible to make a below par RGB image as seen bellow.

#### **Image 1: In-game Gemspark Display** | **Image 2: Reference Photo**

<img src="https://github.com/user-attachments/assets/218920f5-6ddd-4666-a1ab-a5658752b65c" width="250" height="250"/><img src="https://github.com/user-attachments/assets/839eb116-30fd-4c3d-84db-b1dbad07e8a0" width="25" height="1"/><img src="https://github.com/user-attachments/assets/050f657c-ec99-445b-8a4c-c4e603e61ced" width="250" height="250"/>

### Introducing The WireBulb

Let’s take a look at another wiring mechanic in Terraria called the Wire Bulb. These devices illuminate four separate corner colors based on what color of wire was activated. What's important to note however, is they actually contain 16 separate (technically 32) states, or "textures".

<img src="https://github.com/user-attachments/assets/2e8af19f-c820-4796-87d6-f818ca2723ec" width="250" height="250"/><img src="https://github.com/user-attachments/assets/839eb116-30fd-4c3d-84db-b1dbad07e8a0" width="25" height="1"/><img src="https://github.com/user-attachments/assets/038f1f6a-89cf-4f8b-a9dd-666709576b72" width="450" height="320"/>

Like many different games that have RGB mechanics, the help of texture packs is essential. With these texture packs, we can actually retexture the Wire Bulbs to be solid colors. This means a single 1x1 tile will actually have 16 possible colors, or 16-Bits of color.

#### **Image 1: Without Texture Pack** | **Image 2: With Texture Pack**

<img src="https://github.com/user-attachments/assets/f628bccc-da2b-48f4-807c-41b6165e7579" width="400" height="450"/><img src="https://github.com/user-attachments/assets/839eb116-30fd-4c3d-84db-b1dbad07e8a0" width="25" height="1"/><img src="https://github.com/user-attachments/assets/7c0f5039-7ede-4764-b81c-03d3dcf9a1ae" width="400" height="450"/>

The issue with Wire Bulbs however, is they cannot be put together flush and be controlled individually. This would cause huge gaps between the display for control logic.

### So what's the solution?

Until very recently, the Transmute Workshop team, more in particular, @Quasar, has made an enormous breakthrough in advanced Transmutation technology. The ability to allow for infinite reach, 1x1, horizontal sprite movement.

For those who do not understand what Transmutation is, it's a glitch in Terraria (and other games) that allows you to "transmute" or change one sprite to another sprite; such as a wooden chest, and turn it into a golden chest.

<img src="https://github.com/user-attachments/assets/546d966f-a542-4a17-840b-639791c8c76a" width="250" height="250"/>

Without getting too technical, this glitch allows us to simply change the wire bulb to any sprite (color) remotly from any position on the Y axis.

<img src="https://github.com/user-attachments/assets/8bade025-02df-40d3-80cd-d92a2a8fb657" width="400" height="350"/>

So by stacking these modules, we can achieve flush full 16-bit color displays!

#### **Image 1: Display Demo** | **Image 2: Wiring View**

<img src="https://github.com/user-attachments/assets/52f2e2bf-d0f6-47d9-a4e3-1fb1610b290b" width="180" height="400"/><img src="https://github.com/user-attachments/assets/839eb116-30fd-4c3d-84db-b1dbad07e8a0" width="25" height="1"/><img src="https://github.com/user-attachments/assets/51812408-95ea-46b7-b518-3c386b195081" width="180" height="400"/>

## How To Make Your Own Animation!

### **Step1: Converting a video**

Notes:
 - ROM has a max of 768 frames.
 - Map has a built FPS settings - 24, 30, 60, 120.

Steps:
1) [[Link](https://yt1s.com/en5)] Download Original Video.
2) [[Link](https://www.zapstudio.net/framecalc/)] Calculate what FPS is required to fit within 768 frames.
3) [[Link](https://www.video2edit.com/convert-to-video)] Reduce FPS of the video. **Optional: ** Reduce To 116x66.
4) [[Link](https://mconverter.eu/convert/mp4/png/)] Convert To Image Sequence.
5) [[Link](https://www.xnview.com/en/xnconvert/)] **Optional: ** Bulk Convert To 116x65 Using Resize & NearestNeighbour Resample.


### **Step2: Converting Image Sequence To Schematic**

Using the tool `PictureToBinaryRGB` it’s possible to easily convert all the images to a binary nibble sequence of 0000 - 1111 representing each pixel as a 16-bit color. This tool also brings many quality-of-life features such as the ability to generate the color palette automatically via a `k-Means` palette algorithm. This tool also does the liberty of automatically downsizing all images via the `nearest neighbor` algorithm to the `MaxWidth` & `MaxHeight` offsets.

About: *(these settings are already configured by defualt)*
 - `R → L`     - Chooses the direction of 'X' while processing the image.
 - `OffsetX`   - The ROM's first bit 'X' position.
 - `StepX`     - The space 'X' between each data column within the ROM cells.
 - `StepY`     - The space 'Y' between ROM cells -1.
 - `MaxWidth`  - The maximum display width.
 - `MaxHeight` - The maximum display height.

#### **Gif 1: Color Palette Picker Demo** | **Gif 2: Mass Conversion Demo**

<img src="https://github.com/user-attachments/assets/a4f55fe7-186f-4005-9cbb-cd11ff413ff2" width="400" height="500"/><img src="https://github.com/user-attachments/assets/839eb116-30fd-4c3d-84db-b1dbad07e8a0" width="25" height="1"/><img src="https://github.com/user-attachments/assets/2ef334bb-40e4-4901-98c5-f15abcce69a1" width="400" height="500"/>

For people looking to use the a palette that most closely represents the default textures of the Wirebulb, I have also included a checkbox called `Use Defualt` to swap the palette to the default array.

<img src="https://github.com/user-attachments/assets/f01026a0-c027-472a-9165-6e1062e86ac8" width="500" height="300"/>

Steps To Use PictureToBinaryRGB:
1) Double click or drag & drop a sample image.
2) Manually select the 16-color palette or use `Generate Palette`.
3) Input the sequence via the `Add Photos` button.
4) Select an output file location via the `Save Location` button.
5) Click the `Convert Images` button.


### **Step3: Programing video to ROM**

Now that we have created an image sequence for our animation, we need to upload it into the maps ROM. To do this, I will be using an open source tool called [DnSpy](https://github.com/dnSpy/dnSpy) to edit the games compiled code. Using one of the games functions called `ProcessIncomingMessage()`, by adding some code onto this, we will be able to interpret commands. We will add one command; `/arom` for programing. Refer to the steps bellow for adding this to your game.

DnSpy Method:
1) Make a copy of your games executable `Terraria.exe`. Rename it to anything you want. Default Location: `C:\Program Files (x86)\Steam\steamapps\common\Terraria`.
2) Launch DnSpy x32 or x64. (we're not debugging to it does not matter).
3) Use `File > Open` or drag your games renamed Terraria executable into the assembly explorer.
4) Using the arrows in the assembly explorer, navigate to: `Terraria > Terraria.Chat > ChatCommandProcessor`.
5) Right click `ProcessIncomingMessage` and click `Edit Method`.
6) Delete all code in this editor and paste in the code found bellow. Once completed, click `Compile`.
7) After the code editor closes, click `File > Save All` or by the save icon at the top.
8) In the save module popup, click `ok`.
9) Now launch your renamed and modified Terraria executable.
10) Launch a new copy of the display world and use the chat command `/arom`.
11) An open file dialog will open. Navigate to your image sequence `.p2p` file and select it.
12) **Attention: ** Your game will freeze temporarily while it’s working. It’s not broken just give it some time. It will unfreeze when complete.
(To programmers: I kept it this way on purpose to prevent players from assuming its finished instantly.)
 
<details><summary>116x65: Show Code</summary>
 
```c#
// ###################################################################################
// Terraria.Chat > ChatCommandProcessor > ProcessIncomingMessage (OR CreateOutgoingMessage)
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.Chat.Commands;
using Terraria.Localization;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Windows.Forms;

namespace Terraria.Chat
{
    public partial class ChatCommandProcessor : IChatProcessor
    {
        public void ProcessIncomingMessage(ChatMessage message, int clientId)
        {
            // ###################################################################################
            if (message.Text.Contains("/arom")) // Animation rom.
            {
                try
                {
                    // Create and configure the OpenFileDialog.
                    OpenFileDialog openFileDialog = new OpenFileDialog
                    {
                        Filter = "P2B Schem Files|*.p2b",                // Set the filter for P2B files.
                        Title = "Picture To Binary Schematic Save Name"  // Set the title for the dialog.
                    };
                
                    // Show the dialog and check if the user selected a file
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileLocation = openFileDialog.FileName;   // Get the selected file path.
                
                        // Open the binary file for reading.
                        using (FileStream fs = new FileStream(fileLocation, FileMode.Open, FileAccess.Read))
                        using (BinaryReader reader = new BinaryReader(fs))
                        {
                            // Read until the end of the file.
                            while (reader.BaseStream.Position < reader.BaseStream.Length)
                            {
                                // Read the values in the same order as they were written.
                                short x = reader.ReadInt16();       // Read X as short.
                                short y = reader.ReadInt16();       // Read Y as short.
                                byte color = reader.ReadByte();     // Read color as byte.
                                byte byteValue = reader.ReadByte(); // Read pixel data (wire placement as 0 or 1).
                
                                bool placeWire = byteValue == 1;    // If byte value is 1, place wire.
                
                                // Call PlaceWire to place it in the world
                                switch (color)
                                {
                                    case 0: if (placeWire) WorldGen.PlaceWire(x, y); else WorldGen.KillWire(x, y); break;
                                    case 1: if (placeWire) WorldGen.PlaceWire2(x, y); else WorldGen.KillWire2(x, y); break;
                                    case 2: if (placeWire) WorldGen.PlaceWire3(x, y); else WorldGen.KillWire3(x, y); break;
                                    case 3: if (placeWire) WorldGen.PlaceWire4(x, y); else WorldGen.KillWire4(x, y); break;
                                }
                            }
                        }
                
                        // Command finished, display message in-game.
                        Main.NewTextMultiline($"Schematic: '{openFileDialog.FileName}' has loaded successfully!", false, Color.Green, -1);
                    }
                }
                catch (Exception ex)
                {
                    // Display error message with more info (e.g., ex.Message)
                    Main.NewTextMultiline($"ERROR: {ex.Message}", false, Color.Red, -1);
                }
            }

            // ###################################################################################
            IChatCommand chatCommand;
            if (this._commands.TryGetValue(message.CommandId, out chatCommand))
            {
                chatCommand.ProcessIncomingMessage(message.Text, (byte)clientId);
                message.Consume();
                return;
            }

            if (this._defaultCommand != null)
            {
                this._defaultCommand.ProcessIncomingMessage(message.Text, (byte)clientId);
                message.Consume();
            }
        }
    }
}
```
</details>

### **Step4: Accelerating The Wiring**

Due to the way Terraria logic system is, larger wiring builds will freeze your game each time you power them up. To fix this, we can use a mod called the [Terraria Circuit Preprocessing Accelerator](https://github.com/cc004/WireShark/tree/master) to pre-process the wiring and prevent lagging while still maintaining the vanilla logic system.

# Find More Technical Information!

For a fuller explanation on how the wiring in this build works, or for more information about how transmutation works, feel free to check out the official Terraria Wiring Community's wiring guide!

<a href="https://steamcommunity.com/sharedfiles/filedetails/?id=2832101012" title="Click To Visit The Official TWC Wiring Guide!">
    <img src="https://github.com/user-attachments/assets/063b35bd-fad5-4ba3-a9f7-de872fb94e31" width="250" height="250">
</a>

Also feel free to join the Terraria Wiring Community's official discord!

<a href="https://discord.com/invite/gHWA2SvVcd" title="Click To Join our discord!">
    <img src="https://github.com/user-attachments/assets/2e561855-73f7-41c8-a438-028f2204693b" width="600" height="140">
</a>
