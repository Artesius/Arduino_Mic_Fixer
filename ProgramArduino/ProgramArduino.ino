const int micPin = A0; // задаём пин, куда подключён микрофон

void setup() {
    Serial.begin(9600); // инициализация послед. порта
}

void loop() {  
 
    int mv = analogRead(micPin) * 5.0 / 1024.0 * 1000.0; // значения в милливольтах
    int dB = 1000 * log10(mv);

    if(dB > 3000)
    {
        Serial.println("fatal error");
    }  
    else
    {
        Serial.println(dB);
    }
    delay(1);
}
