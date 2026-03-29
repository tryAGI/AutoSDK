//HintName: G.Models.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="live")]
        Live,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pre-recorded")]
        PreRecorded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind value)
        {
            return value switch
            {
                TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.Live => "live",
                TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.PreRecorded => "pre-recorded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "live" => TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.Live,
                "pre-recorded" => TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.PreRecorded,
                _ => null,
            };
        }
    }
}