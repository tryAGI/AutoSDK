//HintName: G.Models.AgentCreateDtoPresenterVideoAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum AgentCreateDtoPresenterVideoAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCreateDtoPresenterVideoAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoPresenterVideoAvatarType value)
        {
            return value switch
            {
                AgentCreateDtoPresenterVideoAvatarType.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoPresenterVideoAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "clip" => AgentCreateDtoPresenterVideoAvatarType.Clip,
                _ => null,
            };
        }
    }
}