 #!/bin/bash
 #######################################################################
 # Title	:	FFMPEG Installer for Debian 8 (using Backport)
 # Author	:	Eleria (imsoundoflight@gmail.com)
 # Date		:	14.07.16
 # Requires	:	dialog
 #######################################################################
 # Description	:	A small Installer for FFMPEG on Debian using the
 #			Debian Jessie Backport
 #######################################################################
 
 echo "Initialising Installer"
 echo "Updating System..."
 apt-get update
 echo "Installing Gui-Handler"
 apt-get install dialog -y
 echo "Installer is starting"
 dialog --msgbox "FFMPEG Installer v1.0 by Eleria" 0 0
 echo "deb http://ftp.debian.org/debian jessie-backports main" | tee /etc/apt/sources.list.d/debian-backports.list
 apt-get update
 apt-get install ffmpeg -y
 dialog --msgbox "Installation of FFMPEG done. Cleaning up.." 0 0
 apt-get purge dialog -y
 echo "Installer cleanup complete."
 echo "Finishing up."
 clear 
 exit 0
 