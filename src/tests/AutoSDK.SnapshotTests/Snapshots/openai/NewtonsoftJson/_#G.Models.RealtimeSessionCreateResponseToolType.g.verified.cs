//HintName: G.Models.RealtimeSessionCreateResponseToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool, i.e. `function`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionCreateResponseToolType
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
    public static class RealtimeSessionCreateResponseToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseToolType value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseToolType? ToEnum(string value)
        {
            return value switch
            {
                "function" => RealtimeSessionCreateResponseToolType.Function,
                _ => null,
            };
        }
    }
}