#include <Servo.h>

Servo servoBase;
const int servoBasePIN = 3;

Servo servobrazo1;
const int servobrazo1PIN = 4;

Servo servobrazo2;
const int servobrazo2PIN = 5;

Servo servoGarra;
const int servoGarraPIN = 6;

char caracter;
String datos;
uint8_t servoBaseAngulo, servobrazo1Angulo, servobrazo2Angulo = 180, servoGarraAngulo;
int8_t indiceA, indiceB, indiceC, indiceD;

void setup() {
  Serial.begin(9600);
  servoBase.attach(servoBasePIN);
  servobrazo1.attach(servobrazo1PIN);
  servobrazo2.attach(servobrazo2PIN);
  servoGarra.attach(servoGarraPIN);
}

void loop() {
  obtener_datos_serial();

  if (caracter == '\n') {
    obtener_Angulos();
    caracter = 0;
    datos = "";
  }

  servoBase.write(servoBaseAngulo);
  servobrazo1.write(servobrazo1Angulo);
  servobrazo2.write(servobrazo2Angulo);
  servoGarra.write(servoGarraAngulo);
}

void obtener_datos_serial() {
  while (Serial.available() > 0) {
    caracter = Serial.read();
    if (caracter == '\n') break;
    else datos += caracter;
  }
}

void obtener_Angulos() {
  String str_servoBase, str_servobrazo1, str_servobrazo2, str_servoGarra;

  indiceA = datos.indexOf("A");
  indiceB = datos.indexOf("B");
  indiceC = datos.indexOf("C");
  indiceD = datos.indexOf("D");

  if (indiceA > -1) {
    str_servoBase = datos.substring(0, indiceA);
    servoBaseAngulo = str_servoBase.toInt();
  }
  if (indiceB > -1) {
    str_servobrazo1 = datos.substring(0, indiceB);
    servobrazo1Angulo = str_servobrazo1.toInt();
  }
  if (indiceC > -1) {
    str_servobrazo2 = datos.substring(0, indiceC);
    servobrazo2Angulo = str_servobrazo2.toInt();
  }
  if (indiceD > -1) {
    str_servoGarra = datos.substring(0, indiceD);
    servoGarraAngulo = str_servoGarra.toInt();
  }
}
