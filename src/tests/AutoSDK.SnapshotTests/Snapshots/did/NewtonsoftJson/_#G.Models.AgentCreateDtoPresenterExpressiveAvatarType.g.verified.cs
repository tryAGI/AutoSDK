//HintName: G.Models.AgentCreateDtoPresenterExpressiveAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentCreateDtoPresenterExpressiveAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expressive")]
        Expressive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCreateDtoPresenterExpressiveAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoPresenterExpressiveAvatarType value)
        {
            return value switch
            {
                AgentCreateDtoPresenterExpressiveAvatarType.Expressive => "expressive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoPresenterExpressiveAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => AgentCreateDtoPresenterExpressiveAvatarType.Expressive,
                _ => null,
            };
        }
    }
}