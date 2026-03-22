//HintName: G.Models.UsageImagesSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageImagesSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image.edit")]
        ImageEdit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image.generation")]
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image.variation")]
        ImageVariation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageImagesSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageImagesSource value)
        {
            return value switch
            {
                UsageImagesSource.ImageEdit => "image.edit",
                UsageImagesSource.ImageGeneration => "image.generation",
                UsageImagesSource.ImageVariation => "image.variation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageImagesSource? ToEnum(string value)
        {
            return value switch
            {
                "image.edit" => UsageImagesSource.ImageEdit,
                "image.generation" => UsageImagesSource.ImageGeneration,
                "image.variation" => UsageImagesSource.ImageVariation,
                _ => null,
            };
        }
    }
}