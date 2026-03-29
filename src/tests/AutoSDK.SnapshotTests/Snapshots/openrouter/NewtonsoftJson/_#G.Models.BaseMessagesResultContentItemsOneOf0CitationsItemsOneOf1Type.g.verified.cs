//HintName: G.Models.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1Type
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
    public static class BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1Type.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "page_location" => BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1Type.PageLocation,
                _ => null,
            };
        }
    }
}