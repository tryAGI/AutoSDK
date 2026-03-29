//HintName: G.Models.EditImageGetSegmentationMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetSegmentationMode
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
    public static class EditImageGetSegmentationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetSegmentationMode value)
        {
            return value switch
            {
                EditImageGetSegmentationMode.IgnoreSalientObject => "ignoreSalientObject",
                EditImageGetSegmentationMode.KeepSalientObject => "keepSalientObject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetSegmentationMode? ToEnum(string value)
        {
            return value switch
            {
                "ignoreSalientObject" => EditImageGetSegmentationMode.IgnoreSalientObject,
                "keepSalientObject" => EditImageGetSegmentationMode.KeepSalientObject,
                _ => null,
            };
        }
    }
}