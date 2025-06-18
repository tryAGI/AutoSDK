//HintName: G.Models.RealtimeSessionCreateRequestTracingEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default tracing mode for the session.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionCreateRequestTracingEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestTracingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestTracingEnum value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestTracingEnum.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestTracingEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeSessionCreateRequestTracingEnum.Auto,
                _ => null,
            };
        }
    }
}