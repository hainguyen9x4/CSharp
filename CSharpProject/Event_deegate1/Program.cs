using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_deegate1
{
    class Program
    {

        static void Main(string[] args)
        {
            PointOnline m_Point1 = new PointOnline();
            m_Point1.PointChanged += NotifyPointChanged1;
            m_Point1.PointChanged += NotifyPointChanged2;
            m_Point1.PointX = 12;
            m_Point1.PointChanged -= NotifyPointChanged1;
            m_Point1.PointX = 13;
            Console.ReadKey();
        }

        private static void NotifyPointChanged1(int oldPoint, int newPoint)
        {
            Console.WriteLine("The point has been changed to: " + newPoint);
        }
        private static void NotifyPointChanged2(int oldPoint, int newPoint)
        {
            Console.WriteLine("The point has been changed from " + oldPoint + " to " + newPoint);
        }

    }
    internal delegate void PointChangeHandler(int oldPoint, int newPoint);
    internal class PointOnline
    {
        private int m_iPointx = 11;
        public event PointChangeHandler PointChanged;
        public int PointX
        {
            get
            {
                return m_iPointx;
            }
            set
            {
                var oldPoint = m_iPointx;
                m_iPointx = value;
                PointChanged.Invoke(oldPoint, m_iPointx);
            }
        }
    }
}
