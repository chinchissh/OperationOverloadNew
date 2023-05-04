using System;
using System.Collections.Generic;
using System.Text;

namespace OperationOverloadNew
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public override string ToString()
        {
            return $"{hour:D2}:{minute:D2}:{second:D2}";
        }

        public static Time operator +(Time t1, Time t2)
        {
            int totalSeconds = t1.second + t2.second + (t1.minute + t2.minute) * 60 + (t1.hour + t2.hour) * 3600;
            int newHour = totalSeconds / 3600;
            int newMinute = (totalSeconds % 3600) / 60;
            int newSecond = totalSeconds % 60;
            return new Time(newHour, newMinute, newSecond);
        }

        public static Time operator -(Time t1, Time t2)
        {
            int totalSeconds = t1.second - t2.second + (t1.minute - t2.minute) * 60 + (t1.hour - t2.hour) * 3600;
            int newHour = totalSeconds / 3600;
            int newMinute = (totalSeconds % 3600) / 60;
            int newSecond = totalSeconds % 60;
            return new Time(newHour, newMinute, newSecond);
        }

        public static bool operator ==(Time t1, Time t2)
        {
            return t1.hour == t2.hour && t1.minute == t2.minute && t1.second == t2.second;
        }

        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }

        public static bool operator <(Time t1, Time t2)
        {
            return t1.hour < t2.hour || (t1.hour == t2.hour && (t1.minute < t2.minute || (t1.minute == t2.minute && t1.second < t2.second)));
        }

        public static bool operator >(Time t1, Time t2)
        {
            return t1.hour > t2.hour || (t1.hour == t2.hour && (t1.minute > t2.minute || (t1.minute == t2.minute && t1.second > t2.second)));
        }

        public static bool operator <=(Time t1, Time t2)
        {
            return t1 < t2 || t1 == t2;
        }

        public static bool operator >=(Time t1, Time t2)
        {
            return t1 > t2 || t1 == t2;
        }

        public static Time operator ++(Time t)
        {
            t.second++;
            if (t.second == 60)
            {
                t.second = 0;
                t.minute++;
                if (t.minute == 60)
                {
                    t.minute = 0;
                    t.hour = (t.hour + 1) % 24;
                }
            }
            return t;
        }

        public static Time operator --(Time t)
        {
            t.second--;
            if (t.second < 0)
            {
                t.second = 59;
                t.minute--;
                if (t.minute < 0)
                {
                    t.minute = 59;
                    t.hour = (t.hour - 1 + 24) % 24;
                }
            }
            return t;
        }
    }
}
