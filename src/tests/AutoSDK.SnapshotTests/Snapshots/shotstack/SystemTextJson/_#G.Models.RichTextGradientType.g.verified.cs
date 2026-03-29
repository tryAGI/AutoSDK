//HintName: G.Models.RichTextGradientType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of gradient.<br/>
    /// Default Value: linear<br/>
    /// Example: linear
    /// </summary>
    public enum RichTextGradientType
    {
        /// <summary>
        /// 
        /// </summary>
        Linear,
        /// <summary>
        /// 
        /// </summary>
        Radial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichTextGradientTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichTextGradientType value)
        {
            return value switch
            {
                RichTextGradientType.Linear => "linear",
                RichTextGradientType.Radial => "radial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichTextGradientType? ToEnum(string value)
        {
            return value switch
            {
                "linear" => RichTextGradientType.Linear,
                "radial" => RichTextGradientType.Radial,
                _ => null,
            };
        }
    }
}