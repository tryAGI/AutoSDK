//HintName: G.Models.ObservationLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ObservationLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DEBUG")]
        Debug,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DEFAULT")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="WARNING")]
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservationLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservationLevel value)
        {
            return value switch
            {
                ObservationLevel.Debug => "DEBUG",
                ObservationLevel.Default => "DEFAULT",
                ObservationLevel.Error => "ERROR",
                ObservationLevel.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservationLevel? ToEnum(string value)
        {
            return value switch
            {
                "DEBUG" => ObservationLevel.Debug,
                "DEFAULT" => ObservationLevel.Default,
                "ERROR" => ObservationLevel.Error,
                "WARNING" => ObservationLevel.Warning,
                _ => null,
            };
        }
    }
}