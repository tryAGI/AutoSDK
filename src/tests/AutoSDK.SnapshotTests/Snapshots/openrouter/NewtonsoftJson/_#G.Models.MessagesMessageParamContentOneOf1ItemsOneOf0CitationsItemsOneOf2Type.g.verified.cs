//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_location")]
        ContentBlockLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf2Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf2Type.ContentBlockLocation => "content_block_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "content_block_location" => MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf2Type.ContentBlockLocation,
                _ => null,
            };
        }
    }
}