# XFactory Unity Project

## Overview
**XFactory** is a Unity-based project created for the [XR for Engineering](https://mohsen-moghaddam.github.io/XRE/) course, containing all core assets, scenes, and scripts needed for the semester’s development work.  
The project is designed to be modular and organized, ensuring easy collaboration and extension.

---

## Project Structure

```
Root/
├── Assets/                   # Main Unity assets
│   ├── Settings/             # Project-wide settings and configurations
│   ├── XFactory/             # Core project assets used throughout the semester
│   │   ├── Animations/       # Animation controllers, clips, and related assets
│   │   ├── Audio/            # Sound effects and music files
│   │   ├── Materials/        # Material definitions for rendering
│   │   ├── Models/           # 3D model files
│   │   ├── Prefabs/          # Prefabricated objects for reuse
│   │   ├── Scenes/           # Unity scene files
│   │   ├── Scripts/          # C# scripts for game logic
│   │   └── Textures/         # Image textures for materials
├── CustomPackages/           # Custom Unity packages
├── Packages/                 # Unity package dependencies
├── ProjectSettings/          # Unity project configuration files
├── .gitattributes            # Git LFS and attribute rules
└── .gitignore                # Ignored files and folders
```

---

## Getting Started

1. **Clone the Repository:**
```bash
git clone https://github.com/XR-for-Engineering/XFactory.git
```

2. **Open in Unity:**
  - Use **Unity Hub** to open the project folder.
  - The project was built using **Unity 6.1 (6000.1.4f1)**. Ensure you use the correct Unity version to avoid compatibility issues.

3. **Git LFS Setup:**
  - This repository uses **Git Large File Storage (LFS)** for assets.
  - Make sure LFS is installed before pulling:
```bash
git lfs install
git lfs pull
```

---

## Contents

- **Animations** – All animation assets for equipment, objects, and effects.
- **Audio** – Sound effects and background music.
- **Materials** – Defines how models and textures are rendered.
- **Models** – 3D objects used in the game.
- **Prefabs** – Reusable object templates.
- **Scenes** – Different levels or environments of the project.
- **Scripts** – Core game logic written in C#.
- **Textures** – Images applied to 3D models.

---

## Development Guidelines

- Always pull the latest changes before starting work:
```bash
git pull
git lfs pull
```
- Commit only relevant changes — avoid committing temporary or generated files.
- Large assets (e.g., `.fbx`, `.wav`, `.png`) should be tracked via **Git LFS**.
- Follow Unity’s recommended folder structure for assets to keep things clean.

---

## License
This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

---

## Contributors
- **Project Lead & Developer:** Mohsen Moghaddam
- **Optimization:** Parisa Ghasemi
- **Semester Participants:** Students enrolled in XR for Engineering course.

---

> This README will be updated as the project evolves through the semester.