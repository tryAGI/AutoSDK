//HintName: G.Models.AudioNativeProjectSettingsResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current state of the project<br/>
    /// Default Value: ready
    /// </summary>
    public enum AudioNativeProjectSettingsResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioNativeProjectSettingsResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioNativeProjectSettingsResponseModelStatus value)
        {
            return value switch
            {
                AudioNativeProjectSettingsResponseModelStatus.Processing => "processing",
                AudioNativeProjectSettingsResponseModelStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioNativeProjectSettingsResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "processing" => AudioNativeProjectSettingsResponseModelStatus.Processing,
                "ready" => AudioNativeProjectSettingsResponseModelStatus.Ready,
                _ => null,
            };
        }
    }
}