//HintName: G.Models.CreateTaskRequestVariant9TextureFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant9TextureFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Bmp,
        /// <summary>
        /// 
        /// </summary>
        Dpx,
        /// <summary>
        /// 
        /// </summary>
        Hdr,
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
        /// <summary>
        /// 
        /// </summary>
        OpenExr,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Targa,
        /// <summary>
        /// 
        /// </summary>
        Tiff,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant9TextureFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant9TextureFormat value)
        {
            return value switch
            {
                CreateTaskRequestVariant9TextureFormat.Bmp => "BMP",
                CreateTaskRequestVariant9TextureFormat.Dpx => "DPX",
                CreateTaskRequestVariant9TextureFormat.Hdr => "HDR",
                CreateTaskRequestVariant9TextureFormat.Jpeg => "JPEG",
                CreateTaskRequestVariant9TextureFormat.OpenExr => "OPEN_EXR",
                CreateTaskRequestVariant9TextureFormat.Png => "PNG",
                CreateTaskRequestVariant9TextureFormat.Targa => "TARGA",
                CreateTaskRequestVariant9TextureFormat.Tiff => "TIFF",
                CreateTaskRequestVariant9TextureFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant9TextureFormat? ToEnum(string value)
        {
            return value switch
            {
                "BMP" => CreateTaskRequestVariant9TextureFormat.Bmp,
                "DPX" => CreateTaskRequestVariant9TextureFormat.Dpx,
                "HDR" => CreateTaskRequestVariant9TextureFormat.Hdr,
                "JPEG" => CreateTaskRequestVariant9TextureFormat.Jpeg,
                "OPEN_EXR" => CreateTaskRequestVariant9TextureFormat.OpenExr,
                "PNG" => CreateTaskRequestVariant9TextureFormat.Png,
                "TARGA" => CreateTaskRequestVariant9TextureFormat.Targa,
                "TIFF" => CreateTaskRequestVariant9TextureFormat.Tiff,
                "WEBP" => CreateTaskRequestVariant9TextureFormat.Webp,
                _ => null,
            };
        }
    }
}