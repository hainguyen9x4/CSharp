using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpProject
{

    class ClassAFireEvent
    {


        System.Threading.Timer TimerFireEventData;
        System.Threading.Timer TimerFireEventError;
        int m_iCountDataEvent = 0;
        int m_iCountErrorEvent = 0;
        public ClassAFireEvent()
        {

            TimerCallback FireDataEventTimerDelegate = new TimerCallback(FireDataEvent);
            TimerFireEventData = new System.Threading.Timer(FireDataEventTimerDelegate, null, Timeout.Infinite, Timeout.Infinite);
            TimerCallback FireErrorEventTimerDelegate = new TimerCallback(FireErrorEvent);
            TimerFireEventError = new System.Threading.Timer(FireErrorEventTimerDelegate, null, Timeout.Infinite, Timeout.Infinite);
        }
        public event EventHandler<DataEventArgs> DataReceived;
        public void OnDataReceived(DataEventArgs e)
        {
            EventHandler<DataEventArgs> event_handler = DataReceived;
            if (event_handler != null)
            {
                event_handler(this, e);
            }
        }
        public event EventHandler<ErrorEventArgs> ErrorReceived;
        public void OnErrorReceived(ErrorEventArgs e)
        {
            EventHandler<ErrorEventArgs> event_handler = ErrorReceived;
            if (event_handler != null)
            {
                event_handler(this, e);
            }
        }
        private void FireDataEvent(object state)
        {
            m_iCountDataEvent++;
            DataEventArgs dataEvent = new DataEventArgs();
            dataEvent.ReceivedData = m_iCountDataEvent + ",Data Event";
            OnDataReceived(dataEvent);
        }
        private void FireErrorEvent(object state)
        {
            m_iCountErrorEvent++;
            ErrorEventArgs dataEvent = new ErrorEventArgs();
            dataEvent.ErrorCode = m_iCountErrorEvent;
            dataEvent.ErrorMessage = "Error loi";
            OnErrorReceived(dataEvent);
        }
        public bool StartTimerFireDataEvent(int timer_interval)
        {
            bool bRet;
            int timer_interval2 = timer_interval;
            if (timer_interval == 0)
            {
                bRet = TimerFireEventData.Change(Timeout.Infinite, Timeout.Infinite);//stop timer
            }
            else
            {
                //start timer: timer_interval first interval, timer_interval2: after first interval, the interval is timer_interval2
                bRet = TimerFireEventData.Change(timer_interval, timer_interval2);
            }
            return bRet;
        }
        public bool StartTimerFireErrorEvent(int timer_interval)
        {
            bool bRet;
            if (timer_interval == 0)
            {
                bRet = TimerFireEventError.Change(Timeout.Infinite, Timeout.Infinite);
            }
            else
            {
                bRet = TimerFireEventError.Change(timer_interval, timer_interval);
            }
            return bRet;
        }
    }
    public class DataEventArgs : EventArgs
    {
        public string ReceivedData;
    }
    public class ErrorEventArgs : EventArgs
    {
        public int ErrorCode;
        public string ErrorMessage;
    }
}
