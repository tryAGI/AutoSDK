//HintName: G.Models.AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="microsoft")]
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftType value)
        {
            return value switch
            {
                AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => AgentResponseDtoVariant1PresenterVideoAvatarVoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}