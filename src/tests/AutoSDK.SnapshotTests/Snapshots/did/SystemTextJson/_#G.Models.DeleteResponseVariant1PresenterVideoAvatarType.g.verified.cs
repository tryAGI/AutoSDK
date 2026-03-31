//HintName: G.Models.DeleteResponseVariant1PresenterVideoAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum DeleteResponseVariant1PresenterVideoAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteResponseVariant1PresenterVideoAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteResponseVariant1PresenterVideoAvatarType value)
        {
            return value switch
            {
                DeleteResponseVariant1PresenterVideoAvatarType.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteResponseVariant1PresenterVideoAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "clip" => DeleteResponseVariant1PresenterVideoAvatarType.Clip,
                _ => null,
            };
        }
    }
}