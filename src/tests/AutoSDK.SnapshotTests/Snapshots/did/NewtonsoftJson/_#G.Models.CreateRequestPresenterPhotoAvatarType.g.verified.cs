//HintName: G.Models.CreateRequestPresenterPhotoAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRequestPresenterPhotoAvatarType
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
    public static class CreateRequestPresenterPhotoAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestPresenterPhotoAvatarType value)
        {
            return value switch
            {
                CreateRequestPresenterPhotoAvatarType.Talk => "talk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestPresenterPhotoAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "talk" => CreateRequestPresenterPhotoAvatarType.Talk,
                _ => null,
            };
        }
    }
}