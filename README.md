# UnityEditorIcons
Utility class to get Unity built-in icon as property

<img src="https://github.com/AnnulusGames/UnityEditorIcons/blob/main/Assets/UnityEditorIcons/Documentation~/img1.png" width="500">

[![license](https://img.shields.io/badge/LICENSE-MIT-green.svg)](LICENSE)

[日本語版READMEはこちら](README_JP.md)

## Overview
UnityEditorIcons is a library that allows you to easily get Unity editor icons, which are over 1000.
All icons can be obtained as properties of the EditorIcons class.

## Setup

### Install
1. Open the Package Manager from Window > Package Manager
2. "+" button > Add package from git URL
3. Enter the following to install
   * https://github.com/AnnulusGames/UnityEditorIcons.git?path=/Assets/UnityEditorIcons


or open Packages/manifest.json and add the following to the dependencies block.

```json
{
    "dependencies": {
       "com.annulusgames.unity-editor-icons": "https://github.com/AnnulusGames/UnityEditorIcons.git?path=/Assets/UnityEditorIcons"
    }
}
```

### Namespace
When using UnityEditorIcons, add the following line at the beginning of the file.

```cs
using AnnulusGames.UnityEditorIcons;
```

## How to use

You can get icons from EditorIcons class.

``` cs
//get help icon
GUIContent icon = EditorIcons.Help;
```

Use GetComponentIcon to get the component icon.

``` cs
// Get Rigidbody icon
GUIContent icon = EditorIcons.GetComponentIcon<Rigidbody>();
```

Available icons can be checked from Window > Editor Icon Browser.

## License

[Mit License](LICENSE)
