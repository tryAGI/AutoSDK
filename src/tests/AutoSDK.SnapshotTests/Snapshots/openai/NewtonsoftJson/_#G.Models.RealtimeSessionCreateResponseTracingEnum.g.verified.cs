//HintName: G.Models.RealtimeSessionCreateResponseTracingEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default tracing mode for the session.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionCreateResponseTracingEnum
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
    public static class RealtimeSessionCreateResponseTracingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseTracingEnum value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseTracingEnum.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseTracingEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeSessionCreateResponseTracingEnum.Auto,
                _ => null,
            };
        }
    }
}