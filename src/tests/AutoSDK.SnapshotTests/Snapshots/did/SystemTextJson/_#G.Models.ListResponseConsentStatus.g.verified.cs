//HintName: G.Models.ListResponseConsentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListResponseConsentStatus
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