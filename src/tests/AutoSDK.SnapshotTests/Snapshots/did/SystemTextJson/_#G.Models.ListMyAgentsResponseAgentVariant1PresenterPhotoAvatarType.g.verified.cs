//HintName: G.Models.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Talk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType.Talk => "talk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "talk" => ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarType.Talk,
                _ => null,
            };
        }
    }
}