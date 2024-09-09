//HintName: G.Models.TranscriptStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of your transcript. Possible values are queued, processing, completed, or error.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptStatus value)
        {
            return value switch
            {
                TranscriptStatus.Queued => "queued",
                TranscriptStatus.Processing => "processing",
                TranscriptStatus.Completed => "completed",
                TranscriptStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptStatus? ToEnum(string value)
        {
            return value switch
            {
                "queued" => TranscriptStatus.Queued,
                "processing" => TranscriptStatus.Processing,
                "completed" => TranscriptStatus.Completed,
                "error" => TranscriptStatus.Error,
                _ => null,
            };
        }
    }
}