# Restart Planter

## WARNING: READ THE FULL DESCRIPTION

# DO NOT USE THIS ON ANYONE, THIS IS FOR EDUCATIONAL PURPOSES ONLY. I TAKE NO RESPONSIBILITY FOR ANY ACTIONS TAKEN BY ANYONE WHO USES A PUBLIC MIT LICENSED CODEBASE

This is a simple application built to demonstrate, at a training seminar, how easy malware/exploits can be hidden or distributed. This code does not inflict any lasting or catastrophic damage to any hardware or data.

All this application does is add a batch file to the startup folder that restarts the PC after 20 seconds (To cancel use Win + R and type shutdown -a). Once it adds the batch file, the application displays an 'error' telling the user to try again later.

##Important information

- The batch file is saved in the following directory :
```
C:\Users\username\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup
```
- The application asks for admin rights to perform the action, this is to demonstrate how easily people will just allow admin rights to software
- Once the application has ran, it displays the following screen:
