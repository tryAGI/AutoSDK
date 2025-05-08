//HintName: G.Models.CreateImageRequestSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The size of the generated images. Must be one of `1024x1024`, `1536x1024` (landscape), `1024x1536` (portrait), or `auto` (default value) for `gpt-image-1`, one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`, and one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3`.<br/>
    /// Default Value: auto<br/>
    /// Example: 1024x1024
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageRequestSize
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1024")]
        x1024x1024,
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
        [global::System.Runtime.Serialization.EnumMember(Value="1792x1024")]
        x1792x1024,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1792")]
        x1024x1792,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestSize value)
        {
            return value switch
            {
                CreateImageRequestSize.Auto => "auto",
                CreateImageRequestSize.x1024x1024 => "1024x1024",
                CreateImageRequestSize.x1536x1024 => "1536x1024",
                CreateImageRequestSize.x1024x1536 => "1024x1536",
                CreateImageRequestSize.x256x256 => "256x256",
                CreateImageRequestSize.x512x512 => "512x512",
                CreateImageRequestSize.x1792x1024 => "1792x1024",
                CreateImageRequestSize.x1024x1792 => "1024x1792",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestSize? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateImageRequestSize.Auto,
                "1024x1024" => CreateImageRequestSize.x1024x1024,
                "1536x1024" => CreateImageRequestSize.x1536x1024,
                "1024x1536" => CreateImageRequestSize.x1024x1536,
                "256x256" => CreateImageRequestSize.x256x256,
                "512x512" => CreateImageRequestSize.x512x512,
                "1792x1024" => CreateImageRequestSize.x1792x1024,
                "1024x1792" => CreateImageRequestSize.x1024x1792,
                _ => null,
            };
        }
    }
}