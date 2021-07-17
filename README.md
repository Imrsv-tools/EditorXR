# EditorXR
Author XR in XR

Dependencies:
- `com.unity.xrtools.module-loader`
- `com.unity.xrtools.utils`
- `com.unity.list-view-framework`
- `com.unity.xrtools.spatial-hash`
- `com.unity.xr.legacyinputhelpers`
- `com.unity.xr-line-renderer`
- `com.unity.timeline`
- `com.unity.textmeshpro`

## Versioning
EditorXR currently requires Unity 2019.4.x. At the time of writing, we are working with 2019.4.28f1

## Prerequisites
* Install Unity Hub: https://unity3d.com/get-unity/download
* Install the Unity version listed above using Unity Hub
* Install wsl2: https://docs.microsoft.com/en-us/windows/wsl/install-win10
* Enable wsl filesystem metadata: https://alessandrococco.com/2021/01/wsl-how-to-resolve-operation-not-permitted-error-on-cloning-a-git-repository

## Tips
* I create a directory for `imrsv` in my Windows Documents folder, and create / clone all of my Unity projects etc within in
* I create a symlink in my wsl2 home directory linking `imrsv` in Documents using: `cd ~; ln -s /mnt/c/Users/<windows-short-username>/Documents/imrsv

## Adding EditorXR to a fresh Project
* Create a fresh project from Unity Hub using the version listed above... and then close it
* Clone the repo into the new Project using your wsl terminal:
```shell
cd <project>/Packages
git clone --recurse-submodules git@github.com:Imrsv-tools/EditorXR.git
```
* If you want to work a specific branch, checkout that branch:
```shell
cd <project>/Packages/EditorXR
git checkout -t origin/mike-feature-flags
```
* Re-open the project in Unity (It should get packages and stuff it needs... in a minute or two)
* Add a TextMeshPro object to the scene, click "Import TMP Essentials", and then "Import TMP Examples & Extras"... then delete the TextMeshPro object
* Edit -> Project Settings -> EditorXR -> Context Manager -> Include in Player Builds
* Assets -> Create -> EditorXR -> Default Script References
* Create an empty GameObject, add Component for "Editing Context Manager"
* Edit -> Project Settings -> Player -> XR Settings -> Virtual Reality Supported

## Tests / Things which should work
* Trigger EditorXR within Unity: Window -> EditorXR
* Create a Build: File -> Build and Run -> Create a directory for "Builds"
