//HintName: G.Models.AgentPresenterVideoAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentPresenterVideoAvatarType
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
    public static class AgentPresenterVideoAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterVideoAvatarType value)
        {
            return value switch
            {
                AgentPresenterVideoAvatarType.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterVideoAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "clip" => AgentPresenterVideoAvatarType.Clip,
                _ => null,
            };
        }
    }
}