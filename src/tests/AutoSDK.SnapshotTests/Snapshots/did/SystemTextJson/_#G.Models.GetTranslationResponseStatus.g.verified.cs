//HintName: G.Models.GetTranslationResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the translation
    /// </summary>
    public enum GetTranslationResponseStatus
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
    public static class GetTranslationResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTranslationResponseStatus value)
        {
            return value switch
            {
                GetTranslationResponseStatus.Created => "created",
                GetTranslationResponseStatus.Done => "done",
                GetTranslationResponseStatus.Error => "error",
                GetTranslationResponseStatus.Ready => "ready",
                GetTranslationResponseStatus.Rejected => "rejected",
                GetTranslationResponseStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTranslationResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetTranslationResponseStatus.Created,
                "done" => GetTranslationResponseStatus.Done,
                "error" => GetTranslationResponseStatus.Error,
                "ready" => GetTranslationResponseStatus.Ready,
                "rejected" => GetTranslationResponseStatus.Rejected,
                "validating" => GetTranslationResponseStatus.Validating,
                _ => null,
            };
        }
    }
}