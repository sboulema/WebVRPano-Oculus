# WebVRPano-Oculus
WebVRPano Oculus Handler

# Installation
1. Install [Oculus Runtime 0.8.0.0](https://developer.oculus.com/downloads/pc/0.8.0.0-beta/Oculus_Runtime_for_Windows/)
2. Install [Chromium WebVR 0.8.0.0](https://drive.google.com/uc?export=download&confirm=Dvgh&id=0BzudLt22BqGRTHFTSExmelFDRUk)
3. Install [Nvidia Geforce Drivers](http://www.geforce.com/drivers/results/95553) (minimum required version 358.70)
4. Copy WebVRPano Oculus Handler to the Chromium WebVR folder
5. Import Registry file to enable pano:// handling

# Registering the pano Handler
    Windows Registry Editor Version 5.00

    [HKEY_CLASSES_ROOT\pano]
    @="URL:Custom Protocol"
    "URL Protocol"=""

    [HKEY_CLASSES_ROOT\pano\DefaultIcon]
    @="C:\\Program Files (x86)\\WebVRPano Oculus\\WebVRPano-Oculus.exe,0"

    [HKEY_CLASSES_ROOT\pano\shell]

    [HKEY_CLASSES_ROOT\pano\shell\open]

    [HKEY_CLASSES_ROOT\pano\shell\open\command]
    @="\"C:\\Program Files (x86)\\WebVRPano Oculus\\WebVRPano-Oculus.exe\" \"%1\""
