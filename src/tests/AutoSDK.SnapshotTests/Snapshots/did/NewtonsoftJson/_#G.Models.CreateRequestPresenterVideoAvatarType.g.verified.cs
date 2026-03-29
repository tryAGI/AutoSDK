//HintName: G.Models.CreateRequestPresenterVideoAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRequestPresenterVideoAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip")]
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRequestPresenterVideoAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestPresenterVideoAvatarType value)
        {
            return value switch
            {
                CreateRequestPresenterVideoAvatarType.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestPresenterVideoAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "clip" => CreateRequestPresenterVideoAvatarType.Clip,
                _ => null,
            };
        }
    }
}