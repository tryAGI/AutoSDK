//HintName: G.Models.GeneratedAssetDiscriminatorProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GeneratedAssetDiscriminatorProvider
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
        [global::System.Runtime.Serialization.EnumMember(Value="openai")]
        Openai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shotstack")]
        Shotstack,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stability-ai")]
        StabilityAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratedAssetDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedAssetDiscriminatorProvider value)
        {
            return value switch
            {
                GeneratedAssetDiscriminatorProvider.DId => "d-id",
                GeneratedAssetDiscriminatorProvider.Elevenlabs => "elevenlabs",
                GeneratedAssetDiscriminatorProvider.Heygen => "heygen",
                GeneratedAssetDiscriminatorProvider.Openai => "openai",
                GeneratedAssetDiscriminatorProvider.Shotstack => "shotstack",
                GeneratedAssetDiscriminatorProvider.StabilityAi => "stability-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedAssetDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => GeneratedAssetDiscriminatorProvider.DId,
                "elevenlabs" => GeneratedAssetDiscriminatorProvider.Elevenlabs,
                "heygen" => GeneratedAssetDiscriminatorProvider.Heygen,
                "openai" => GeneratedAssetDiscriminatorProvider.Openai,
                "shotstack" => GeneratedAssetDiscriminatorProvider.Shotstack,
                "stability-ai" => GeneratedAssetDiscriminatorProvider.StabilityAi,
                _ => null,
            };
        }
    }
}