// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19



        
            int sum = 0;
            Console.WriteLine("Количество элементов массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[a];

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"Введите  элемент {i}:");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < A.Length; i=i+2)
            
                {
                    sum = sum + A[i];
                }
            
            Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum} \t");
      

        