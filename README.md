# Итоговая проверочная работа
Данная работа необходимa для проверки наших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик.

Для полноценного выполнения проверочной работы необходимо:
1. Создан репозиторий на GitHub
2. Нарисована блок-схема алгоритма
3. Оформлен файл Readme.md (разными элементами выделения)
4. Написана программа, решающая поставленную задачу
5. Использован контроль версий в работе над этим небольшим проектом (не должно быть так сто вс залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расоложены в разных коммитах)


## Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Примеры
["hello", "2", "world", ":-)"] --> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] --> ["-2" ]

["Russia", "Denmark", "Kazan"] --> []

## Описание решения задачи

1. Объявляем два массива
2. Создаем метод PrntArray() для вывода первого массива.
3. Создаем метод FindArr() для поиска строковых элементов массива, длина которых меньше, либо равна 3 символам.
4. Вызываем метод PrintArray(), для вывода второго массива