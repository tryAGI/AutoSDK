//HintName: G.Models.EditImageGetVerticalAlignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetVerticalAlignment
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
    public static class EditImageGetVerticalAlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetVerticalAlignment value)
        {
            return value switch
            {
                EditImageGetVerticalAlignment.Bottom => "bottom",
                EditImageGetVerticalAlignment.Center => "center",
                EditImageGetVerticalAlignment.Top => "top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetVerticalAlignment? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => EditImageGetVerticalAlignment.Bottom,
                "center" => EditImageGetVerticalAlignment.Center,
                "top" => EditImageGetVerticalAlignment.Top,
                _ => null,
            };
        }
    }
}