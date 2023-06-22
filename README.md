# 08-3DSzeneURP-FRauch

**Beschreibung:** 3D-Szene für ein gemeinsames Schulprojekt
Eine Landschaft, in der ein Windrad steht. Beim näher kommen an das Windrad, erklärt eine Stimme die aus dem „nichts“ kommt, wie es funktioniert, und welche die positiven, aber auch negativen Aspekte sind. Man kann das Windrad über den roten Knopf ein und ausschalten.

**Entwicklungsplattform**
+ Windows 10
+ Visual Studio 2019
+ Unity 2020.3.18f1

Lessons Learned:
+ Fixing compile errors
+ for-Schleife (Controller.cs Zeile 15)
+ switch/case (Controller.cs Zeile 42)
+ if/else (ObjectVoice.cs Zeile 16)
+ while (Controller.cs Zeile 37
+ letting the windmill loop around the Z axis for a rotation animation
+ implementing sounds into Unity (loops especially)
+ making a character controller on my own
  
![Screenshot 2023-06-22 125737](https://github.com/4ahmns-2223-Sosem/08-3DSzeneURP-FRauch/assets/90834237/9e26e060-465a-4a2d-9a82-ed7c626a5ca7)

![Screenshot 2023-06-22 125903](https://github.com/4ahmns-2223-Sosem/08-3DSzeneURP-FRauch/assets/90834237/849ad77e-663b-42af-af9d-69762d409397)

Limitations:
+ compile errors
+ can't use the whole Controller.cs script due to previous bugs
+ character can't look vertical, even though he should
+ character walks backwars (S - forward, W - backwards, ....) - character is disabled right now
  

