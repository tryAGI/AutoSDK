//HintName: G.Models.AgentPresenterPhotoAvatarType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum AgentPresenterPhotoAvatarType2
    {
        /// <summary>
        /// 
        /// </summary>
        Talk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPresenterPhotoAvatarType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterPhotoAvatarType2 value)
        {
            return value switch
            {
                AgentPresenterPhotoAvatarType2.Talk => "talk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterPhotoAvatarType2? ToEnum(string value)
        {
            return value switch
            {
                "talk" => AgentPresenterPhotoAvatarType2.Talk,
                _ => null,
            };
        }
    }
}