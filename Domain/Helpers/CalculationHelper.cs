using Domain.Exceptions;

namespace Domain.Helpers
{
    public static class CalculationHelper
    {
        private static readonly DateTime DateTimeToday = DateTimeHelper.DatetimeofToday();
        private static readonly DateTime FirstDay = new(1, 1, 1);

        public static TimeSpan DifferenceDateTime(DateTime DateOfBirth)
        {
            TimeSpan difference = DateTimeToday.Subtract(DateOfBirth);

            return difference;
        }

        /// <summary>
        /// Calculate Total Years From DateOfBirth
        /// </summary>
        /// <param name="DateOfBirth">DateOfBirth</param>
        /// <returns>Number of Years</returns>
        public static int AgeInYears(DateTime DateOfBirth)
        {
            if (DateTimeToday.Date < DateOfBirth.Date)
                return 0;

            var difference = DifferenceDateTime(DateOfBirth);

            int totalYears = (FirstDay + difference).Year - 1;

            return totalYears;

        }

        /// <summary>
        /// Calculate Total Months From DateOfBirth
        /// </summary>
        /// <param name="DateOfBirth">DateOfBirth</param>
        /// <returns>Number of Months</returns>
        public static int AgeInMonths(DateTime DateOfBirth)
        {
            if (DateTimeToday.Date < DateOfBirth.Date)
                return 0;

            var difference = DifferenceDateTime(DateOfBirth);
            int totalYears = AgeInYears(DateOfBirth);

            int totalMonths = (totalYears * 12) + (FirstDay + difference).Month - 1;

            return totalMonths;
        }

        /// <summary>
        /// Calculate Running Months From DateOfBirth
        /// </summary>
        /// <param name="DateOfBirth">DateOfBirth</param>
        /// <returns>Number of Running Months</returns>
        public static int RunningInMonths(DateTime DateOfBirth)
        {
            if (DateTimeToday.Date < DateOfBirth.Date)
                return 0;

            var difference = DifferenceDateTime(DateOfBirth);
            int totalYears = AgeInYears(DateOfBirth);
            int totalMonths = (totalYears * 12) + (FirstDay + difference).Month - 1;

            int runningMonths = totalMonths - (totalYears * 12);

            return runningMonths;
        }


        /// <summary>
        /// Calculate Running Days From DateOfBirth
        /// </summary>
        /// <param name="DateOfBirth">DateOfBirth</param>
        /// <returns>Number of Running Days</returns>
        public static int RunningInDays(DateTime DateOfBirth)
        {
            if (DateTimeToday.Date < DateOfBirth.Date)
                return 0;

            int totalYears = AgeInYears(DateOfBirth);
            int runningMonths = RunningInMonths(DateOfBirth);
            throw new BadRequestException("Bad ");
            int runningDays = (DateTimeToday - DateOfBirth.AddMonths((totalYears * 12) + runningMonths)).Days;

            return runningDays;
        }
    }
}
