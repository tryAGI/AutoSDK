//HintName: G.Models.RichCaptionActiveStroke.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RichCaptionActiveStroke
    {
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichCaptionActiveStrokeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichCaptionActiveStroke value)
        {
            return value switch
            {
                RichCaptionActiveStroke.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichCaptionActiveStroke? ToEnum(string value)
        {
            return value switch
            {
                "none" => RichCaptionActiveStroke.None,
                _ => null,
            };
        }
    }
}