//HintName: G.Models.ArtifactPlanRecordingFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This determines the format of the recording. Defaults to `wav;l16`.<br/>
    /// @default 'wav;l16'
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ArtifactPlanRecordingFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3")]
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav;l16")]
        Wav_l16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArtifactPlanRecordingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArtifactPlanRecordingFormat value)
        {
            return value switch
            {
                ArtifactPlanRecordingFormat.Mp3 => "mp3",
                ArtifactPlanRecordingFormat.Wav_l16 => "wav;l16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArtifactPlanRecordingFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => ArtifactPlanRecordingFormat.Mp3,
                "wav;l16" => ArtifactPlanRecordingFormat.Wav_l16,
                _ => null,
            };
        }
    }
}