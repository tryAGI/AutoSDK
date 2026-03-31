//HintName: G.Models.CreateResponseTranslationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the translation
    /// </summary>
    public enum CreateResponseTranslationStatus
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
    public static class CreateResponseTranslationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseTranslationStatus value)
        {
            return value switch
            {
                CreateResponseTranslationStatus.Created => "created",
                CreateResponseTranslationStatus.Done => "done",
                CreateResponseTranslationStatus.Error => "error",
                CreateResponseTranslationStatus.Ready => "ready",
                CreateResponseTranslationStatus.Rejected => "rejected",
                CreateResponseTranslationStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseTranslationStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateResponseTranslationStatus.Created,
                "done" => CreateResponseTranslationStatus.Done,
                "error" => CreateResponseTranslationStatus.Error,
                "ready" => CreateResponseTranslationStatus.Ready,
                "rejected" => CreateResponseTranslationStatus.Rejected,
                "validating" => CreateResponseTranslationStatus.Validating,
                _ => null,
            };
        }
    }
}