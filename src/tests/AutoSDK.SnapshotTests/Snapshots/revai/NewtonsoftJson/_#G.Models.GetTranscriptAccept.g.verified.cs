//HintName: G.Models.GetTranscriptAccept.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: application/vnd.rev.transcript.v1.0+json
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTranscriptAccept
    {
        /// <summary>
        /// application/vnd.rev.transcript.v1.0+json for JSON or text/plain for plain text
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="application/vnd.rev.transcript.v1.0+json")]
        ApplicationVndRevTranscriptV10Plusjson,
        /// <summary>
        /// application/vnd.rev.transcript.v1.0+json for JSON or text/plain for plain text
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text/plain")]
        TextPlain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTranscriptAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTranscriptAccept value)
        {
            return value switch
            {
                GetTranscriptAccept.ApplicationVndRevTranscriptV10Plusjson => "application/vnd.rev.transcript.v1.0+json",
                GetTranscriptAccept.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTranscriptAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/vnd.rev.transcript.v1.0+json" => GetTranscriptAccept.ApplicationVndRevTranscriptV10Plusjson,
                "text/plain" => GetTranscriptAccept.TextPlain,
                _ => null,
            };
        }
    }
}