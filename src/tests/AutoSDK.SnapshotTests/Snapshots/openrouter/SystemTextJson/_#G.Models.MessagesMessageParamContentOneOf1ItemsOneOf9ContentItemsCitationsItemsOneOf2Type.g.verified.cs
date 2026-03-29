//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ContentBlockLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf2Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf2Type.ContentBlockLocation => "content_block_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "content_block_location" => MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf2Type.ContentBlockLocation,
                _ => null,
            };
        }
    }
}