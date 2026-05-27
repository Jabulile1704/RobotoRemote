#define LED_RED    13
#define LED_YELLOW 12
#define LED_GREEN  11
#define LED_BLUE   10

void setup() {
  pinMode(LED_RED, OUTPUT);
  pinMode(LED_YELLOW, OUTPUT);
  pinMode(LED_GREEN, OUTPUT);
  pinMode(LED_BLUE, OUTPUT);

  Serial.begin(9600); // Open serial at 9600 baud
}

void loop() {
  if (Serial.available() > 0) {
    String command = Serial.readStringUntil('\n');
    command.trim(); // Remove whitespace/newlines

    if (command == "RED_ON")    digitalWrite(LED_RED, HIGH);
    if (command == "RED_OFF")   digitalWrite(LED_RED, LOW);

    if (command == "YELLOW_ON")  digitalWrite(LED_YELLOW, HIGH);
    if (command == "YELLOW_OFF") digitalWrite(LED_YELLOW, LOW);

    if (command == "GREEN_ON")  digitalWrite(LED_GREEN, HIGH);
    if (command == "GREEN_OFF") digitalWrite(LED_GREEN, LOW);

    if (command == "BLUE_ON")   digitalWrite(LED_BLUE, HIGH);
    if (command == "BLUE_OFF")  digitalWrite(LED_BLUE, LOW);

    if (command == "ALL_ON") {
      digitalWrite(LED_RED, HIGH);
      digitalWrite(LED_YELLOW, HIGH);
      digitalWrite(LED_GREEN, HIGH);
      digitalWrite(LED_BLUE, HIGH);
    }

    if (command == "ALL_OFF") {
      digitalWrite(LED_RED, LOW);
      digitalWrite(LED_YELLOW, LOW);
      digitalWrite(LED_GREEN, LOW);
      digitalWrite(LED_BLUE, LOW);
    }
  }
}