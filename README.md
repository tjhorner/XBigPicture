# XBigPicture

It opens Big Picture when you connect a controller!

It expects Steam to be located in `C:\Program Files (x86)\Steam\Steam.exe`. If it isn't, make a symbolic link to there or change the value and compile it yourself.

(I'll add an option to change it later)

## Installation

I've compiled some pre-built binaries on the releases page along with a simple installer. (coming soon!)

## Usage

1. Open it.
2. Try turning on your controller.
3. If Big Picture opens, you're good to go.

You can disable it from either the context menu or control panel. If you want to enable this on startup, just make a shortcut in your Startup folder.

## Compilation

You'll need to reference XInputDotNetPure in Visual Studio to compile or it will throw errors. You'll also need to include XInputInterface.dll with every release. Both can be found [here](https://github.com/speps/XInputDotNet/releases).

## Libraries Used

[XInputDotNet](https://github.com/speps/XInputDotNet)
