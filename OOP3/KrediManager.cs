using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //arayüz - şablon
    //interface leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
