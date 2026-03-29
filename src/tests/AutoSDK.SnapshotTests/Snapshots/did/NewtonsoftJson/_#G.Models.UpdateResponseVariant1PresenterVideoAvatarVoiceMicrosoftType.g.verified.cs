//HintName: G.Models.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType
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
    public static class UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType value)
        {
            return value switch
            {
                UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}