//HintName: G.Models.UpdateRequestPresenterPhotoAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateRequestPresenterPhotoAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk")]
        Talk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRequestPresenterPhotoAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRequestPresenterPhotoAvatarType value)
        {
            return value switch
            {
                UpdateRequestPresenterPhotoAvatarType.Talk => "talk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRequestPresenterPhotoAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "talk" => UpdateRequestPresenterPhotoAvatarType.Talk,
                _ => null,
            };
        }
    }
}