//HintName: G.Models.AgentResponseDtoVariant1PresenterExpressiveAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum AgentResponseDtoVariant1PresenterExpressiveAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Expressive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResponseDtoVariant1PresenterExpressiveAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1PresenterExpressiveAvatarType value)
        {
            return value switch
            {
                AgentResponseDtoVariant1PresenterExpressiveAvatarType.Expressive => "expressive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1PresenterExpressiveAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => AgentResponseDtoVariant1PresenterExpressiveAvatarType.Expressive,
                _ => null,
            };
        }
    }
}