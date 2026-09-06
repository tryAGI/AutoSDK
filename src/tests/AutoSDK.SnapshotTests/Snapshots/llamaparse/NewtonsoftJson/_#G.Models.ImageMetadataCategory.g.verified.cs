//HintName: G.Models.ImageMetadataCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageMetadataCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedded")]
        Embedded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="layout")]
        Layout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="screenshot")]
        Screenshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageMetadataCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMetadataCategory value)
        {
            return value switch
            {
                ImageMetadataCategory.Embedded => "embedded",
                ImageMetadataCategory.Layout => "layout",
                ImageMetadataCategory.Screenshot => "screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMetadataCategory? ToEnum(string value)
        {
            return value switch
            {
                "embedded" => ImageMetadataCategory.Embedded,
                "layout" => ImageMetadataCategory.Layout,
                "screenshot" => ImageMetadataCategory.Screenshot,
                _ => null,
            };
        }
    }
}