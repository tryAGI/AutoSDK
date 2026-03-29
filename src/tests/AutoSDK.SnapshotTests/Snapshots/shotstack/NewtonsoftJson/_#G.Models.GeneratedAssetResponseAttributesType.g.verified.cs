//HintName: G.Models.GeneratedAssetResponseAttributesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of service used to generate the asset, `text-to-speech` or `text-to-avatar`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GeneratedAssetResponseAttributesType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-to-avatar")]
        TextToAvatar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-to-speech")]
        TextToSpeech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratedAssetResponseAttributesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedAssetResponseAttributesType value)
        {
            return value switch
            {
                GeneratedAssetResponseAttributesType.TextToAvatar => "text-to-avatar",
                GeneratedAssetResponseAttributesType.TextToSpeech => "text-to-speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedAssetResponseAttributesType? ToEnum(string value)
        {
            return value switch
            {
                "text-to-avatar" => GeneratedAssetResponseAttributesType.TextToAvatar,
                "text-to-speech" => GeneratedAssetResponseAttributesType.TextToSpeech,
                _ => null,
            };
        }
    }
}