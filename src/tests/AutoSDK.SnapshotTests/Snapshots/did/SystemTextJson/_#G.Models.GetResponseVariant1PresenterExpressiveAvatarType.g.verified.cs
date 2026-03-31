//HintName: G.Models.GetResponseVariant1PresenterExpressiveAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum GetResponseVariant1PresenterExpressiveAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Expressive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetResponseVariant1PresenterExpressiveAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseVariant1PresenterExpressiveAvatarType value)
        {
            return value switch
            {
                GetResponseVariant1PresenterExpressiveAvatarType.Expressive => "expressive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseVariant1PresenterExpressiveAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => GetResponseVariant1PresenterExpressiveAvatarType.Expressive,
                _ => null,
            };
        }
    }
}