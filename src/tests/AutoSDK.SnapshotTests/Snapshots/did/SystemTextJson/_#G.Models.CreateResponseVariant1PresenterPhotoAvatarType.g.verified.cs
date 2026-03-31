//HintName: G.Models.CreateResponseVariant1PresenterPhotoAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum CreateResponseVariant1PresenterPhotoAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Talk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseVariant1PresenterPhotoAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1PresenterPhotoAvatarType value)
        {
            return value switch
            {
                CreateResponseVariant1PresenterPhotoAvatarType.Talk => "talk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1PresenterPhotoAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "talk" => CreateResponseVariant1PresenterPhotoAvatarType.Talk,
                _ => null,
            };
        }
    }
}