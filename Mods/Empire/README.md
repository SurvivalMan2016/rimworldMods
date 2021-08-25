# Empire-Mod
The repository for the empire mod for rimworld
Empire mod is a mod for Ludeon Studio's topdown base building-exploration game Rimworld.
It adds the ability to found your own empire and have colonies not controlled by you give you silver and items, as well as provide you with troops.
This mod was initially developed by Saakra, a lone Mod Dev. He has since moved on due to IRL issues and handed over the reigns of development to me and Shalax.

## Building
To build using the dotnet cli, go to `Source/FactionColonies` and run `dotnet build`. The Assembly will output to the Assemblies folder, along with debug symbols.

To get IDE decompilation of the Rimworld DLL, import the FactionColonies-FileReference file instead of FactionColonies, 
and make sure the folder is in your Rimworld/Mods folder.
