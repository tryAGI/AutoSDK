//HintName: G.Models.MessagesRequestToolChoiceOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestToolChoiceOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="any")]
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolChoiceOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolChoiceOneOf1Type value)
        {
            return value switch
            {
                MessagesRequestToolChoiceOneOf1Type.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolChoiceOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "any" => MessagesRequestToolChoiceOneOf1Type.Any,
                _ => null,
            };
        }
    }
}