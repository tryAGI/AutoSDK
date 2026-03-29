//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsType value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsType? ToEnum(string value)
        {
            return value switch
            {
                "text" => MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsType.Text,
                _ => null,
            };
        }
    }
}