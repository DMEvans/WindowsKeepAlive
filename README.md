#Windows KeepAlive
A Windows desktop application that will prevent your PC from locking or going into sleep mode. Useful for presentations where content may be required to remain on screen without regular input.

##Usage
The application has a simple activate/deactivate button.  You can optionally set an expiry time in which to deactivate the "KeepAlive" mode.

![alt-text][main-form]

Depending on whether an expiry time was a notification balloon will be shown when the "KeepAlive" mode is activated.

![alt-text][active-indefinite] ![alt-text][active-until]

When the "KeepAlive" mode is deactivated a notification balloon will be displayed and Windows will continue with it's usual lock/sleep policy.

![alt-text][deactivated]

A context menu is available on the notification icon to activate/deactivate the "KeepAlive" mode, or close the application.  Closing the application will also deactivate the "KeepAlive" mode.

![alt-text][context-menu]

[active-indefinite]: https://github.com/DMEvans/WindowsKeepAlive/raw/master/screenshots/active-indefinite.png "Active Indefinitely"
[active-until]: https://github.com/DMEvans/WindowsKeepAlive/raw/master/screenshots/active-until.png "Active Until Expiry Time"
[context-menu]: https://github.com/DMEvans/WindowsKeepAlive/raw/master/screenshots/context-menu.png "Context Menu"
[deactivated]: https://github.com/DMEvans/WindowsKeepAlive/raw/master/screenshots/deactivated.png "Deactivated"
[main-form]: https://github.com/DMEvans/WindowsKeepAlive/raw/master/screenshots/main-form.png "Main Form"
