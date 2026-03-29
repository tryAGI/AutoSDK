//HintName: G.Models.EditImageGetLayersVariant2ImageVerticalAlignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetLayersVariant2ImageVerticalAlignment
    {
        /// <summary>
        /// 
        /// </summary>
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        Center,
        /// <summary>
        /// 
        /// </summary>
        Top,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetLayersVariant2ImageVerticalAlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetLayersVariant2ImageVerticalAlignment value)
        {
            return value switch
            {
                EditImageGetLayersVariant2ImageVerticalAlignment.Bottom => "bottom",
                EditImageGetLayersVariant2ImageVerticalAlignment.Center => "center",
                EditImageGetLayersVariant2ImageVerticalAlignment.Top => "top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetLayersVariant2ImageVerticalAlignment? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => EditImageGetLayersVariant2ImageVerticalAlignment.Bottom,
                "center" => EditImageGetLayersVariant2ImageVerticalAlignment.Center,
                "top" => EditImageGetLayersVariant2ImageVerticalAlignment.Top,
                _ => null,
            };
        }
    }
}