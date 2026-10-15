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

This is a portfolio source snapshot. It includes the original gameplay scripts, authored scene files, package manifest, and project settings. The self-created map, visual, animation, and four original background-music assets are available as a downloadable archive: [`garbage-cleanup-frontline-authored-assets.zip`](./PortfolioAssets/garbage-cleanup-frontline-authored-assets.zip). Unity cache folders, generated IDE files, the thesis document, third-party asset packages, and the third-party fox protagonist asset are intentionally excluded. As a result, the project is provided for code review and portfolio reference rather than as a ready-to-build distribution.

## Key scripts

- `Assets/Script/Playercontroller.cs` — player controls, interactions, collection count, and restart flow
- `Assets/Script/Enemy/` — reusable enemy behaviour and patrol variants
- `Assets/Script/Menu.cs` — start, pause, resume, volume, and quit controls
- `Assets/Script/EnterNext.cs` — level transitions
- `Assets/Script/Parallax.cs` — background parallax scrolling

## 项目简介

《垃圾清理战线》是一款以环保为主题的 2D 横版游戏。本项目为本科毕业设计，使用 Unity 与 C# 独立完成，涵盖关卡搭建、角色与怪物逻辑、物品收集、UI、音效与调试。

本仓库是用于求职展示的源码快照，保留本人编写的代码、场景与项目配置。本人制作的地图与美术资源、动画资源，以及 4 首原创背景音乐已打包在 [`garbage-cleanup-frontline-authored-assets.zip`](./PortfolioAssets/garbage-cleanup-frontline-authored-assets.zip) 中供下载；Unity 缓存、自动生成文件、论文、第三方素材包和小狐狸主角素材均未公开。
