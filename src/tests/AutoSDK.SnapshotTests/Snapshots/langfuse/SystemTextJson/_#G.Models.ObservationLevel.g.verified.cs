//HintName: G.Models.ObservationLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservationLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Debug,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
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