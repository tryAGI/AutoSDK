//HintName: G.Models.UltravoxV1CallTemplateInitialOutputMedium.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The medium initially used for calls by default. Defaults to voice.
    /// </summary>
    public enum UltravoxV1CallTemplateInitialOutputMedium
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
    public static class UltravoxV1CallTemplateInitialOutputMediumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1CallTemplateInitialOutputMedium value)
        {
            return value switch
            {
                UltravoxV1CallTemplateInitialOutputMedium.MESSAGEMEDIUMUNSPECIFIED => "MESSAGE_MEDIUM_UNSPECIFIED",
                UltravoxV1CallTemplateInitialOutputMedium.MESSAGEMEDIUMVOICE => "MESSAGE_MEDIUM_VOICE",
                UltravoxV1CallTemplateInitialOutputMedium.MESSAGEMEDIUMTEXT => "MESSAGE_MEDIUM_TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1CallTemplateInitialOutputMedium? ToEnum(string value)
        {
            return value switch
            {
                "MESSAGE_MEDIUM_UNSPECIFIED" => UltravoxV1CallTemplateInitialOutputMedium.MESSAGEMEDIUMUNSPECIFIED,
                "MESSAGE_MEDIUM_VOICE" => UltravoxV1CallTemplateInitialOutputMedium.MESSAGEMEDIUMVOICE,
                "MESSAGE_MEDIUM_TEXT" => UltravoxV1CallTemplateInitialOutputMedium.MESSAGEMEDIUMTEXT,
                _ => null,
            };
        }
    }
}