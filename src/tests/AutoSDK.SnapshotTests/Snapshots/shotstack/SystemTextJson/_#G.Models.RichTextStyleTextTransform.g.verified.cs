//HintName: G.Models.RichTextStyleTextTransform.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text transformation to apply.<br/>
    /// Default Value: none<br/>
    /// Example: uppercase
    /// </summary>
    public enum RichTextStyleTextTransform
    {
        /// <summary>
        /// 
        /// </summary>
        Capitalize,
        /// <summary>
        /// 
        /// </summary>
        Lowercase,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Uppercase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichTextStyleTextTransformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichTextStyleTextTransform value)
        {
            return value switch
            {
                RichTextStyleTextTransform.Capitalize => "capitalize",
                RichTextStyleTextTransform.Lowercase => "lowercase",
                RichTextStyleTextTransform.None => "none",
                RichTextStyleTextTransform.Uppercase => "uppercase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichTextStyleTextTransform? ToEnum(string value)
        {
            return value switch
            {
                "capitalize" => RichTextStyleTextTransform.Capitalize,
                "lowercase" => RichTextStyleTextTransform.Lowercase,
                "none" => RichTextStyleTextTransform.None,
                "uppercase" => RichTextStyleTextTransform.Uppercase,
                _ => null,
            };
        }
    }
}