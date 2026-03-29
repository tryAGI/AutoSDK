//HintName: G.Models.LanguageIdentificationJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LanguageIdentificationJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageIdentificationJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageIdentificationJobStatus value)
        {
            return value switch
            {
                LanguageIdentificationJobStatus.Completed => "completed",
                LanguageIdentificationJobStatus.Failed => "failed",
                LanguageIdentificationJobStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageIdentificationJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => LanguageIdentificationJobStatus.Completed,
                "failed" => LanguageIdentificationJobStatus.Failed,
                "in_progress" => LanguageIdentificationJobStatus.InProgress,
                _ => null,
            };
        }
    }
}