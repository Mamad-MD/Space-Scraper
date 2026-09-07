# 🚀 Space Scraper

A small VR game built with Unity, set in a sci-fi space station with object interaction and rock breaking using a laser pistol.

<p align="center">
  <img src="docs/media/g1_small.gif" alt="Gameplay 1" width="360">
  <img src="docs/media/g2_small.gif" alt="Gameplay 2" width="360">
</p>

<p align="center">
  <img src="docs/media/g3_small.gif" alt="Gameplay 3" width="360">
  <img src="docs/media/g4_small.gif" alt="Gameplay 4" width="360">
</p>

## 🛠 Technologies

| Technology             | Version         |
| ---------------------- | --------------- |
| Unity                  | 2022.3.62f3 LTS |
| XR Interaction Toolkit | 2.6.4           |
| OpenXR Plugin          | 1.14.3          |
| XR Management          | 4.7.0           |

## 🧩 Main Scripts

* `MeteorPistol.cs` — Laser shooting and raycast logic.
* `Breakable.cs` — Handles breakable objects.
* `TriggerZone.cs` — Generic trigger zone and UnityEvent handling.
* `TrashCan.cs` — Handles object disposal.
* `DisableGrabbingHandModel.cs` — Hides the VR hand model while grabbing.

## ▶️ Run

1. Install **Unity 2022.3.62f3 LTS**.
2. Clone the repository:

```bash
git clone https://github.com/Mamad-MD/Space-Scraper.git
```

3. Open the project with Unity Hub.
4. Open:

```text
Assets/Scenes/SampleScene.unity
```

5. Connect an OpenXR-compatible VR headset and press **Play**.

The project can also be tested without a headset using **XR Device Simulator**.

## 📁 Project Structure

```text
Assets/
├── Scenes/SampleScene.unity
├── MeteorPistol.cs
├── Breakable.cs
├── TriggerZone.cs
├── TrashCan.cs
├── DisableGrabbingHandModel.cs
├── Sci-Fi Styled Modular Pack/
├── Lets Make a VR Game/
└── AkdumanDev/
```

## 🙏 Credits

* Sci-Fi Pistol — Pablo88 ([Sketchfab](https://sketchfab.com/3d-models/sci-fi-pistol-3d7aca39ec9f4aba98642705c0bed2bb))
* Robot Hand — Inferno Digital / DudleyLong ([RoboHands-UnityXR](https://github.com/InfernoDigital/RoboHands-UnityXR))
* Milky Way Panorama — ESO / S. Brunier
* UI 3D Examples — Unity Technologies / XR Interaction Toolkit

## 👤 Developer

Made by [Mamad-MD](https://github.com/Mamad-MD)
