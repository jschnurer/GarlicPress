# GarlicPress

GarlicPress is a companion application for the RG35xx running [GarlicOS](https://www.patreon.com/posts/garlicos-for-76561333). The main aim of the application is to never require you to remove the SDCards from your device.

Version 0.16072033
## Features
* Easily view files stored in the Roms folders for each system and SD Card
* Scrape game art from [screenscraper.fr](https://screenscraper.fr)
* Delete files from the Roms folders
* Edit the skin configuration and preview (not all features enabled yet)
* Simple console for executing commands on the device
* Backup save game files

## Not Yet but Coming Soon Features
* Copy files to the Rom Folders
* Auto Backup when device is connected
* Speed up backups (only backup changes)
* Restore Saves
* Rename Files
* Full Skin configuration editing

## How to Setup GarlicPress 
GarlicPress uses ADB to comunicate with the RG35xx and GarlicOS over usb. By default garlicOS disables ADB but it can be enabled very easily.
### Enabling ADB
* Insert the main SD card into a PC
* On the Misc partition (not the larger partition with Roms foldeer) create a text file in the root of the drive. Rename this new file to "enableADB" making sure to remove the .txt file extention.
  ![image](https://github.com/prosthetichead/GarlicPress-Release/assets/1934681/4d7718a1-f4e3-42ae-bd96-11780ff07f2e)
* Reinsert the SD Card into the RG35xx and GarlicPress should now be able to connect to the device over USB if it is turned on (not on the battery charging screen).
  
  
