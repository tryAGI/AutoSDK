//HintName: G.Models.ElevenLabsGeneratedAssetProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the provider - set to `elevenlabs` for ElevenLabs.<br/>
    /// Default Value: elevenlabs
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ElevenLabsGeneratedAssetProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsGeneratedAssetProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsGeneratedAssetProvider value)
        {
            return value switch
            {
                ElevenLabsGeneratedAssetProvider.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsGeneratedAssetProvider? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => ElevenLabsGeneratedAssetProvider.Elevenlabs,
                _ => null,
            };
        }
    }
}