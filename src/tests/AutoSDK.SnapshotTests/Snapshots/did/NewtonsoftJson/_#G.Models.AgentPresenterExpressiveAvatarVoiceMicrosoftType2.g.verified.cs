//HintName: G.Models.AgentPresenterExpressiveAvatarVoiceMicrosoftType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentPresenterExpressiveAvatarVoiceMicrosoftType2
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
    public static class AgentPresenterExpressiveAvatarVoiceMicrosoftType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterExpressiveAvatarVoiceMicrosoftType2 value)
        {
            return value switch
            {
                AgentPresenterExpressiveAvatarVoiceMicrosoftType2.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterExpressiveAvatarVoiceMicrosoftType2? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => AgentPresenterExpressiveAvatarVoiceMicrosoftType2.Microsoft,
                _ => null,
            };
        }
    }
}