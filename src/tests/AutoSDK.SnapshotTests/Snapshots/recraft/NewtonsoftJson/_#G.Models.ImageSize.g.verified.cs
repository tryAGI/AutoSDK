//HintName: G.Models.ImageSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageSize
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1024")]
        x1024x1024,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1365x1024")]
        x1365x1024,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1365")]
        x1024x1365,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1536x1024")]
        x1536x1024,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1536")]
        x1024x1536,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1820x1024")]
        x1820x1024,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1820")]
        x1024x1820,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x2048")]
        x1024x2048,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2048x1024")]
        x2048x1024,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1434x1024")]
        x1434x1024,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1434")]
        x1024x1434,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1280")]
        x1024x1280,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1280x1024")]
        x1280x1024,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1707")]
        x1024x1707,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1707x1024")]
        x1707x1024,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageSize value)
        {
            return value switch
            {
                ImageSize.x1024x1024 => "1024x1024",
                ImageSize.x1365x1024 => "1365x1024",
                ImageSize.x1024x1365 => "1024x1365",
                ImageSize.x1536x1024 => "1536x1024",
                ImageSize.x1024x1536 => "1024x1536",
                ImageSize.x1820x1024 => "1820x1024",
                ImageSize.x1024x1820 => "1024x1820",
                ImageSize.x1024x2048 => "1024x2048",
                ImageSize.x2048x1024 => "2048x1024",
                ImageSize.x1434x1024 => "1434x1024",
                ImageSize.x1024x1434 => "1024x1434",
                ImageSize.x1024x1280 => "1024x1280",
                ImageSize.x1280x1024 => "1280x1024",
                ImageSize.x1024x1707 => "1024x1707",
                ImageSize.x1707x1024 => "1707x1024",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ImageSize.x1024x1024,
                "1365x1024" => ImageSize.x1365x1024,
                "1024x1365" => ImageSize.x1024x1365,
                "1536x1024" => ImageSize.x1536x1024,
                "1024x1536" => ImageSize.x1024x1536,
                "1820x1024" => ImageSize.x1820x1024,
                "1024x1820" => ImageSize.x1024x1820,
                "1024x2048" => ImageSize.x1024x2048,
                "2048x1024" => ImageSize.x2048x1024,
                "1434x1024" => ImageSize.x1434x1024,
                "1024x1434" => ImageSize.x1024x1434,
                "1024x1280" => ImageSize.x1024x1280,
                "1280x1024" => ImageSize.x1280x1024,
                "1024x1707" => ImageSize.x1024x1707,
                "1707x1024" => ImageSize.x1707x1024,
                _ => null,
            };
        }
    }
}