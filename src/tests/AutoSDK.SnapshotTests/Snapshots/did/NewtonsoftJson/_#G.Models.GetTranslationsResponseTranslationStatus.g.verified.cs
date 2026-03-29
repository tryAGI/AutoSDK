//HintName: G.Models.GetTranslationsResponseTranslationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the translation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTranslationsResponseTranslationStatus
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