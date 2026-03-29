//HintName: G.Models.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftType
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
    public static class AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftType value)
        {
            return value switch
            {
                AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => AgentCreateDtoPresenterVideoAvatarVoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}