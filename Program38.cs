// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76
// [-4, -6, 89, 6] -> 0

static void main(String[] args) 
{
        int[] array = {2, 5, 7, 8, 3, 0};
    }

    static int range(int[] array, int index, int min, int max) 
    {
        if (index == array.length) 
        {
            if (index == 0)
                return 0;
            else
                return max - min;
        } else {
            int value = array[index];
            return range(array, index + 1, Math.min(value, min), Math.max(value, max));
        }
    }

     static int range(int[] array) 
    {
        return range(array, 0, Integer.MAX_VALUE, Integer.MIN_VALUE);
    }
