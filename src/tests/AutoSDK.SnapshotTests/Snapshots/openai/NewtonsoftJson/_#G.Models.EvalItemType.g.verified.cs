//HintName: G.Models.EvalItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the message input. Always `message`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalItemType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message")]
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalItemType value)
        {
            return value switch
            {
                EvalItemType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalItemType? ToEnum(string value)
        {
            return value switch
            {
                "message" => EvalItemType.Message,
                _ => null,
            };
        }
    }
}