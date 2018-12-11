using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace WeekCalculator
{
    public partial class MainForm : Form
    {
        #region Constructors

        public MainForm(List<CommandParameterInfo> commandParameterInfos)
        {
            InitializeComponent();
            InitializeDateTimes(commandParameterInfos);
        }

        #endregion

        #region Methods

        void InitializeDateTimes(List<CommandParameterInfo> commandParameterInfos)
        {
            if (commandParameterInfos == null) throw new ArgumentNullException(nameof(commandParameterInfos));

            foreach (var commandParameterInfo in commandParameterInfos)
            {
                switch (commandParameterInfo.CommandParameterType)
                {
                    case CommandParameterType.StartDate:
                        dtpStart.Value = Convert.ToDateTime(commandParameterInfo.CommandParameterObject);
                        break;
                    case CommandParameterType.EndDate:
                        dtpEnd.Value = Convert.ToDateTime(commandParameterInfo.CommandParameterObject);
                        break;
                    case CommandParameterType.HoursPerWeek:
                        nudHours.Value = Convert.ToInt32(commandParameterInfo.CommandParameterObject);
                        break;
                    case CommandParameterType.None:
                        break;
                }
            }

            UpdateControls();
        }

        void UpdateControls()
        {
            var start = SetToMonday(dtpStart.Value);
            var end = SetToMonday(dtpEnd.Value);

            if (start > end)
            {
                var tmp = end;
                end = start;
                start = tmp;
            }

            var timeSpan = (end - start);

            var weeks = Math.Ceiling(timeSpan.TotalDays / 7);
            var hours = Convert.ToDouble(nudHours.Value);

            lblWeeksCount.Text = weeks.ToString(CultureInfo.InvariantCulture);

            lblGeneralWeekToHourCount.Text = (weeks * hours).ToString();
        }

        DateTime SetToMonday(DateTime dateTime)
        {
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return dateTime.AddDays(-6);
                case DayOfWeek.Monday:
                    return dateTime;
                case DayOfWeek.Tuesday:
                    return dateTime.AddDays(-1);
                case DayOfWeek.Wednesday:
                    return dateTime.AddDays(-2);
                case DayOfWeek.Thursday:
                    return dateTime.AddDays(-3);
                case DayOfWeek.Friday:
                    return dateTime.AddDays(-4);
                case DayOfWeek.Saturday:
                    return dateTime.AddDays(-5);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        #region EventHandlers

        void BtnClose_Click(object sender, EventArgs e) => Close();

        void DtpStart_Changed(object sender, EventArgs e) => UpdateControls();

        void DtpEnd_Changed(object sender, EventArgs e) => UpdateControls();

        void NudHours_Changed(object sender, EventArgs e) => UpdateControls();

        #endregion
    }
}
