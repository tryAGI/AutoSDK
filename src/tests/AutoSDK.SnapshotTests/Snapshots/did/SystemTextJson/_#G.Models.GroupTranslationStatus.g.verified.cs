//HintName: G.Models.GroupTranslationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GroupTranslationStatus
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
    public static class GroupTranslationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupTranslationStatus value)
        {
            return value switch
            {
                GroupTranslationStatus.Created => "created",
                GroupTranslationStatus.Done => "done",
                GroupTranslationStatus.Error => "error",
                GroupTranslationStatus.Ready => "ready",
                GroupTranslationStatus.Rejected => "rejected",
                GroupTranslationStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupTranslationStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GroupTranslationStatus.Created,
                "done" => GroupTranslationStatus.Done,
                "error" => GroupTranslationStatus.Error,
                "ready" => GroupTranslationStatus.Ready,
                "rejected" => GroupTranslationStatus.Rejected,
                "validating" => GroupTranslationStatus.Validating,
                _ => null,
            };
        }
    }
}