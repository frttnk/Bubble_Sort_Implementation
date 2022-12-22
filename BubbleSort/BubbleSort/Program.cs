

int[] array = { 2, 6, 7, 9, 5, 0, 1, 4, 3 };

SortBubble(array);

void SortBubble(int[] array)
{
    bool swapProcess = true;

    while(swapProcess)
    {
        swapProcess = false;

        for(int i=0;i<array.Length-1;i++) // asc sort
        {
            if (array[i] < array[i+1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;

                swapProcess = true;
            }
        }
    }

    foreach (var item in array)
    {
        Console.Write(item);
    }
}
