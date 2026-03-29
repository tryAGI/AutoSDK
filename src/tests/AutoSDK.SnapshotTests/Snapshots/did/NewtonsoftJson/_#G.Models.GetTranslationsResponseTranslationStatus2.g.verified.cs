//HintName: G.Models.GetTranslationsResponseTranslationStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the translation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTranslationsResponseTranslationStatus2
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