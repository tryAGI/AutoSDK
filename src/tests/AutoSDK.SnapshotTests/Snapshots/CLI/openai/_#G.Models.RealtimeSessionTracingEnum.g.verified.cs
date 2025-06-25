//HintName: G.Models.RealtimeSessionTracingEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default tracing mode for the session.<br/>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeSessionTracingEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionTracingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionTracingEnum value)
        {
            return value switch
            {
                RealtimeSessionTracingEnum.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionTracingEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeSessionTracingEnum.Auto,
                _ => null,
            };
        }
    }
}