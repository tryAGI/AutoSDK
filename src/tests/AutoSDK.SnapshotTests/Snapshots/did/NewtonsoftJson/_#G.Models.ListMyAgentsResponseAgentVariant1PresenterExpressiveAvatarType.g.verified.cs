//HintName: G.Models.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType
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
    public static class ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType.Expressive => "expressive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType.Expressive,
                _ => null,
            };
        }
    }
}