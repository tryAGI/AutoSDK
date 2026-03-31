//HintName: G.Models.GetTranslationsResponseTranslationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the translation
    /// </summary>
    public enum GetTranslationsResponseTranslationStatus
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
    public static class GetTranslationsResponseTranslationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTranslationsResponseTranslationStatus value)
        {
            return value switch
            {
                GetTranslationsResponseTranslationStatus.Created => "created",
                GetTranslationsResponseTranslationStatus.Done => "done",
                GetTranslationsResponseTranslationStatus.Error => "error",
                GetTranslationsResponseTranslationStatus.Ready => "ready",
                GetTranslationsResponseTranslationStatus.Rejected => "rejected",
                GetTranslationsResponseTranslationStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTranslationsResponseTranslationStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetTranslationsResponseTranslationStatus.Created,
                "done" => GetTranslationsResponseTranslationStatus.Done,
                "error" => GetTranslationsResponseTranslationStatus.Error,
                "ready" => GetTranslationsResponseTranslationStatus.Ready,
                "rejected" => GetTranslationsResponseTranslationStatus.Rejected,
                "validating" => GetTranslationsResponseTranslationStatus.Validating,
                _ => null,
            };
        }
    }
}