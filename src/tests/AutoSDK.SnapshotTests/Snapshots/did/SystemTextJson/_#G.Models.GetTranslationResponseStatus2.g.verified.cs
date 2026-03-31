//HintName: G.Models.GetTranslationResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the translation
    /// </summary>
    public enum GetTranslationResponseStatus2
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
    public static class GetTranslationResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTranslationResponseStatus2 value)
        {
            return value switch
            {
                GetTranslationResponseStatus2.Created => "created",
                GetTranslationResponseStatus2.Done => "done",
                GetTranslationResponseStatus2.Error => "error",
                GetTranslationResponseStatus2.Ready => "ready",
                GetTranslationResponseStatus2.Rejected => "rejected",
                GetTranslationResponseStatus2.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTranslationResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetTranslationResponseStatus2.Created,
                "done" => GetTranslationResponseStatus2.Done,
                "error" => GetTranslationResponseStatus2.Error,
                "ready" => GetTranslationResponseStatus2.Ready,
                "rejected" => GetTranslationResponseStatus2.Rejected,
                "validating" => GetTranslationResponseStatus2.Validating,
                _ => null,
            };
        }
    }
}