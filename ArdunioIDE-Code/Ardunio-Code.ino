#include <LiquidCrystal.h>
#include <dht11.h>


int DHT11_pin = 2;
dht11 DHT11_sensor;
int lm35Pin = A0;

int sicaklikVolt;

void setup()
{

  analogReference(INTERNAL);

  Serial.begin(9600);
}

void loop()
{
  if (Serial.available())
  {
    char c = Serial.read();
    if (c == '1')
    {
      int chk = DHT11_sensor.read(DHT11_pin);
      
      Serial.println((float)DHT11_sensor.humidity, 2);
      delay(1000);
    }
    else if (c == '0')
    {
      sicaklikVolt = analogRead(lm35Pin);
      float sicaklikC = sicaklikC = sicaklikVolt / 9.31;
      
      Serial.println(sicaklikC);
      delay(1000);
    }
  }
}
