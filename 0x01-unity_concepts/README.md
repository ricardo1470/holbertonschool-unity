> # 0x01. Unity - Unity Concepts
---
| **Filename** | **Description** |
|---|---|
| [0. Floor plans](./) | new 3D Unity project called `0x01-unity_concepts`. Save your new scene as `0-floor`. Create a new Cube GameObject named `Floor` with the following Transform properties:  Position: `X: 0`, `Y: 0`, `Z: 0`, Rotation: `X: 0`, `Y: 0`, `Z: 0`, Scale: `X: 16`, `Y: 0.5`, `Z: 16` |
| [1. On the ball](./) | Duplicate `0-floor` by selecting the scene in the Project window and either `Edit > Duplicate` from the Toolbar or `CTRL / CMD + D`. Rename the scene `1-ball` and open it. Create a new Sphere GameObject named `Ball` with the following Transform properties: Position: `X: 0`, `Y: 8`, `Z: 0`, Rotation: `X: 0`, `Y: 0`, `Z: 0`, Scale: `X: 1.5`, `Y: 1.5`, `Z: 1.5` |
| [2. Colors!](./) | Duplicate `1-ball`, rename it `2-colors`, and open it. Create a `Materials` folder in the Project window, then create a new material named `floor`. In the Inspector window, change the Albedo color to any color you like using the color picker. Assign the material to the Floor GameObject. Create a second new material named `ball`. Change the material color and assign the new material to the Ball GameObject.  |
| [3. Gravity is a harsh mistress](./) | Duplicate `2-colors`, rename it `3-gravity`, and open it. Add a Rigidbody Component to the Ball GameObject. Press Play to see what happens. Wouldn’t it be better if the ball bounced when it fell?. Create a new folder in the Project window named `Physic Materials` and create a new Physic Material called `bounce`. Feel free to edit the material’s settings to get an idea of what the different settings affect. Add the `bounce` material to the Ball’s Sphere Collider. Press `Play`. For this task, your final `bounce` material settings should be: `Bounciness: 0.8`, `Bounce Combine: Maximum` |
| [4. Prefabricated](./) | Duplicate `3-gravity`, rename it `4-prefab`, and open it. Create a new folder named `Prefabs`. Create a prefab from the Ball inside the new folder, then, using the prefab, add four more instance of the Ball to the scene. Position and scale them any way you like.  |
| [5. Even more colors!](./) | Duplicate `4-prefab`, rename it `5-more_colors`, and open it. Change the colors of each ball so they are different hex colors as defined below. New materials should be named as listed below. You cannot use scripts in this task. `ball-red : FF0000FF`, `ball-blue : 0000FFFF`, `ball-green : 00FF00FF`, `ball-white : FFFFFFFF`, `ball-black : 000000FF`. Take a look at the Hierarchy window. Having a bunch of GameObjects with the same name is hard to navigate, right? It’s important to clearly name your GameObjects and assets, especially when working with others in the same project. Rename each Ball GameObject in your scene with their color name. `Red Ball`, `Blue Ball`, `Green Ball`, `White Ball`, `Black Ball` |
| [6. Tag yourself](./) | Duplicate `5-more_colors`, rename it `6-tags`, and open it. Add a tag to all Ball objects called `Obstacles`.  |
|   |   |
---
> ## contact 💬

| [twitter](https://twitter.com/RICARDO1470) | [linkedin](https://www.linkedin.com/in/ricardo-alfonso-camayo/) | [mail](1466@holbertonschool.com) | [github](https://github.com/ricardo1470/README/blob/master/README.md) |
|---|---|---|---|

---

## License
*`0x01. Unity - Unity Concepts` is open source and therefore free to download and use without permission.*

<a href="url"><img src="https://www.holbertonschool.com/holberton-logo.png" align="middle" width="100" height="30"></a>

---
