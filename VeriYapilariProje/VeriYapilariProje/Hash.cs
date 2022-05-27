using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
  public   class Hash
    {
        public HashEntry[] hashTable;
        
        public Hash(int size)
        {
            this.hashTable = new HashEntry[size];

        }
        public void Hashle(int key, Kelime kelime)
        {


            HashEntry eklenecek = new HashEntry();
            eklenecek.Data = kelime;
          

            int hash = (key % 10);
            if (hashTable[hash] == null)
            {

                eklenecek.Next = null;
                hashTable[hash] = eklenecek;
            }
            else
            {

                HashEntry temp = hashTable[hash];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = eklenecek;
                eklenecek.Next = null;
            }



        }
        public Kelime KelimeArama(int key)
        {
            int hash = (key % 10);
            if (hashTable[hash] == null)
            {
                return null;
            }
            else
            {
                if (key == hashTable[hash].Key)
                {
                    return hashTable[hash].Data;
                }
                else
                {
                    while (key != hashTable[hash].Key)
                    {
                        if (hashTable[hash].Next != null)
                            hashTable[hash] = hashTable[hash].Next;
                        else
                            return null;
                    }
                    return hashTable[hash].Data;
                }
            }
        }

      



      

    }
}
