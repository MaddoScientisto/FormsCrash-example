# FormsCrash

This repository showcases an issue with Visual Studio and designing inherited forms that contain external DLL references, in this case Revit API.

In this project, frmIBase contains a reference to Revit and just creates an object from its library, then Form1 inherits from that form and doesn't do anything else, in this case the visual studio editor will crash with various messages, usually "could not find RevitApiUi.dll"

Revit addins are not meant to run standalone and need to be hosted inside Revit, however it is normally possible to design the forms in visual studio, this can be observed by loading Form2 in the designer: that form has a direct reference, does not inherit from any other form, and loads properly in the designer.

This is not strictly a .NET 8 problem, looks like it's happening even on .net 4.8 and visual studio 2019