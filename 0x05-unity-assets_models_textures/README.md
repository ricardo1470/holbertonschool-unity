> # 0x05. Unity - Assets: Models, Textures

---
| **Filename** | **Description** |
|---|---|
| [0. Primitive player](./Assets/S) | new Scene called `Level01`. Create a capsule GameObject called `Player` which will be a placeholder for this project. Save `Player` as a Prefab into a folder named `Prefabs`. Make sure that when you make changes to the `Player` Prefab, you Apply the changes at the top of the Inspector window.|
| [1. Primitive prototype](./Assets/) | In the `Level01` scene, create a layout of floating platforms of different sizes and positions using only Unity Cube GameObjects, . Plan for a start point and an endpoint and create a path so that the `Player` can jump between them. The cubes will be placeholders for 3D models that we will import later on.  |
| [2. Pole position](./Assets/) | At the end point of the platforms, create a placeholder cylinder GameObject called `WinFlag` to designate the end of the path. Do not make `WinFlag` a child of any object. Later we will add scripting for when the `Player` reaches the `WinFlag`. |
| [3. Jump man](./Assets/) | Create a new folder called `Scripts`. Inside that folder, create a new C# script called `PlayerController` and attach it to `Player`.  |
| [4. Camera ready](./Assets/) | Position the `Main Camera` at an offset behind the player.  |
| [5. Steady cam](./Assets/) | In the Scripts folder, create a new C# script called `CameraController` that allows the camera to follow the player. The script should also allow the player to rotate the camera on their own by moving the mouse, either by just moving the mouse or holding down right-click and dragging the mouse to move the camera.  |
| [6. Falling up](./Assets/) | Currently if the player falls off a platform, it falls infinitely. Edit the `PlayerController` and `CameraController` scripts so that if the player falls from a platform and can’t get to another platform, the player instead falls from the top of the screen onto the start position, causing the player to need to start from the beginning again.  |
| [7. Time trial](./Assets/) | Create a new Canvas and UI Text element that displays a timer on screen.  |
| [8. Clock's ticking](./Assets/) | Create a script called `Timer` and `attach` to the `Player`. `Timer` should have a public Text variable called `Timer Text` for the `TimerText` Text object. The timer should start at `0:00.00` and count up. |
| [9. Finish line](./Assets/) | Create a script called `WinTrigger` and attach to `WinFlag`. When the `Player` touches the `WinFlag` collider, the timer should stop and the text size should increase and the color should change to `green`. The recommended increased font size is `60` but the value is at your discretion as long as the size increase is noticeable to the user.  |
| [10. The sky's the limit](./Assets/) | In the Unity Asset Store, find `Farland Skies - Cloudy Crown`, a free set of skyboxes. Add them to a folder called `Skyboxes` in the `Assets/Materials` folder in your `0x05-unity-assets` project. Create a skybox with the `CloudyCrown_Midday` material. In your README, include the following credit: `Skyboxes: Farland Skies - Cloudy Crown` with a link to the page on the Asset Store.  |
| [11. The great outdoors](./Assets/) | Download [Kenney’s Nature Pack Extended](https://kenney.nl/assets/nature-pack-extended). Import the asset package and place the files in a directory called `Models`. For the sake of organization, inside the `Assets` folder, create a new directory called `Materials` and move the materials in `Models` into Materials. Replace your cube placeholders with the 3D models. The 3D models need [mesh colliders](https://docs.unity3d.com/Manual/class-MeshCollider.html) otherwise the player cannot jump on them. Make sure the player can jump and move between platforms, that the distance and the player’s jump are reasonable, and that the player can reach the end from the starting point. In your README, include the following credit: `Models: Kenney's Nature Pack Extended` with a link to the website.  |
| [12. Environmental awareness](./Assets/) | From the Nature Pack asset package in your `Models` folder, add trees, rocks, flowers, etc. to the platforms as you like. Organize your objects in your Hierarchy using empty GameObjects. Keep in mind the placement of the objects so as not to block or hinder the player from being able to jump between platforms (unless that’s part of your design!). The player should also not be able to walk through rocks, trees, etc., but may walk through flowers, grass, etc.  |
| [13. What's left of the flag](./Assets/) | Download this [flag model](https://intranet-projects-files.s3.amazonaws.com/holbertonschool-cs-unity/435/Flag.fbx). Place it in the Models directory. Add `Flag` to your scene and make it a child of the `WinFlag` GameObject. The pole of the flag should be positioned inside `WinFlag‘s` collider. Resize or reposition the collider if necessary.|
| [14. (Sea)horse race](./Assets/) | Download this [flag texture](https://intranet-projects-files.s3.amazonaws.com/holbertonschool-cs-unity/435/Flag.png). Place it in a new directory called `Textures`.  Inside the `Materials` folder, create a new Material called `Flag` and apply it to the rectangular flag portion of the Flag model. Apply the existing `Wood` Material to the flagpost portion of the model.|
| [15. Under development](./Builds/) | Make sure to run your build and make sure it works! Test your build on all three platforms if possible, but at the very least test on your own computer. |
|  |   |

---
> ## contact 💬

| [twitter](https://twitter.com/RICARDO1470) | [linkedin](https://www.linkedin.com/in/ricardo-alfonso-camayo/) | [mail](1466@holbertonschool.com) | [github](https://github.com/ricardo1470/README/blob/master/README.md) |
|---|---|---|---|

---

## License
*`0x05. Unity - Assets: Models, Textures` is open source and therefore free to download and use without permission.*

<a href="url"><img src="https://www.holbertonschool.com/holberton-logo.png" align="middle" width="100" height="30"></a>

---
