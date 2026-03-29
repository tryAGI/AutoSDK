//HintName: G.Models.StabilityAiTextToImageOptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset to generate - set to `text-to-image` for text-to-image.<br/>
    /// Default Value: text-to-image
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StabilityAiTextToImageOptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-to-image")]
        TextToImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StabilityAiTextToImageOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StabilityAiTextToImageOptionsType value)
        {
            return value switch
            {
                StabilityAiTextToImageOptionsType.TextToImage => "text-to-image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StabilityAiTextToImageOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "text-to-image" => StabilityAiTextToImageOptionsType.TextToImage,
                _ => null,
            };
        }
    }
}