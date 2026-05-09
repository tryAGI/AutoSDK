//HintName: G.Models.CreateTranscriptionResponseStreamEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTranscriptionResponseStreamEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript.text.delta")]
        TranscriptTextDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript.text.done")]
        TranscriptTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranscriptionResponseStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranscriptionResponseStreamEventDiscriminatorType value)
        {
            return value switch
            {
                CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextDelta => "transcript.text.delta",
                CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextDone => "transcript.text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranscriptionResponseStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "transcript.text.delta" => CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextDelta,
                "transcript.text.done" => CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextDone,
                _ => null,
            };
        }
    }
}