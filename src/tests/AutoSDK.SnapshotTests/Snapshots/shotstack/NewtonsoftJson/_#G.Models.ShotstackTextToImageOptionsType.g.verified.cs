//HintName: G.Models.ShotstackTextToImageOptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset to generate - set to `text-to-image` for text-to-image.<br/>
    /// Default Value: text-to-image
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ShotstackTextToImageOptionsType
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
    public static class ShotstackTextToImageOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShotstackTextToImageOptionsType value)
        {
            return value switch
            {
                ShotstackTextToImageOptionsType.TextToImage => "text-to-image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShotstackTextToImageOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "text-to-image" => ShotstackTextToImageOptionsType.TextToImage,
                _ => null,
            };
        }
    }
}