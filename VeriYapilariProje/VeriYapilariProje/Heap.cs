using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
  public   class Heap
    {

        public HeapDugumu[] heapArray { get; set; }
        public int currentSize { get; set; }
        public int maxSize { get; set; }

        public Heap(int maxSize)
        {
            this.maxSize = maxSize;
            heapArray = new HeapDugumu[maxSize];
            currentSize = 0;
        }
    
        public bool IsEmpty()
        {
            if (currentSize == 0)
                return true;
            else
                return false;

        }
        public bool Insert(string value)
        {
            if (currentSize == maxSize)
                return false;

            for (int i = 0; i < currentSize; i++)
            {
                if (heapArray[i].value.Word == value)
                {
                    heapArray[i].value.Frequency++;
                    MoveToUp(i);
                    return true;
                }
            }
            Kelime k = new Kelime(value, 1);
            HeapDugumu newHeapDugumu = new HeapDugumu(k);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];
            while (index > 0 && heapArray[parent].value.Frequency < bottom.value.Frequency)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugumu RemoveMax()
        {
           HeapDugumu root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugumu top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < currentSize && heapArray[leftChild].value.Frequency <
                heapArray[rightChild].value.Frequency)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.value.Frequency >= heapArray[largerChild].value.Frequency)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }

        public string Disp()
        {
            string sonuc = "";

            for (int i = 0; i < currentSize; i++)
            {
                sonuc += heapArray[i].value.Word + "--"+ heapArray[i].value.Frequency + "\n";
            }

            return sonuc;

        }




        public Kelime[] Sort()
        {
            Kelime[] sorted = new Kelime[currentSize];
            int i = 0;
            while (!IsEmpty())
                sorted[i++] = RemoveMax().value;
            return sorted;
        }
    }
}
