//HintName: G.Models.EditImageGetExportFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: png
    /// </summary>
    public enum EditImageGetExportFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
        /// <summary>
        /// 
        /// </summary>
        Jpg,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetExportFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetExportFormat value)
        {
            return value switch
            {
                EditImageGetExportFormat.Jpeg => "jpeg",
                EditImageGetExportFormat.Jpg => "jpg",
                EditImageGetExportFormat.Png => "png",
                EditImageGetExportFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetExportFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => EditImageGetExportFormat.Jpeg,
                "jpg" => EditImageGetExportFormat.Jpg,
                "png" => EditImageGetExportFormat.Png,
                "webp" => EditImageGetExportFormat.Webp,
                _ => null,
            };
        }
    }
}