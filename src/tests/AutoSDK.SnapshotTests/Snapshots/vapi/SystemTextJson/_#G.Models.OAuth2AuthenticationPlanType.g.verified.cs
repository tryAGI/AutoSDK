//HintName: G.Models.OAuth2AuthenticationPlanType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OAuth2AuthenticationPlanType
    {
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuth2AuthenticationPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuth2AuthenticationPlanType value)
        {
            return value switch
            {
                OAuth2AuthenticationPlanType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuth2AuthenticationPlanType? ToEnum(string value)
        {
            return value switch
            {
                "oauth2" => OAuth2AuthenticationPlanType.Oauth2,
                _ => null,
            };
        }
    }
}