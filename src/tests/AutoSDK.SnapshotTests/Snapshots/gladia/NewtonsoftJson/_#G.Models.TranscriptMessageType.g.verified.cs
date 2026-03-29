//HintName: G.Models.TranscriptMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: transcript<br/>
    /// Example: transcript
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript")]
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptMessageType value)
        {
            return value switch
            {
                TranscriptMessageType.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptMessageType? ToEnum(string value)
        {
            return value switch
            {
                "transcript" => TranscriptMessageType.Transcript,
                _ => null,
            };
        }
    }
}