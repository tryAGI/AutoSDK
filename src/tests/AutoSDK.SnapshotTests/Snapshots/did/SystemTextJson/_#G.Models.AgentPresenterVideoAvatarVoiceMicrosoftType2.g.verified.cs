//HintName: G.Models.AgentPresenterVideoAvatarVoiceMicrosoftType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentPresenterVideoAvatarVoiceMicrosoftType2
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPresenterVideoAvatarVoiceMicrosoftType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterVideoAvatarVoiceMicrosoftType2 value)
        {
            return value switch
            {
                AgentPresenterVideoAvatarVoiceMicrosoftType2.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterVideoAvatarVoiceMicrosoftType2? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => AgentPresenterVideoAvatarVoiceMicrosoftType2.Microsoft,
                _ => null,
            };
        }
    }
}