//HintName: G.Models.AgentPresenterPhotoAvatarVoiceMicrosoftType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentPresenterPhotoAvatarVoiceMicrosoftType2
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
    public static class AgentPresenterPhotoAvatarVoiceMicrosoftType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterPhotoAvatarVoiceMicrosoftType2 value)
        {
            return value switch
            {
                AgentPresenterPhotoAvatarVoiceMicrosoftType2.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterPhotoAvatarVoiceMicrosoftType2? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => AgentPresenterPhotoAvatarVoiceMicrosoftType2.Microsoft,
                _ => null,
            };
        }
    }
}