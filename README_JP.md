# UnityEditorIcons
Utility class to get Unity built-in icon as property

<img src="https://github.com/AnnulusGames/UnityEditorIcons/blob/main/Assets/UnityEditorIcons/Documentation~/img1.png" width="500">

[![license](https://img.shields.io/badge/LICENSE-MIT-green.svg)](LICENSE)

[English README](README.md)

## 概要
UnityEditorIconsは、1000以上あるUnityエディタのアイコンを簡単に取得することを可能にするライブラリです。
全てのアイコンをEditorIconsクラスのプロパティとして取得することができます。

## セットアップ

### インストール
1. Window > Package ManagerからPackage Managerを開く
2. 「+」ボタン > Add package from git URL
3. 以下を入力する
   * https://github.com/AnnulusGames/UnityEditorIcons.git?path=/Assets/UnityEditorIcons


あるいはPackages/manifest.jsonを開き、dependenciesブロックに以下を追記

```json
{
    "dependencies": {
        "com.annulusgames.unity-editor-icons": "https://github.com/AnnulusGames/UnityEditorIcons.git?path=/Assets/UnityEditorIcons"
    }
}
```

### Namespace
UnityEditorIconsを利用する場合は、ファイルの冒頭に以下の一行を追加します。

```cs
using AnnulusGames.UnityEditorIcons;
```

## 使い方

EditorIconsクラスからアイコンを取得できます。

```cs
//Helpアイコンを取得
GUIContent icon = EditorIcons.Help;
```

コンポーネントのアイコンを取得したい場合はGetComponentIconを利用します。

```cs
//Rigidbodyのアイコンを取得
GUIContent icon = EditorIcons.GetComponentIcon<Rigidbody>();
```

取得可能なアイコンはWindow > Editor Icon Browserから確認できます。

## ライセンス

[Mit License](LICENSE)
