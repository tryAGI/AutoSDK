//HintName: G.Models.TranslationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslationStatus
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