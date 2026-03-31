//HintName: G.Models.GetGroupResponseTranslationStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetGroupResponseTranslationStatus2
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
    public static class GetGroupResponseTranslationStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetGroupResponseTranslationStatus2 value)
        {
            return value switch
            {
                GetGroupResponseTranslationStatus2.Created => "created",
                GetGroupResponseTranslationStatus2.Done => "done",
                GetGroupResponseTranslationStatus2.Error => "error",
                GetGroupResponseTranslationStatus2.Ready => "ready",
                GetGroupResponseTranslationStatus2.Rejected => "rejected",
                GetGroupResponseTranslationStatus2.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetGroupResponseTranslationStatus2? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetGroupResponseTranslationStatus2.Created,
                "done" => GetGroupResponseTranslationStatus2.Done,
                "error" => GetGroupResponseTranslationStatus2.Error,
                "ready" => GetGroupResponseTranslationStatus2.Ready,
                "rejected" => GetGroupResponseTranslationStatus2.Rejected,
                "validating" => GetGroupResponseTranslationStatus2.Validating,
                _ => null,
            };
        }
    }
}