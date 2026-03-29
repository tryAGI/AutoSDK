//HintName: G.Models.HangupNodeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HangupNodeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hangup")]
        Hangup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HangupNodeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HangupNodeType value)
        {
            return value switch
            {
                HangupNodeType.Hangup => "hangup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HangupNodeType? ToEnum(string value)
        {
            return value switch
            {
                "hangup" => HangupNodeType.Hangup,
                _ => null,
            };
        }
    }
}