//HintName: G.Models.GetTranslationsResponseTranslationStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the translation
    /// </summary>
    public enum GetTranslationsResponseTranslationStatus2
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
    public static class GetTranslationsResponseTranslationStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTranslationsResponseTranslationStatus2 value)
        {
            return value switch
            {
                GetTranslationsResponseTranslationStatus2.Created => "created",
                GetTranslationsResponseTranslationStatus2.Done => "done",
                GetTranslationsResponseTranslationStatus2.Error => "error",
                GetTranslationsResponseTranslationStatus2.Ready => "ready",
                GetTranslationsResponseTranslationStatus2.Rejected => "rejected",
                GetTranslationsResponseTranslationStatus2.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTranslationsResponseTranslationStatus2? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetTranslationsResponseTranslationStatus2.Created,
                "done" => GetTranslationsResponseTranslationStatus2.Done,
                "error" => GetTranslationsResponseTranslationStatus2.Error,
                "ready" => GetTranslationsResponseTranslationStatus2.Ready,
                "rejected" => GetTranslationsResponseTranslationStatus2.Rejected,
                "validating" => GetTranslationsResponseTranslationStatus2.Validating,
                _ => null,
            };
        }
    }
}