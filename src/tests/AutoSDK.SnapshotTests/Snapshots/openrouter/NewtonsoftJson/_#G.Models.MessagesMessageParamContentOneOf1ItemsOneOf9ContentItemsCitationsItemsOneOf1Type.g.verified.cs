//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="page_location")]
        PageLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "page_location" => MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1Type.PageLocation,
                _ => null,
            };
        }
    }
}