//HintName: G.Models.ListResponseConsentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListResponseConsentStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="validating")]
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListResponseConsentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListResponseConsentStatus value)
        {
            return value switch
            {
                ListResponseConsentStatus.Created => "created",
                ListResponseConsentStatus.Done => "done",
                ListResponseConsentStatus.Error => "error",
                ListResponseConsentStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListResponseConsentStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => ListResponseConsentStatus.Created,
                "done" => ListResponseConsentStatus.Done,
                "error" => ListResponseConsentStatus.Error,
                "validating" => ListResponseConsentStatus.Validating,
                _ => null,
            };
        }
    }
}