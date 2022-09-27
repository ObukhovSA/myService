using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override async void OnStart(string[] args)
        {
            while (true)
            {
                File.AppendAllText(@"..\..\myService\DataCollection.txt", "Проверка работоспособности службы");
                await Task.Delay(10000); // Раз в 10 секунд вывод сообщения в текстовый файл
            }
        }

        protected override void OnStop()
        {
        }
    }
}
