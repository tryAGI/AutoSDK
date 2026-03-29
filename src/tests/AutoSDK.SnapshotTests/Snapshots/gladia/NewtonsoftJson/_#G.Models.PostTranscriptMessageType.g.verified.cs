//HintName: G.Models.PostTranscriptMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: post_transcript<br/>
    /// Example: post_transcript
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostTranscriptMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="post_transcript")]
        PostTranscript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostTranscriptMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostTranscriptMessageType value)
        {
            return value switch
            {
                PostTranscriptMessageType.PostTranscript => "post_transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostTranscriptMessageType? ToEnum(string value)
        {
            return value switch
            {
                "post_transcript" => PostTranscriptMessageType.PostTranscript,
                _ => null,
            };
        }
    }
}