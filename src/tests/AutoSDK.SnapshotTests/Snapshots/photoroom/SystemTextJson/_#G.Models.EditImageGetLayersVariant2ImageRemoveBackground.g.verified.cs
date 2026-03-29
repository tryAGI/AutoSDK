//HintName: G.Models.EditImageGetLayersVariant2ImageRemoveBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetLayersVariant2ImageRemoveBackground
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Never,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetLayersVariant2ImageRemoveBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetLayersVariant2ImageRemoveBackground value)
        {
            return value switch
            {
                EditImageGetLayersVariant2ImageRemoveBackground.Auto => "auto",
                EditImageGetLayersVariant2ImageRemoveBackground.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetLayersVariant2ImageRemoveBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => EditImageGetLayersVariant2ImageRemoveBackground.Auto,
                "never" => EditImageGetLayersVariant2ImageRemoveBackground.Never,
                _ => null,
            };
        }
    }
}