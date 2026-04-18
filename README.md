# GPDebugger

A debugging plugin for the **EXILED framework** in SCP: Secret Laboratory.
It captures event logs, handler activity, and network activity, then prints readable output to the in-game client console.

## Features

- **Event logging**: Automatically subscribes to `Exiled.Events.Handlers` events and prints their values.
- **Handler filtering**: Restrict logging to selected handlers with `handler_whitelist`, or hide specific handlers at runtime.
- **Event ignoring**: Ignore spammy event names from the console output.
- **Network logging**: Track network methods and network messages in real time.
- **Network ignoring**: Ignore specific network method or message names from the console output.
- **Object inspection**: Use `gpdebug print hit` to inspect the object you are looking at.
- **Feature inspection**: Use `gpdebug print <class>` or `gpdebug print player` to inspect Exiled feature classes or players.

## Commands

Use these commands in the Remote Admin console.

| Command | Description |
|---|---|
| `gpdebug` or `gpdebug help` | Show detailed help. |
| `gpdebug handler start` | Enable event handler logging for you. |
| `gpdebug handler stop` | Disable event handler logging for you. |
| `gpdebug handler ignore add <HandlerName>` | Ignore a handler from event logging. |
| `gpdebug handler ignore remove <HandlerName>` | Remove a handler from the ignore list. |
| `gpdebug handler list` | Show handler whitelist, ignored handlers, active handlers, and available `Exiled.API.Features` classes. |
| `gpdebug network start` | Enable network logging for you. |
| `gpdebug network stop` | Disable network logging for you. |
| `gpdebug network ignore add <Name>` | Ignore a network method or network message. |
| `gpdebug network ignore remove <Name>` | Remove a network method or network message from the ignore list. |
| `gpdebug network list` | Show ignored and active network methods/messages. |
| `gpdebug print <class>` | Print public static properties of an Exiled feature class. |
| `gpdebug print player [name/id]` | Print player properties for yourself or a target player. |
| `gpdebug print hit` | Inspect the object you are looking at and matched Exiled API features. |

## Configuration

```yml
gp_debugger:
  is_enabled: true
  debug: false
  console_message_length_limit: 100
  console_message_color: 'white'
  handler_whitelist: []
  ignored_handlers: []
  ignored_events:
  - 'Player.MakingNoiseEventArgs'
  - 'Player.TriggeringTeslaEventArgs'
  - 'Item.UsingRadioPickupBatteryEventArgs'
  - 'Item.UsingRadioBatteryEventArgs'
  ignored_network_methods:
  - 'TargetReplyEncrypted'
  - 'TargetSyncGameplayData'
  - 'CmdSendEncryptedQuery'
  ignored_network_messages:
  - 'SpawnMessage'
  - 'ObjectDestroyMessage'
  - 'NetworkPingMessage'
  - 'NetworkPongMessage'
  - 'FpcFromClientMessage'
  - 'SubroutineMessage'
  - 'StatMessage'
  - 'VoiceMessage'
  - 'TransmitterPositionMessage'
  - 'ElevatorSyncMsg'
  - 'FpcOverrideMessage'
  - 'TimeSnapshotMessage'
  - 'EntityStateMessage'
  - 'FpcPositionMessage'
  - 'EncryptedMessageOutside'
```

## Notes

- `handler_whitelist` is an allow-list. If it contains items, only those handlers are shown.
- `ignored_handlers` hides specific handlers from handler logging.
- `ignored_events` suppresses specific event names.
- `network` logging is controlled at runtime with `gpdebug network start/stop`.
- `ignored_network_methods` and `ignored_network_messages` hide specific network items.

## Requirements

- [EXILED Framework](https://github.com/Exiled-Team/EXILED)

## Author

- **GoldenPig1205**








