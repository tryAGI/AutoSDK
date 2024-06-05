//HintName: G.Models.FineTuningJobEventLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuningJobEventLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="info")]
        Info,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="warn")]
        Warn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuningJobEventLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuningJobEventLevel value)
        {
            return value switch
            {
                FineTuningJobEventLevel.Info => "info",
                FineTuningJobEventLevel.Warn => "warn",
                FineTuningJobEventLevel.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuningJobEventLevel? ToEnum(string value)
        {
            return value switch
            {
                "info" => FineTuningJobEventLevel.Info,
                "warn" => FineTuningJobEventLevel.Warn,
                "error" => FineTuningJobEventLevel.Error,
                _ => null,
            };
        }
    }
}