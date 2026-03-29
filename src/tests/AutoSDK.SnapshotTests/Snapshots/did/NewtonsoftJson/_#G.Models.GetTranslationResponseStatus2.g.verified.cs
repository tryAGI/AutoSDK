//HintName: G.Models.GetTranslationResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the translation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTranslationResponseStatus2
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