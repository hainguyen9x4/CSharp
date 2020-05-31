using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class ClassBReceiveEvent
    {
        ClassAFireEvent m_classA;
        public ClassBReceiveEvent(){
            m_classA = new ClassAFireEvent();
            m_classA.DataReceived -= MessageDataReceived;
            m_classA.DataReceived += MessageDataReceived;
            m_classA.ErrorReceived -= MessageErrorReceived;
            m_classA.ErrorReceived += MessageErrorReceived;
            m_classA.StartTimerFireDataEvent(1000);
            m_classA.StartTimerFireErrorEvent(2000);

        }
        private void MessageDataReceived(object sender, DataEventArgs e)
        {
            DataEventArgs e_data = new DataEventArgs();
            e_data.ReceivedData = e.ReceivedData;
            Console.WriteLine(e_data.ReceivedData);
        }
        private void MessageErrorReceived(object sender, ErrorEventArgs e)
        {
            ErrorEventArgs e_data = new ErrorEventArgs();
            e_data.ErrorCode = e.ErrorCode;
            e_data.ErrorMessage = e.ErrorMessage;
            Console.WriteLine("Error code:"+e_data.ErrorCode+"Error mes: "+ e.ErrorMessage);
        }
    }
}
