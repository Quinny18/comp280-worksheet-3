int count = 0;

void setup() 
{
 // put your setup code here, to run once:
 Serial.begin(9600);
}

void loop() 
{
  int sensorValue = analogRead(A0); //read the input on analog pin 0

  Serial.println(sensorValue); //print out the value you read
  delay(1);
}
