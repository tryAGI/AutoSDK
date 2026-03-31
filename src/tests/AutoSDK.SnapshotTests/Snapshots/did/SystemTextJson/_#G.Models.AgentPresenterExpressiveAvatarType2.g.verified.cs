//HintName: G.Models.AgentPresenterExpressiveAvatarType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum AgentPresenterExpressiveAvatarType2
    {
        /// <summary>
        /// 
        /// </summary>
        Expressive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPresenterExpressiveAvatarType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterExpressiveAvatarType2 value)
        {
            return value switch
            {
                AgentPresenterExpressiveAvatarType2.Expressive => "expressive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterExpressiveAvatarType2? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => AgentPresenterExpressiveAvatarType2.Expressive,
                _ => null,
            };
        }
    }
}