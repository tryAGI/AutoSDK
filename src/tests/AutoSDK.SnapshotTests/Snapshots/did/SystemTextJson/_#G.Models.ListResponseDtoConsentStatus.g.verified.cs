//HintName: G.Models.ListResponseDtoConsentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListResponseDtoConsentStatus
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
    public static class ListResponseDtoConsentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListResponseDtoConsentStatus value)
        {
            return value switch
            {
                ListResponseDtoConsentStatus.Created => "created",
                ListResponseDtoConsentStatus.Done => "done",
                ListResponseDtoConsentStatus.Error => "error",
                ListResponseDtoConsentStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListResponseDtoConsentStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => ListResponseDtoConsentStatus.Created,
                "done" => ListResponseDtoConsentStatus.Done,
                "error" => ListResponseDtoConsentStatus.Error,
                "validating" => ListResponseDtoConsentStatus.Validating,
                _ => null,
            };
        }
    }
}