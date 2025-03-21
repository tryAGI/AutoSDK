//HintName: G.Models.RealtimeSessionCreateRequestToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool, i.e. `function`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionCreateRequestToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestToolType value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestToolType? ToEnum(string value)
        {
            return value switch
            {
                "function" => RealtimeSessionCreateRequestToolType.Function,
                _ => null,
            };
        }
    }
}