//HintName: G.Models.InitialOutputMediumEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InitialOutputMediumEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_MEDIUM_TEXT")]
        MessageMediumText,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_MEDIUM_VOICE")]
        MessageMediumVoice,
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
                InitialOutputMediumEnum.MessageMediumText => "MESSAGE_MEDIUM_TEXT",
                InitialOutputMediumEnum.MessageMediumVoice => "MESSAGE_MEDIUM_VOICE",
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
                "MESSAGE_MEDIUM_TEXT" => InitialOutputMediumEnum.MessageMediumText,
                "MESSAGE_MEDIUM_VOICE" => InitialOutputMediumEnum.MessageMediumVoice,
                _ => null,
            };
        }
    }
}