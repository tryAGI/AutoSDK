//HintName: G.Models.EditImageGetPreserveMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: never
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetPreserveMetadata
    {
        /// <summary>
        /// Preserve EXIF Copyright (IFD0) and UserComment (ExifIFD) fields only.   **Deprecated** — use `exifSubsetWithXmpCompatibility` instead. Will be removed in a future release.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exifSubset")]
        ExifSubset,
        /// <summary>
        /// Preserve EXIF Copyright (IFD0) and UserComment (ExifIFD) fields only.   **Deprecated** — use `exifSubsetWithXmpCompatibility` instead. Will be removed in a future release.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exifSubsetWithXmpCompatibility")]
        ExifSubsetWithXmpCompatibility,
        /// <summary>
        /// No metadata preservation (default)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="never")]
        Never,
        /// <summary>
        /// Preserve XMP metadata including camera settings, copyright information, and other embedded metadata
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xmp")]
        Xmp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetPreserveMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetPreserveMetadata value)
        {
            return value switch
            {
                EditImageGetPreserveMetadata.ExifSubset => "exifSubset",
                EditImageGetPreserveMetadata.ExifSubsetWithXmpCompatibility => "exifSubsetWithXmpCompatibility",
                EditImageGetPreserveMetadata.Never => "never",
                EditImageGetPreserveMetadata.Xmp => "xmp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetPreserveMetadata? ToEnum(string value)
        {
            return value switch
            {
                "exifSubset" => EditImageGetPreserveMetadata.ExifSubset,
                "exifSubsetWithXmpCompatibility" => EditImageGetPreserveMetadata.ExifSubsetWithXmpCompatibility,
                "never" => EditImageGetPreserveMetadata.Never,
                "xmp" => EditImageGetPreserveMetadata.Xmp,
                _ => null,
            };
        }
    }
}