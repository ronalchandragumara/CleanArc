using Domain.Constants.Commons;
using System.Globalization;

namespace Domain.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime DatetimeofToday()
        {
            return DateTime.UtcNow;
        }

        public static string DayNameofDateTime(DateTime dDate)
        {
            return dDate.ToString("ddd").ToUpper();
        }

        public static string TimeOnlytoString(DateTime dDate)
        {
            return string.Format("{0:HH:mm}", dDate);
        }

        public static string DateOnlytoString(DateTime dDate)
        {
            return string.Format("{0:dd/MM/yyyy}", dDate);
        }

        public static string DateTimetoString(DateTime dDate)
        {
            return string.Format("{0:dd/mm/yyyy HH:MM:ss}", dDate);
        }

        public static DateTime StringToDateTime(string stringDate)
        {
            DateTime dDate = DateTime.ParseExact(stringDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            return dDate;
        }

        public static DateTime AddYearsToDateTime(DateTime dDate, int dYears)
        {
            return dDate.AddYears(dYears);
        }

        public static DateTime AddMonthsToDateTime(DateTime dDate, int dMonths)
        {
            return dDate.AddMonths(dMonths);
        }

        public static DateTime AddDaysToDateTime(DateTime dDate, int dDays)
        {
            return dDate.AddDays(dDays);
        }

        public static DateTime AddHoursToDateTime(DateTime dDate, double dHours)
        {
            return dDate.AddHours(dHours);
        }

        public static DateTime AddMinutesToDateTime(DateTime dDate, double dMinutes)
        {
            return dDate.AddMinutes(dMinutes);
        }

        public static DateTime AddSecondsToDateTime(DateTime dDate, double dSeconds)
        {
            return dDate.AddSeconds(dSeconds);
        }

        public static DateTime GetFirstDate(DateTime dDate)
        {
            DateTime FirstDate = new(dDate.Year, dDate.Month, 1);
            return FirstDate;
        }

        public static DateTime GetLastDate(DateTime dDate)
        {
            DateTime LastDate = new(dDate.Year, dDate.Month, DateTime.DaysInMonth(dDate.Year, dDate.Month));
            return LastDate;
        }

        public static DateTime GetFirstYear(DateTime dDate)
        {
            int year = dDate.Year;
            DateTime firstDay = new(year, 1, 1);

            return firstDay;
        }

        public static DateTime GetLastYear(DateTime dDate)
        {
            int year = dDate.Year;
            DateTime lastDay = new(year, 12, 31);

            return lastDay;
        }

        public static DateTime ReplaceOldDateTime(DateTime oldDateTime, int dYear = 0, int dMonth = 0, int dDay = 0, int dHour = 0, int dMinute = 0, int dSecond = 0)
        {
            DateTime newDateTime = oldDateTime;

            if (dYear > 0)
                newDateTime = new DateTime(dYear, newDateTime.Month, newDateTime.Day, newDateTime.Hour, newDateTime.Minute, newDateTime.Second);

            if (dMonth > 0)
                newDateTime = new DateTime(newDateTime.Year, dMonth, newDateTime.Day, newDateTime.Hour, newDateTime.Minute, newDateTime.Second);
            
            if (dDay > 0)
                newDateTime = new DateTime(newDateTime.Year, newDateTime.Month, dDay, newDateTime.Hour, newDateTime.Minute, newDateTime.Second);

            if (dHour > 0)
                newDateTime = new DateTime(newDateTime.Year, newDateTime.Month, newDateTime.Day, dHour, newDateTime.Minute, newDateTime.Second);

            if (dMinute > 0)
                newDateTime = new DateTime(newDateTime.Year, newDateTime.Month, newDateTime.Day, newDateTime.Hour, dMinute, newDateTime.Second);

            if (dSecond > 0)
                newDateTime = new DateTime(newDateTime.Year, newDateTime.Month, newDateTime.Day, newDateTime.Hour, newDateTime.Minute, dSecond);

            return newDateTime;
        }

        public static bool IsWeekendofDate(DateTime dDate)
        {
            string sDayName = DayNameofDateTime(dDate);

            if (sDayName == DayConstant.SATURDAY || sDayName == DayConstant.SUNDAY)
            {
                return true;
            }

            return false;
        }

        public static double GetNumberOfDaysBetweenTwoDates(DateTime startDate, DateTime endDate)
        {
            double NumofDays = (endDate.Date - startDate.Date).TotalDays;

            return Math.Abs(NumofDays);
        }

        public static double GetNumberOfMonthsBetweenTwoDates(DateTime startDate, DateTime endDate)
        {
            int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;

            return Math.Abs(monthsApart);
        }

        public static IEnumerable<DateTime> EachDateWithRangeDateAndInterval(DateTime fromDate, DateTime toDate, int interval = 1)
        {
            for (var date = fromDate.Date; date.Date <= toDate.Date; date = date.AddDays(interval)) yield
            return date;

        }

    }
}
