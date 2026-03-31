//HintName: G.Models.PartialAgentPresenterVideoAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum PartialAgentPresenterVideoAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PartialAgentPresenterVideoAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialAgentPresenterVideoAvatarType value)
        {
            return value switch
            {
                PartialAgentPresenterVideoAvatarType.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialAgentPresenterVideoAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "clip" => PartialAgentPresenterVideoAvatarType.Clip,
                _ => null,
            };
        }
    }
}