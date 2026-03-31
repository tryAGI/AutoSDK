//HintName: G.Models.TranslationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranslationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationStatus value)
        {
            return value switch
            {
                TranslationStatus.Created => "created",
                TranslationStatus.Done => "done",
                TranslationStatus.Error => "error",
                TranslationStatus.Ready => "ready",
                TranslationStatus.Rejected => "rejected",
                TranslationStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => TranslationStatus.Created,
                "done" => TranslationStatus.Done,
                "error" => TranslationStatus.Error,
                "ready" => TranslationStatus.Ready,
                "rejected" => TranslationStatus.Rejected,
                "validating" => TranslationStatus.Validating,
                _ => null,
            };
        }
    }
}