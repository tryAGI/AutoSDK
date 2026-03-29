//HintName: G.Models.GetGroupResponseTranslationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetGroupResponseTranslationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ready")]
        Ready,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validating")]
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