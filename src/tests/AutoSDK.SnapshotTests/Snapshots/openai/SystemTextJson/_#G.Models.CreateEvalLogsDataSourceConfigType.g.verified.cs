//HintName: G.Models.CreateEvalLogsDataSourceConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of data source. Always `logs`.<br/>
    /// Default Value: logs
    /// </summary>
    public enum CreateEvalLogsDataSourceConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalLogsDataSourceConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalLogsDataSourceConfigType value)
        {
            return value switch
            {
                CreateEvalLogsDataSourceConfigType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalLogsDataSourceConfigType? ToEnum(string value)
        {
            return value switch
            {
                "logs" => CreateEvalLogsDataSourceConfigType.Logs,
                _ => null,
            };
        }
    }
}