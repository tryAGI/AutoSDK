//HintName: G.Models.ChatReasoningSummaryVerbosityEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatReasoningSummaryVerbosityEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="concise")]
        Concise,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="detailed")]
        Detailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatReasoningSummaryVerbosityEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatReasoningSummaryVerbosityEnum value)
        {
            return value switch
            {
                ChatReasoningSummaryVerbosityEnum.Auto => "auto",
                ChatReasoningSummaryVerbosityEnum.Concise => "concise",
                ChatReasoningSummaryVerbosityEnum.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatReasoningSummaryVerbosityEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatReasoningSummaryVerbosityEnum.Auto,
                "concise" => ChatReasoningSummaryVerbosityEnum.Concise,
                "detailed" => ChatReasoningSummaryVerbosityEnum.Detailed,
                _ => null,
            };
        }
    }
}