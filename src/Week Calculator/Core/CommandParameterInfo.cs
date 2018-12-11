namespace WeekCalculator
{
    public class CommandParameterInfo
    {
        #region Constructors

        public CommandParameterInfo(CommandParameterType commandParameterType, object commandParameterObject)
        {
            CommandParameterType = commandParameterType;
            CommandParameterObject = commandParameterObject;
        }

        #endregion

        #region Properties

        public CommandParameterType CommandParameterType { get; }

        public object CommandParameterObject { get; }

        #endregion
    }
}
