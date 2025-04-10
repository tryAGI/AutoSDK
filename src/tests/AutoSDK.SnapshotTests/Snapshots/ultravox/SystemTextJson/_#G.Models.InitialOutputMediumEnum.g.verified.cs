//HintName: G.Models.InitialOutputMediumEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InitialOutputMediumEnum
    {
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
    public static class InitialOutputMediumEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InitialOutputMediumEnum value)
        {
            return value switch
            {
                InitialOutputMediumEnum.MESSAGEMEDIUMVOICE => "MESSAGE_MEDIUM_VOICE",
                InitialOutputMediumEnum.MESSAGEMEDIUMTEXT => "MESSAGE_MEDIUM_TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InitialOutputMediumEnum? ToEnum(string value)
        {
            return value switch
            {
                "MESSAGE_MEDIUM_VOICE" => InitialOutputMediumEnum.MESSAGEMEDIUMVOICE,
                "MESSAGE_MEDIUM_TEXT" => InitialOutputMediumEnum.MESSAGEMEDIUMTEXT,
                _ => null,
            };
        }
    }
}