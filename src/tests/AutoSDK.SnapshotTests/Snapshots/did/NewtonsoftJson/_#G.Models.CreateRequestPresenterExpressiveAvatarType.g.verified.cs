//HintName: G.Models.CreateRequestPresenterExpressiveAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRequestPresenterExpressiveAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expressive")]
        Expressive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRequestPresenterExpressiveAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestPresenterExpressiveAvatarType value)
        {
            return value switch
            {
                CreateRequestPresenterExpressiveAvatarType.Expressive => "expressive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestPresenterExpressiveAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => CreateRequestPresenterExpressiveAvatarType.Expressive,
                _ => null,
            };
        }
    }
}