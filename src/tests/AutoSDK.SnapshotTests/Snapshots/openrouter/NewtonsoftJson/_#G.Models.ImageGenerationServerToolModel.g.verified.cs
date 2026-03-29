//HintName: G.Models.ImageGenerationServerToolModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageGenerationServerToolModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-image-1")]
        GptImage1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-image-1-mini")]
        GptImage1Mini,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationServerToolModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolModel value)
        {
            return value switch
            {
                ImageGenerationServerToolModel.GptImage1 => "gpt-image-1",
                ImageGenerationServerToolModel.GptImage1Mini => "gpt-image-1-mini",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-image-1" => ImageGenerationServerToolModel.GptImage1,
                "gpt-image-1-mini" => ImageGenerationServerToolModel.GptImage1Mini,
                _ => null,
            };
        }
    }
}