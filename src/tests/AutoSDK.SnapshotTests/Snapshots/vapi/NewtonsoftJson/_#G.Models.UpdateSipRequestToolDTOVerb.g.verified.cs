//HintName: G.Models.UpdateSipRequestToolDTOVerb.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The SIP method to send.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateSipRequestToolDTOVerb
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INFO")]
        Info,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE")]
        Message,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NOTIFY")]
        Notify,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSipRequestToolDTOVerbExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSipRequestToolDTOVerb value)
        {
            return value switch
            {
                UpdateSipRequestToolDTOVerb.Info => "INFO",
                UpdateSipRequestToolDTOVerb.Message => "MESSAGE",
                UpdateSipRequestToolDTOVerb.Notify => "NOTIFY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSipRequestToolDTOVerb? ToEnum(string value)
        {
            return value switch
            {
                "INFO" => UpdateSipRequestToolDTOVerb.Info,
                "MESSAGE" => UpdateSipRequestToolDTOVerb.Message,
                "NOTIFY" => UpdateSipRequestToolDTOVerb.Notify,
                _ => null,
            };
        }
    }
}