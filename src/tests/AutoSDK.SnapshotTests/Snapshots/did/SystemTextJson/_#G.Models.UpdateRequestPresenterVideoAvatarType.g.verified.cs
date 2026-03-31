//HintName: G.Models.UpdateRequestPresenterVideoAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    public enum UpdateRequestPresenterVideoAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRequestPresenterVideoAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRequestPresenterVideoAvatarType value)
        {
            return value switch
            {
                UpdateRequestPresenterVideoAvatarType.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRequestPresenterVideoAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "clip" => UpdateRequestPresenterVideoAvatarType.Clip,
                _ => null,
            };
        }
    }
}