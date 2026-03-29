//HintName: G.Models.GeneratedAssetResponseAttributesProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The native or third party provider that generated the asset, `shotstack`, `elevenlabs`, `heygen` or `d-id`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GeneratedAssetResponseAttributesProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="d-id")]
        DId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="heygen")]
        Heygen,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shotstack")]
        Shotstack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratedAssetResponseAttributesProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedAssetResponseAttributesProvider value)
        {
            return value switch
            {
                GeneratedAssetResponseAttributesProvider.DId => "d-id",
                GeneratedAssetResponseAttributesProvider.Elevenlabs => "elevenlabs",
                GeneratedAssetResponseAttributesProvider.Heygen => "heygen",
                GeneratedAssetResponseAttributesProvider.Shotstack => "shotstack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedAssetResponseAttributesProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => GeneratedAssetResponseAttributesProvider.DId,
                "elevenlabs" => GeneratedAssetResponseAttributesProvider.Elevenlabs,
                "heygen" => GeneratedAssetResponseAttributesProvider.Heygen,
                "shotstack" => GeneratedAssetResponseAttributesProvider.Shotstack,
                _ => null,
            };
        }
    }
}