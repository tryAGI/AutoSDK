//HintName: G.Models.EditImageGetLayersVariant2ImageHorizontalAlignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetLayersVariant2ImageHorizontalAlignment
    {
        /// <summary>
        /// 
        /// </summary>
        Center,
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetLayersVariant2ImageHorizontalAlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetLayersVariant2ImageHorizontalAlignment value)
        {
            return value switch
            {
                EditImageGetLayersVariant2ImageHorizontalAlignment.Center => "center",
                EditImageGetLayersVariant2ImageHorizontalAlignment.Left => "left",
                EditImageGetLayersVariant2ImageHorizontalAlignment.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetLayersVariant2ImageHorizontalAlignment? ToEnum(string value)
        {
            return value switch
            {
                "center" => EditImageGetLayersVariant2ImageHorizontalAlignment.Center,
                "left" => EditImageGetLayersVariant2ImageHorizontalAlignment.Left,
                "right" => EditImageGetLayersVariant2ImageHorizontalAlignment.Right,
                _ => null,
            };
        }
    }
}