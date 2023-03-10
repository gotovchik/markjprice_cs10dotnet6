# Изучение языка С# и платформы .NET по книге Марка Джей Прайса "C# 10 и .NET 6 Современная кросс-платформенная разработка"

### 1. Управление потоком исполнения, преобразование типов и обработка исключений.
---
- [Унарные и бинарные арифметические операции.](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_03/Operators)
- [Логические операции](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_03/BooleanOperators)
- [Побитовые операции и сдвиги](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_03/BitwiseAndShiftOperators)
- [Операции ветвления](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_03/SelectionStatements)
- [Операции цикла](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_03/IterationStatements)
- [Преобразование типов](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_03/CastingConverting)
- [Обработка исключений](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_03/HandlingExceptions)
- [Проверка переполнения](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_03/CheckingForOverflow)
- [Упражнения](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_03/Exercises)

### 2. Разработка, отладка и тестирование функций.  
---
- [Написание функций](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_04/WritingFunctions)
- [Отладка](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_04/Debugging)
- [Модульное тестирование](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_04/CalculatorLibUnitTests/CalculatorLibUnitTests)
- [Генерация и перехват исключений в функциях](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_04/CallStackExceptionHandling/CallStackExceptionHandling)
- [Упражнения](https://github.com/gotovchik/markjprice_cs10dotnet6/tree/master/Chapter_04/Exercises)

### 3. Создание пользовательских типов с помощью объектно-ориентированного программирования
---
#### Работа с объектами
- Определение полей [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L6) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L8)
- Хранение значения с помощью типа enum [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/WondersOfTheAncientWorld.cs#L3) | [Поле](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L12) 
- Хранение нескольких значений с помощью коллекций [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L25) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L15)
- Статическое поле [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L37) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/BankAccount.cs)
- Константа [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L61) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L18)
- Поле только для чтения [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L63) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L19)
- Конструкторы [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L69) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L22)
#### Запись и вызов методов
- Методы [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L88) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L36)
- Возвращение нескольких значений с помощью кортежей [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L93) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L46)
- Деконструкция [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L112) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L56)
- Определение и передача параметров в методы [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L56) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L71)
- Перегрузка методов [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L131) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#LL77C24-L77C24)
- Передача необязательных и именованных параметров [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L134) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L83)
- Управление передачей параметров [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L142) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/Person.cs#L96)
#### Управлением доступом с помощью свойств и индексаторов
- Свойства [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L154) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/PersonAutoGen.cs#L7)
- Индексаторы [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L174) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibrary/PacktLibrary/PersonAutoGen.cs#L45)
#### Сопоставление с образцом с помощью объектов
- Сопоставление с образцом с помощью объектов  [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L183) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibraryModern/FlightPatterns.cs)
#### Работа с записями
- Свойства только для инициализации [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L229) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibraryModern/Records.cs#3)
- Записи [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L243) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibraryModern/Records.cs#10)
- Упрощение членов данных в записях [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PeopleApp/PeopleApp/Program.cs#L262) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/PacktLibraryModern/Records.cs#18)
#### Практические задания
- [Проверочные вопросы](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_05/Exercises/Q&A.md)

### 4. Реализация интерфейсов и наследование классов
---
#### Дополнительные сведения о методах
- Реализация функциональности с помощью методов [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_06/PeopleApp/Program.cs#4) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_06/PacktLibrary/Person.cs#16)
- Реализация функциональности с помощью операций [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_06/PeopleApp/Program.cs#23) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_06/PacktLibrary/Person.cs#35)
- Реализация функциональности с помощью локальных функций [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_06/PeopleApp/Program.cs#26) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_06/PacktLibrary/Person.cs#41)
#### Подъем и обработка событий
- Вызов методов с помощью делегатов [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_06/PeopleApp/Program.cs#29) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_06/PacktLibrary/Person.cs#60)
- Определение и обработка делегатов [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_06/PeopleApp/Program.cs#46) | [Объект](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_06/PacktLibrary/Person.cs#66)
- Определение и обработка событий
#### Обеспечение безопасности многократно используемых типов с помощью дженериков
- Работа с типами, не являющимися дженериками [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_06/PeopleApp/Program.cs#53)
- Работа с типами-дженериками [Реализация](https://github.com/gotovchik/markjprice_cs10dotnet6/blob/master/Chapter_06/PeopleApp/Program.cs#73)
#### Реализация интерфейсов
