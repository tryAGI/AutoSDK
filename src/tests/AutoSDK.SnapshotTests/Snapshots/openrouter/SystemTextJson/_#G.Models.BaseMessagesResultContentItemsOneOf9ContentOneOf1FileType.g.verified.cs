//HintName: G.Models.BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf9ContentOneOf1FileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType.Image => "image",
                BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType.Pdf => "pdf",
                BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType? ToEnum(string value)
        {
            return value switch
            {
                "image" => BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType.Image,
                "pdf" => BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType.Pdf,
                "text" => BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType.Text,
                _ => null,
            };
        }
    }
}