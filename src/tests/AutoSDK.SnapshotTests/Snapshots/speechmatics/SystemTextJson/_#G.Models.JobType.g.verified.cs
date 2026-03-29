//HintName: G.Models.JobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobType
    {
        /// <summary>
        /// 
        /// </summary>
        Alignment,
        /// <summary>
        /// 
        /// </summary>
        Transcription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobType value)
        {
            return value switch
            {
                JobType.Alignment => "alignment",
                JobType.Transcription => "transcription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobType? ToEnum(string value)
        {
            return value switch
            {
                "alignment" => JobType.Alignment,
                "transcription" => JobType.Transcription,
                _ => null,
            };
        }
    }
}