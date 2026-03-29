//HintName: G.Models.TranslationStatusApiItemSuccessStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslationStatusApiItemSuccessStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="complete")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationStatusApiItemSuccessStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationStatusApiItemSuccessStatus value)
        {
            return value switch
            {
                TranslationStatusApiItemSuccessStatus.Complete => "complete",
                TranslationStatusApiItemSuccessStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationStatusApiItemSuccessStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => TranslationStatusApiItemSuccessStatus.Complete,
                "in_progress" => TranslationStatusApiItemSuccessStatus.InProgress,
                _ => null,
            };
        }
    }
}