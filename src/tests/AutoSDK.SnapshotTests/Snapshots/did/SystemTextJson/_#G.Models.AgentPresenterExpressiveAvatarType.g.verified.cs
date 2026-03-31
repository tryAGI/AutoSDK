//HintName: G.Models.AgentPresenterExpressiveAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum AgentPresenterExpressiveAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Expressive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPresenterExpressiveAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterExpressiveAvatarType value)
        {
            return value switch
            {
                AgentPresenterExpressiveAvatarType.Expressive => "expressive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterExpressiveAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => AgentPresenterExpressiveAvatarType.Expressive,
                _ => null,
            };
        }
    }
}