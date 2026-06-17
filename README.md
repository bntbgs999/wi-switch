# WiSwitch

**Seamless Wi-Fi Profile Switching with a Single Keystroke**

WiSwitch is a lightweight Windows desktop utility built with C# and Windows Forms. It enables users to quickly switch between saved Wi-Fi profiles using a global hotkey, eliminating the need to navigate through system settings.

The tool is designed to improve efficiency in environments where multiple network connections are frequently used, such as development, testing, and enterprise setups.

---

## Use Cases & Value Proposition

### Developer / IT Workflow

WiSwitch simplifies working across multiple network environments.

- **Scenario:** Switching between office Wi-Fi, mobile hotspot, and local network setups.
- **Value:** Reduces friction when testing services across different network conditions and eliminates dependency on Windows network UI.

### QA / Network Testing

Useful for validating application behavior under varying network conditions.

- **Scenario:** Testing unstable connections, captive portals, or network switching behavior.
- **Value:** Enables rapid switching between profiles to simulate real-world user scenarios.

### Office / Multi Access Point Environments

Addresses common issues in enterprise Wi-Fi deployments.

- **Scenario:** Devices staying connected to weak or distant access points.
- **Value:** Allows manual override to connect to a more optimal network instantly.

---

## Key Features

- **Global Hotkey (`Ctrl + /`)**
  Instantly switch between configured Wi-Fi profiles from anywhere.

- **Custom Wi-Fi List**
  Maintain a curated list of networks for quick rotation.

- **Wi-Fi Profile Discovery**
  Load saved Wi-Fi profiles from the system and add them with a double-click.

- **Minimal Interface**
  Lightweight and unobtrusive UI focused on functionality.

---

## How to Use

1. Launch the application.
2. Click **"Cek WiFi"** to load available Wi-Fi profiles stored on your system.
3. Double-click a network to add it to your switching list.
4. Optionally edit or manage the list manually.
5. Press **Ctrl + /** to switch to the next Wi-Fi network and connect instantly.

---

## Technical Stack

- **Language:** C#
- **Framework:** .NET (Windows Forms)
- **Platform:** Windows 10 / 11

---

## Build & Distribution

To generate a standalone executable:

```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

The output will be a single executable file that runs without requiring a .NET runtime installation.

Or you can just install the .exe file

## Notes

- This application is Windows-only.
- Wi-Fi profiles must already be saved on the system.
- Some environments may require elevated privileges.
- Windows Forms trimming is not supported and should be avoided.

---

## Security Considerations

- Input validation is implemented to reduce command injection risks.
- Wi-Fi names containing special shell characters should be avoided.
- The application relies only on trusted system commands (`netsh`).

---

## Future Enhancements

- Automatic switching based on signal strength or latency
- Network priority configuration
- System tray mode for background operation
- Connection monitoring and status feedback
- Logging and diagnostics

---

## License

This project is available for personal and educational use. Contributions and improvements are welcome.
