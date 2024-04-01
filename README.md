# Итоговая контрольная работа по основному блоку.
## Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Примеры:
+ [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
+ [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
+ [“Russia”, “Denmark”, “Kazan”] → []

## Алгоритм решения задачи:


1. **Инициализация переменных и ввод данных**:
- В этом блоке инициализируются переменные `n`, `input` и `inputArray`.
- Пользователь по запросу вводит строку, содержащую элементы массива, разделенные запятой.
- Метод `Split` разбивает строку на подстроки на основе разделителя (в данном случае запятая). Параметр `StringSplitOptions.RemoveEmptyEntries` удаляет пустые подстроки, возникающие, например, если запятые идут подряд, что позволяет избежать создания пустых элементов в массиве.

2. **Формирование массива с подходящими строками**:
- Цикл проходится по элементам массива `inputArray` и подсчитывает количество элементов, длина которых меньше или равна 3.
- Создается новый массив `resultArray`, в который копируются только те элементы из `inputArray`, длина которых удовлетворяет условию.

3. **Вывод результата**:
- Создается строка ввода результата в которую с помощью метода `String.Join` объединяются элементы массива `inputArray`  и вытекающий из него в соответствии с условием `resultArray`, разделенные запятыми.
- Эта строка выводится на экран, заключенная в квадратные скобки, для отображения результата в желаемом формате.

#### Таким образом, этот код принимает строку с элементами массива, создает новый массив из элементов исходного массива, удовлетворяющих определенному условию, а затем выводит результат в желаемом формате.

## Схематическое решения задачи:

Блок-схема алгоритма решения задачи ![блок-схема](./block_diagram/shema.png)