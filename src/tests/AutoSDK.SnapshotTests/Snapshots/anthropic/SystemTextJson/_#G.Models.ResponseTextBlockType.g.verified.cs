//HintName: G.Models.ResponseTextBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: text
    /// </summary>
    public enum ResponseTextBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseTextBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTextBlockType value)
        {
            return value switch
            {
                ResponseTextBlockType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTextBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ResponseTextBlockType.Text,
                _ => null,
            };
        }
    }
}