//HintName: G.Models.ListenV1ServerEventDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListenV1ServerEventDiscriminatorMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="listen_metadata")]
        ListenMetadata,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript_result")]
        TranscriptResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1ServerEventDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1ServerEventDiscriminatorMessageType value)
        {
            return value switch
            {
                ListenV1ServerEventDiscriminatorMessageType.ListenMetadata => "listen_metadata",
                ListenV1ServerEventDiscriminatorMessageType.TranscriptResult => "transcript_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1ServerEventDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "listen_metadata" => ListenV1ServerEventDiscriminatorMessageType.ListenMetadata,
                "transcript_result" => ListenV1ServerEventDiscriminatorMessageType.TranscriptResult,
                _ => null,
            };
        }
    }
}