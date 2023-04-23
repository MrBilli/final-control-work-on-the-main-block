# **Задача:**
> ### *Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*
<br/>

# **Решение:**

### **1. Создаём метод *CreateArrayOfStrings*.**
> * Метод ничего не принимает на вход и возвращает массив, заполненный количеством элементов типа string, указанным внутри метода.
> * Пользователь вводит количество элементов, а потом поочерёдно вводит каждый элемент. 
<br/>

### **2. Создаём метод *NumberOfElementsThreeCharactersLong*.**
> * Метод принимает на вход массив и возвращает количество элементов в массиве, длина которых менее или равна 3-ем символам. 
<br/>

### **3. Создаём метод *ArrayOfElementsThreeCharactersLong*.**
> * Метод принимает на вход массив и количество элементов нового массива, возвращает новый массив.
> * Внутри поочерёдно проверяется каждый элемент принятого массива, и те, которые имеют длину до 3-х символов включительно, становятся элементами нового массива.