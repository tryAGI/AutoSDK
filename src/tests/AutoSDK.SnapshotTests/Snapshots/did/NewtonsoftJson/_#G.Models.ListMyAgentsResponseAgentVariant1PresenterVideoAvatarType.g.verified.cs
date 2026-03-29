//HintName: G.Models.ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType
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
    public static class ListMyAgentsResponseAgentVariant1PresenterVideoAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "clip" => ListMyAgentsResponseAgentVariant1PresenterVideoAvatarType.Clip,
                _ => null,
            };
        }
    }
}