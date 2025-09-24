int pin2 = 2;
int pin3 = 3;
int pin4 = 4;
int pin5 = 5;

void setup() {
  Serial.begin(9600);
}

void loop() {
  int state2 = digitalRead(pin2);
  int state3 = digitalRead(pin3);
  int state4 = digitalRead(pin4);
  int state5 = digitalRead(pin5);

  if (state2 == HIGH) 
  {
    Serial.println(pin2);
  }
  else if (state3 == HIGH) 
  {
    Serial.println(pin3);
  }
  else if (state4 == HIGH) 
  {
    Serial.println(pin4);
  }
  else if (state5 == HIGH) 
  {
    Serial.println(pin5);
  }
  else
  {
    Serial.println(0);
  }

  delay(10);
}
