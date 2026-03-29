//HintName: G.Models.PostFinalTranscriptMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: post_final_transcript<br/>
    /// Example: post_final_transcript
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostFinalTranscriptMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="post_final_transcript")]
        PostFinalTranscript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostFinalTranscriptMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostFinalTranscriptMessageType value)
        {
            return value switch
            {
                PostFinalTranscriptMessageType.PostFinalTranscript => "post_final_transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostFinalTranscriptMessageType? ToEnum(string value)
        {
            return value switch
            {
                "post_final_transcript" => PostFinalTranscriptMessageType.PostFinalTranscript,
                _ => null,
            };
        }
    }
}