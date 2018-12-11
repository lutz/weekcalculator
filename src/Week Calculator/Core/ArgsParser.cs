using System;
using System.Collections.Generic;

namespace WeekCalculator
{
    internal static class ArgsParser
    {
        #region Methods

        internal static List<CommandParameterInfo> Parse(string[] args)
        {
            var commandTypes = new List<CommandParameterType>();
            var commandObjects = new List<string>();

            foreach (var arg in args)
            {
                var commandParameterType = ParseType(arg);

                if (commandParameterType == CommandParameterType.None)
                {
                    commandObjects.Add(arg);
                }
                else
                {
                    commandTypes.Add(commandParameterType);
                }
            }

            return CreateCommandParameterInfos(commandTypes, commandObjects);

        }

        static CommandParameterType ParseType(string type)
        {
            switch (type)
            {
                case (CommandParameterTypeId.StartDate): return CommandParameterType.StartDate;
                case (CommandParameterTypeId.EndDate): return CommandParameterType.EndDate;
                case (CommandParameterTypeId.HoursPerWeek): return CommandParameterType.HoursPerWeek;
                default: return CommandParameterType.None;
            }
        }

        static List<CommandParameterInfo> CreateCommandParameterInfos(IReadOnlyList<CommandParameterType> commandParameterTypes, IReadOnlyList<string> commandParameterObjects)
        {
            var commandParameterInfos = new List<CommandParameterInfo>();

            for (var i = 0; i < commandParameterTypes.Count; i++)
            {
                if (i >= commandParameterObjects.Count) continue;

                var type = commandParameterTypes[i];
                var obj = commandParameterObjects[i];
                commandParameterInfos.Add(new CommandParameterInfo(type, ConvertToType(type, obj)));
            }

            return commandParameterInfos;
        }

        static object ConvertToType(CommandParameterType type, string obj)
        {
            switch (type)
            {
                case CommandParameterType.StartDate:
                    return DateTime.TryParse(obj, out DateTime startDate) ? startDate : DateTime.Now;
                case CommandParameterType.EndDate:
                    return DateTime.TryParse(obj, out DateTime endDate) ? endDate : DateTime.Now;
                case CommandParameterType.HoursPerWeek:
                    return int.TryParse(obj, out int hours) ? hours : 1;
                default:
                    return null;
            }
        }

        #endregion
    }
}