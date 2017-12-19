#include "MLX90615.h"
#include <I2cMaster.h>
#include <LiquidCrystal.h>
#include <Servo.h>

Servo motor;
const int rs = 12, en = 11, d4 = 5, d5 = 4, d6 = 3, d7 = 2;
LiquidCrystal lcd(rs, en, d4, d5, d6, d7);

#define sdapini A4      // SICAKLIK SENSÖR PİNİ
#define sclpini A5      // SICAKLIK SENSÖR PİNİ

SoftI2cMaster i2c(sdapini, sclpini);
MLX90615 sensor(DEVICE_ADDR, &i2c);

int derece;
int nem;
int aydinlik;
int tr = 6;      // MESAFE SENSÖRÜ TRIGGER BAĞLANTI PİNİ
int ec = 7;      // MESAFE SENSÖRÜ ECHO BAĞLANTI PİNİ
long sure;       // MESAFE ÖLÇÜMÜNDE KULLANILAN SÜRE DEĞİŞKENİ
long mesafe;     // MESAFE ÖLÇÜMÜNDE KULLANILAN MESAFE DEĞİŞKENİ
int pos = 0;
bool tarama = false;
int lcdgosterme = 3000;  // PCDEN GELEN MESAJIN GÖSTERİM SÜRESİ (3SN)
int motorhiz = 100;        // MOTOR TARAMA HIZI (TERS ORANTILIDIR)

void setup() {

  Serial.begin(9600);
  lcd.begin(16, 2);
  lcd.print("RADAR SISTEMI");
  delay(10000);
  pinMode(tr, OUTPUT);     // MESAFE SENSÖRÜ TRIGGER PİNİ ÇIKIŞ OLARAK AYARLANDI
  pinMode(ec, INPUT);      // MESAFE SENSÖRÜ ECHO PİNİ GİRİŞ OLARAK AYARLANDI
  motor.attach(9);
  delay(1500);
  lcd.clear();
  Serial.println("limitler");
}

void loop() {

  oku();


  derece = sensor.getTemperature(MLX90615_OBJECT_TEMPERATURE);
  aydinlik = map(analogRead(A0), 0, 1023, 0, 100);

  lcd.setCursor(0, 0);
  lcd.print("SICAKLIK:");
  lcd.print(derece);
  Serial.print("derece:");
  Serial.println(derece);
  delay(50);
  Serial.print("aydinlik:");
  Serial.println(aydinlik);
  delay(50);

  if (tarama == true) {
    for (int y = pos ; y <= 180; y += 1) {
      motor.write(y);
      mesafekontrol(y);
      delay(motorhiz);
      oku();
      pos = y;
      if (tarama == false) {
        return ;
      }
    }
    for (int y = pos; y >= 0; y -= 1) {
      motor.write(y);
      mesafekontrol(y);
      delay(motorhiz);
      oku();
      pos = y;
      if (tarama == false) {
        return ;
      }
    }
  }
  delay(500);
}

void mesafekontrol(int z) {

  int mod = z % 10;
  if (mod == 0) {
    digitalWrite(tr, LOW);
    delayMicroseconds(5);
    digitalWrite(tr, HIGH);
    delayMicroseconds(10);
    digitalWrite(tr, LOW);

    sure = pulseIn(ec, HIGH);
    mesafe = (sure / 29.1) / 2;
    if (mesafe > 200) {
      mesafe = 200;
    }
    Serial.print("mesafe:");
    Serial.println(mesafe);
  }
}

void oku() {
  if (Serial.available()) {
    String mesaj = Serial.readString();

    if (mesaj.substring(0, 3) == "TRA") {
      tarama = true;
      mesaj = "";
    }
    if (mesaj.substring(0, 3) == "TRK") {
      tarama = false;
      mesaj = "";
    }
    if (mesaj.substring(0, 3) == "SCK") {
      lcd.setCursor(0, 1);
      lcd.print("                ");
      lcd.setCursor(0, 1);
      lcd.print("SICAKLIK UYARISI");
      mesaj = "";
    }
    if (mesaj.substring(0, 3) == "MES") {
      lcd.setCursor(0, 1);
      lcd.print("                ");
      lcd.setCursor(0, 1);
      lcd.print(" MESAFE UYARISI");
      mesaj = "";
    }
    if (mesaj.substring(0, 3) == "BIR") {
      mesaj = mesaj.substring(3, mesaj.length());
      lcd.setCursor(0, 0);
      lcd.print("                ");
      lcd.setCursor(0, 0);
      lcd.print(mesaj);
      mesaj = "";
      delay(lcdgosterme);
      lcd.setCursor(0, 0);
      lcd.print("                ");
    }
    if (mesaj.substring(0, 3) == "IKI") {
      mesaj = mesaj.substring(3, mesaj.length());
      lcd.setCursor(0, 1);
      lcd.print("                ");
      lcd.setCursor(0, 1);
      lcd.print(mesaj);
      mesaj = "";
      delay(lcdgosterme);
      lcd.setCursor(0, 1);
      lcd.print("                ");
    }
  }
}

