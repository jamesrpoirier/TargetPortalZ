# TargetPortalZ

TargetPortalZ is a Valheim 1.0 compatibility fork of Smoothbrain's TargetPortal. Enter a portal to open the map, then select any discovered portal by map marker or by name.

## Features

- Teleport to any discovered portal from the map.
- Click a portal in the alphabetical named-portal list.
- Optionally carry metal and other normally restricted items.
- Use a short teleport transition.
- Configure portal visibility, access modes, naming, and limits through BepInEx.

## Local installation

Place `TargetPortalZ.dll` in the selected profile's `BepInEx/plugins` directory and launch Valheim modded. Configuration is written to `BepInEx/config/com.jamesrpoirier.targetportalz.cfg`.

The mod is tested locally against Valheim 1.0 and includes Thunderstore package metadata under `thunderstore/`.

## Attribution

Based on [TargetPortal](https://github.com/blaxxun-boop/TargetPortal) by Smoothbrain. TargetPortalZ retains the upstream portal discovery, synchronization, and access-mode design while updating compatibility and user interaction for Valheim 1.0.
