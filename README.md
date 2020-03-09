# SequenceLogger

Logs when various C:SL events occur, useful for discovering the sequence in which they occur.

## Event logging

Implicit calls to mod classes:

* IUserMod
* LoadingExtension
* ThreadingExtension

Managers:

* LoadingManager
* LocaleManager
* PluginManager
* SceneManager

Does not currently log an in-game events, but those can be added.

## Build

It should automatically find your `Managed` folder so there's usually no need to manually add reference paths.

If you run in to problems, see the TM:PE [Build Guide](https://github.com/CitiesSkylinesMods/TMPE/blob/master/docs/BUILDING_INSTRUCTIONS.md) as we use basically the same setup.

## Contributing

Please contribute to make it better :)
