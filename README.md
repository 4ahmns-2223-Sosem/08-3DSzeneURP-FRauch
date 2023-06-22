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
  
Limitations:
+ compile errors
+ can't use the whole Controller.cs script due to previous bugs
+ character can't look vertical, even though he should
+ character walks backwars (S - forward, W - backwards, ....) - character is disabled right now
  
