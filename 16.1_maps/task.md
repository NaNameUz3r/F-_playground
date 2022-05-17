Реализуйте стандартную функцию Map.tryFind самостоятельно в виде функции try_find. 

Для справки:
```
Функция Map.find находит в отображении значение по ключу.

Map.find 128 map1 // "oksana"

Если ключа в отображение нету, возникнет исключение KeyNotFoundException.

Безопасная версия Map.tryFind ищет в отображении значение по ключу, возвращая значение типа option.

Map.tryFind 128 map1 // Some("oksana")
Map.tryFind 64 map1 // None
```