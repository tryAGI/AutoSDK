//HintName: G.Models.RichCaptionStyleTextTransform.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text transformation to apply.<br/>
    /// Default Value: none<br/>
    /// Example: uppercase
    /// </summary>
    public enum RichCaptionStyleTextTransform
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
    public static class RichCaptionStyleTextTransformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichCaptionStyleTextTransform value)
        {
            return value switch
            {
                RichCaptionStyleTextTransform.Capitalize => "capitalize",
                RichCaptionStyleTextTransform.Lowercase => "lowercase",
                RichCaptionStyleTextTransform.None => "none",
                RichCaptionStyleTextTransform.Uppercase => "uppercase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichCaptionStyleTextTransform? ToEnum(string value)
        {
            return value switch
            {
                "capitalize" => RichCaptionStyleTextTransform.Capitalize,
                "lowercase" => RichCaptionStyleTextTransform.Lowercase,
                "none" => RichCaptionStyleTextTransform.None,
                "uppercase" => RichCaptionStyleTextTransform.Uppercase,
                _ => null,
            };
        }
    }
}