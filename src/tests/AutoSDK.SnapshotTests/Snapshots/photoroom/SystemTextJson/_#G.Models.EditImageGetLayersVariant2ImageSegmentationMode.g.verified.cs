//HintName: G.Models.EditImageGetLayersVariant2ImageSegmentationMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls whether or not the salient object should be kept or ignored by the segmentation model.
    /// </summary>
    public enum EditImageGetLayersVariant2ImageSegmentationMode
    {
        /// <summary>
        /// 
        /// </summary>
        IgnoreSalientObject,
        /// <summary>
        /// 
        /// </summary>
        KeepSalientObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetLayersVariant2ImageSegmentationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetLayersVariant2ImageSegmentationMode value)
        {
            return value switch
            {
                EditImageGetLayersVariant2ImageSegmentationMode.IgnoreSalientObject => "ignoreSalientObject",
                EditImageGetLayersVariant2ImageSegmentationMode.KeepSalientObject => "keepSalientObject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetLayersVariant2ImageSegmentationMode? ToEnum(string value)
        {
            return value switch
            {
                "ignoreSalientObject" => EditImageGetLayersVariant2ImageSegmentationMode.IgnoreSalientObject,
                "keepSalientObject" => EditImageGetLayersVariant2ImageSegmentationMode.KeepSalientObject,
                _ => null,
            };
        }
    }
}