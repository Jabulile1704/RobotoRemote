Arduino LED Remote — C# Windows Forms Controller

Overview
This project bridges a C# desktop GUI with an Arduino microcontroller using serial communication. The Windows Form acts as the remote — each button press sends a command string over the COM port, which the Arduino parses and uses to drive the corresponding LED pin HIGH or LOW.

Features

Connect to any available COM port via a dropdown selector
Individual ON / OFF control for each of the 4 LEDs
All ON and All OFF global controls
Live connection status indicator
Friendly error handling for port access issues
Clean serial port release on application close


Hardware Requirements
ComponentQuantityArduino Uno (or compatible)1Breadboard1LED — Red1LED — Yellow1LED — Green1LED — Blue1220Ω resistors4Jumper wiresAs neededUSB A to B cable1
Pin Mapping
LEDArduino PinRed13Yellow12Green11Blue10

Software Requirements

Windows 10 or later
Visual Studio 2019 / 2022
.NET Framework 4.7.2+ (or .NET 6+)
Arduino IDE (for uploading the sketch)


Getting Started
1. Upload the Arduino Sketch
Open ArduinoLEDRemote.ino in the Arduino IDE and upload it to your board. The sketch listens on serial at 9600 baud and responds to the following commands:
CommandActionRED_ON / RED_OFFToggle red LEDYELLOW_ON / YELLOW_OFFToggle yellow LEDGREEN_ON / GREEN_OFFToggle green LEDBLUE_ON / BLUE_OFFToggle blue LEDALL_ONTurn all LEDs onALL_OFFTurn all LEDs off
2. Run the C# Application

Clone this repository
Open ArduinoLEDRemoote.sln in Visual Studio
Build and run the project (F5)
Select the correct COM port from the dropdown
Click Connect
Use the ON / OFF buttons to control each LED


Important: Close the Arduino IDE Serial Monitor before launching the application — both cannot hold the COM port at the same time.


Project Structure
ArduinoLEDRemoote/
├── ArduinoLEDRemoote.sln       # Visual Studio solution
├── ArduinoLEDRemoote/
│   ├── Form1.cs                # Main form logic and serial communication
│   ├── Form1.Designer.cs       # Auto-generated UI layout
│   ├── Program.cs              # Application entry point
│   └── ArduinoLEDRemoote.csproj
└── Arduino/
    └── ArduinoLEDRemote.ino    # Arduino sketch

How It Works
[ C# Windows Form ]
        |
        |  serialPort.WriteLine("RED_ON\n")
        |  USB / Serial (9600 baud)
        ↓
[ Arduino Uno ]
        |
        |  Serial.readStringUntil('\n') → parse command
        |
        ↓
[ digitalWrite(LED_RED, HIGH) ]
The C# app uses System.IO.Ports.SerialPort to open the COM port and write newline-terminated command strings. The Arduino's loop() checks Serial.available() on every cycle, reads the incoming string, trims whitespace, and maps it to a digitalWrite call on the appropriate pin.

Troubleshooting
IssueFix"Access to port denied"Close Arduino IDE Serial Monitor before running the appNo COM ports listedCheck Device Manager → Ports (COM & LPT); replug the ArduinoButtons not respondingVerify baud rate is 9600 on both sides; re-upload the sketchLEDs not lighting upCheck resistors are in place; confirm correct pin wiring

Author
Jabu — Software Development Facilitator & Aspiring Cloud Engineer
Co-founder, Mashibini Technologies
