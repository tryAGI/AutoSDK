//HintName: G.Models.AgentPresenterVideoAvatarType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentPresenterVideoAvatarType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip")]
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPresenterVideoAvatarType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterVideoAvatarType2 value)
        {
            return value switch
            {
                AgentPresenterVideoAvatarType2.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterVideoAvatarType2? ToEnum(string value)
        {
            return value switch
            {
                "clip" => AgentPresenterVideoAvatarType2.Clip,
                _ => null,
            };
        }
    }
}