//HintName: G.Models.ListenV1ServerEventDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListenV1ServerEventDiscriminatorMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptResult,
        /// <summary>
        /// 
        /// </summary>
        ListenMetadata,
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
                ListenV1ServerEventDiscriminatorMessageType.TranscriptResult => "transcript_result",
                ListenV1ServerEventDiscriminatorMessageType.ListenMetadata => "listen_metadata",
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
                "transcript_result" => ListenV1ServerEventDiscriminatorMessageType.TranscriptResult,
                "listen_metadata" => ListenV1ServerEventDiscriminatorMessageType.ListenMetadata,
                _ => null,
            };
        }
    }
}