# Garbage Cleanup Frontline

An environmental-awareness 2D side-scrolling game developed as an undergraduate graduation project with Unity and C#.

## Project overview

The game uses collection and obstacle mechanics to communicate an environmental-protection theme. The project was developed independently, covering gameplay implementation, scene construction, UI, sound integration, and debugging.

## Highlights

- Three playable levels plus menu and ending scenes
- Player movement, jumping, crouching, damage feedback, and scene restart
- Patrol enemies with reusable base-class and subclass behaviour
- Item collection, animation feedback, and on-screen counters
- Scene transitions, context prompts, pause menu, volume control, and exit flow
- Parallax background and gameplay audio integration

## Tech

- Unity 2018.4.13f1
- C#
- Unity 2D Physics, Animator, Scene Management, UI, Audio Mixer

## Repository scope

This is a portfolio source snapshot. It includes the original gameplay scripts, authored scene files, package manifest, and project settings. Unity cache folders, generated IDE files, the thesis document, and third-party asset packages are intentionally excluded. As a result, the project is provided for code review and portfolio reference rather than as a ready-to-build distribution.

## Key scripts

- `Assets/Script/Playercontroller.cs` — player controls, interactions, collection count, and restart flow
- `Assets/Script/Enemy/` — reusable enemy behaviour and patrol variants
- `Assets/Script/Menu.cs` — start, pause, resume, volume, and quit controls
- `Assets/Script/EnterNext.cs` — level transitions
- `Assets/Script/Parallax.cs` — background parallax scrolling

## 项目简介

《垃圾清理战线》是一款以环保为主题的 2D 横版游戏。本项目为本科毕业设计，使用 Unity 与 C# 独立完成，涵盖关卡搭建、角色与怪物逻辑、物品收集、UI、音效与调试。

本仓库是用于求职展示的源码快照，仅保留本人编写的代码、场景与项目配置；Unity 缓存、自动生成文件、论文和第三方素材包均未公开。
