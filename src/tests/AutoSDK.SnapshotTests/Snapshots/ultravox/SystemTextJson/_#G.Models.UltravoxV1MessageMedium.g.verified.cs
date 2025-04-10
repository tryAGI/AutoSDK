//HintName: G.Models.UltravoxV1MessageMedium.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The medium of the message.
    /// </summary>
    public enum UltravoxV1MessageMedium
    {
        /// <summary>
        /// 
        /// </summary>
        MESSAGEMEDIUMUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        MESSAGEMEDIUMVOICE,
        /// <summary>
        /// 
        /// </summary>
        MESSAGEMEDIUMTEXT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1MessageMediumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1MessageMedium value)
        {
            return value switch
            {
                UltravoxV1MessageMedium.MESSAGEMEDIUMUNSPECIFIED => "MESSAGE_MEDIUM_UNSPECIFIED",
                UltravoxV1MessageMedium.MESSAGEMEDIUMVOICE => "MESSAGE_MEDIUM_VOICE",
                UltravoxV1MessageMedium.MESSAGEMEDIUMTEXT => "MESSAGE_MEDIUM_TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1MessageMedium? ToEnum(string value)
        {
            return value switch
            {
                "MESSAGE_MEDIUM_UNSPECIFIED" => UltravoxV1MessageMedium.MESSAGEMEDIUMUNSPECIFIED,
                "MESSAGE_MEDIUM_VOICE" => UltravoxV1MessageMedium.MESSAGEMEDIUMVOICE,
                "MESSAGE_MEDIUM_TEXT" => UltravoxV1MessageMedium.MESSAGEMEDIUMTEXT,
                _ => null,
            };
        }
    }
}