//HintName: G.Models.GetGroupResponseTranslationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetGroupResponseTranslationStatus
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
    public static class GetGroupResponseTranslationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetGroupResponseTranslationStatus value)
        {
            return value switch
            {
                GetGroupResponseTranslationStatus.Created => "created",
                GetGroupResponseTranslationStatus.Done => "done",
                GetGroupResponseTranslationStatus.Error => "error",
                GetGroupResponseTranslationStatus.Ready => "ready",
                GetGroupResponseTranslationStatus.Rejected => "rejected",
                GetGroupResponseTranslationStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetGroupResponseTranslationStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetGroupResponseTranslationStatus.Created,
                "done" => GetGroupResponseTranslationStatus.Done,
                "error" => GetGroupResponseTranslationStatus.Error,
                "ready" => GetGroupResponseTranslationStatus.Ready,
                "rejected" => GetGroupResponseTranslationStatus.Rejected,
                "validating" => GetGroupResponseTranslationStatus.Validating,
                _ => null,
            };
        }
    }
}