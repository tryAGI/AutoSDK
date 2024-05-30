//HintName: G.Models.CreateImageVariationRequestSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`.
    /// <br/>Default Value: 1024x1024
    /// <br/>Example: 1024x1024
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageVariationRequestSize
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="256x256")]
        _256x256,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="512x512")]
        _512x512,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1024")]
        _1024x1024,
    }

    public static class CreateImageVariationRequestSizeExtensions
    {
        public static string ToValueString(this CreateImageVariationRequestSize value)
        {
            return value switch
            {
                CreateImageVariationRequestSize._256x256 => "256x256",
                CreateImageVariationRequestSize._512x512 => "512x512",
                CreateImageVariationRequestSize._1024x1024 => "1024x1024",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageVariationRequestSize ToEnum(string value)
        {
            return value switch
            {
                "256x256" => CreateImageVariationRequestSize._256x256,
                "512x512" => CreateImageVariationRequestSize._512x512,
                "1024x1024" => CreateImageVariationRequestSize._1024x1024,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageVariationRequestSize ToEnum(int value)
        {
            return value switch
            {
                0 => CreateImageVariationRequestSize._256x256,
                1 => CreateImageVariationRequestSize._512x512,
                2 => CreateImageVariationRequestSize._1024x1024,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}