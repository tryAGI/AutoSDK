//HintName: G.Models.StabilityAiGeneratedAssetProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the provider - set to `stability-ai` for Stability AI.<br/>
    /// Default Value: stability-ai
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StabilityAiGeneratedAssetProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stability-ai")]
        StabilityAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StabilityAiGeneratedAssetProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StabilityAiGeneratedAssetProvider value)
        {
            return value switch
            {
                StabilityAiGeneratedAssetProvider.StabilityAi => "stability-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StabilityAiGeneratedAssetProvider? ToEnum(string value)
        {
            return value switch
            {
                "stability-ai" => StabilityAiGeneratedAssetProvider.StabilityAi,
                _ => null,
            };
        }
    }
}