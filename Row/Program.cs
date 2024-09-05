/* На экране, в специальной зоне, выводятся картинки, по 3 в ряд (условно, ничего рисовать не надо). 
   Всего у пользователя в альбоме 52 картинки. Код должен вывести, сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет сверх меры. 
   В качестве решения ожидаются объявленные переменные с необходимыми значениями и, основываясь на значениях переменных, вывод необходимых данных. 
   По задаче требуется выполнить простые математические действия.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
           int row = 3;

           int picture = 52;
           
           int filledRow = picture / row;

            Console.WriteLine("Полностью заполенных рядов выведется:" + filledRow);

            int picturesBeyondMeasure = picture % row;

            Console.WriteLine("Картинок сверх меры:" + picturesBeyondMeasure);
        }
    }
}
