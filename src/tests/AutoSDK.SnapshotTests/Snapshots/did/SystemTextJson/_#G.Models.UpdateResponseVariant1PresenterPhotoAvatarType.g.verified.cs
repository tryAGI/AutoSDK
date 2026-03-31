//HintName: G.Models.UpdateResponseVariant1PresenterPhotoAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum UpdateResponseVariant1PresenterPhotoAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Talk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateResponseVariant1PresenterPhotoAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1PresenterPhotoAvatarType value)
        {
            return value switch
            {
                UpdateResponseVariant1PresenterPhotoAvatarType.Talk => "talk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1PresenterPhotoAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "talk" => UpdateResponseVariant1PresenterPhotoAvatarType.Talk,
                _ => null,
            };
        }
    }
}