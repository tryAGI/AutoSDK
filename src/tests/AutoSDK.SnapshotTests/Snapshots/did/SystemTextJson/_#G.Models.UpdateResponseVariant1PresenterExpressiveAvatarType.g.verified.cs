//HintName: G.Models.UpdateResponseVariant1PresenterExpressiveAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum UpdateResponseVariant1PresenterExpressiveAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Expressive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateResponseVariant1PresenterExpressiveAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1PresenterExpressiveAvatarType value)
        {
            return value switch
            {
                UpdateResponseVariant1PresenterExpressiveAvatarType.Expressive => "expressive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1PresenterExpressiveAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => UpdateResponseVariant1PresenterExpressiveAvatarType.Expressive,
                _ => null,
            };
        }
    }
}