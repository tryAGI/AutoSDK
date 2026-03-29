//HintName: G.Models.CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="microsoft")]
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRequestPresenterExpressiveAvatarVoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType value)
        {
            return value switch
            {
                CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => CreateRequestPresenterExpressiveAvatarVoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}