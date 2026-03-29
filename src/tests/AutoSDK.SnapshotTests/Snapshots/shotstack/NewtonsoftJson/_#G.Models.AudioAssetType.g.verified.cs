//HintName: G.Models.AudioAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset - set to `audio` for audio assets.<br/>
    /// Default Value: audio
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AudioAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioAssetType value)
        {
            return value switch
            {
                AudioAssetType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioAssetType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AudioAssetType.Audio,
                _ => null,
            };
        }
    }
}