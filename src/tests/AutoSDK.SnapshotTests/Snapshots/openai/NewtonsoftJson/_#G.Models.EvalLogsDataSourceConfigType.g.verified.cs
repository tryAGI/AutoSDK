//HintName: G.Models.EvalLogsDataSourceConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of data source. Always `logs`.<br/>
    /// Default Value: logs
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalLogsDataSourceConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logs")]
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalLogsDataSourceConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalLogsDataSourceConfigType value)
        {
            return value switch
            {
                EvalLogsDataSourceConfigType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalLogsDataSourceConfigType? ToEnum(string value)
        {
            return value switch
            {
                "logs" => EvalLogsDataSourceConfigType.Logs,
                _ => null,
            };
        }
    }
}