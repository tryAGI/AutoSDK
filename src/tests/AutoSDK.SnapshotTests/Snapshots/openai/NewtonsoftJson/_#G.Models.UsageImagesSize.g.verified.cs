//HintName: G.Models.UsageImagesSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageImagesSize
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="256x256")]
        x256x256,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="512x512")]
        x512x512,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1024")]
        x1024x1024,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1792x1792")]
        x1792x1792,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1792")]
        x1024x1792,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageImagesSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageImagesSize value)
        {
            return value switch
            {
                UsageImagesSize.x256x256 => "256x256",
                UsageImagesSize.x512x512 => "512x512",
                UsageImagesSize.x1024x1024 => "1024x1024",
                UsageImagesSize.x1792x1792 => "1792x1792",
                UsageImagesSize.x1024x1792 => "1024x1792",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageImagesSize? ToEnum(string value)
        {
            return value switch
            {
                "256x256" => UsageImagesSize.x256x256,
                "512x512" => UsageImagesSize.x512x512,
                "1024x1024" => UsageImagesSize.x1024x1024,
                "1792x1792" => UsageImagesSize.x1792x1792,
                "1024x1792" => UsageImagesSize.x1024x1792,
                _ => null,
            };
        }
    }
}