//HintName: G.Models.RealtimeSessionToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool, i.e. `function`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionToolType
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
    public static class RealtimeSessionToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionToolType value)
        {
            return value switch
            {
                RealtimeSessionToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionToolType? ToEnum(string value)
        {
            return value switch
            {
                "function" => RealtimeSessionToolType.Function,
                _ => null,
            };
        }
    }
}