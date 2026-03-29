//HintName: G.Models.ImageMetadataCategory2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageMetadataCategory2
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
    public static class ImageMetadataCategory2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMetadataCategory2 value)
        {
            return value switch
            {
                ImageMetadataCategory2.Embedded => "embedded",
                ImageMetadataCategory2.Layout => "layout",
                ImageMetadataCategory2.Screenshot => "screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMetadataCategory2? ToEnum(string value)
        {
            return value switch
            {
                "embedded" => ImageMetadataCategory2.Embedded,
                "layout" => ImageMetadataCategory2.Layout,
                "screenshot" => ImageMetadataCategory2.Screenshot,
                _ => null,
            };
        }
    }
}