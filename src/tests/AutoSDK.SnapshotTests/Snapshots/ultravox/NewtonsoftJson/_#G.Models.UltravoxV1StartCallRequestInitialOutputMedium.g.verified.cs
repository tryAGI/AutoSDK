//HintName: G.Models.UltravoxV1StartCallRequestInitialOutputMedium.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The medium to use for the call initially. May be altered by the client later.<br/>
    ///  Defaults to voice.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UltravoxV1StartCallRequestInitialOutputMedium
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_MEDIUM_UNSPECIFIED")]
        MESSAGEMEDIUMUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_MEDIUM_VOICE")]
        MESSAGEMEDIUMVOICE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_MEDIUM_TEXT")]
        MESSAGEMEDIUMTEXT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1StartCallRequestInitialOutputMediumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1StartCallRequestInitialOutputMedium value)
        {
            return value switch
            {
                UltravoxV1StartCallRequestInitialOutputMedium.MESSAGEMEDIUMUNSPECIFIED => "MESSAGE_MEDIUM_UNSPECIFIED",
                UltravoxV1StartCallRequestInitialOutputMedium.MESSAGEMEDIUMVOICE => "MESSAGE_MEDIUM_VOICE",
                UltravoxV1StartCallRequestInitialOutputMedium.MESSAGEMEDIUMTEXT => "MESSAGE_MEDIUM_TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1StartCallRequestInitialOutputMedium? ToEnum(string value)
        {
            return value switch
            {
                "MESSAGE_MEDIUM_UNSPECIFIED" => UltravoxV1StartCallRequestInitialOutputMedium.MESSAGEMEDIUMUNSPECIFIED,
                "MESSAGE_MEDIUM_VOICE" => UltravoxV1StartCallRequestInitialOutputMedium.MESSAGEMEDIUMVOICE,
                "MESSAGE_MEDIUM_TEXT" => UltravoxV1StartCallRequestInitialOutputMedium.MESSAGEMEDIUMTEXT,
                _ => null,
            };
        }
    }
}