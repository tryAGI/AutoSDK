//HintName: G.Models.UpdatePresenterAttributesRequestVariant1VoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdatePresenterAttributesRequestVariant1VoiceMicrosoftType
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
    public static class UpdatePresenterAttributesRequestVariant1VoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePresenterAttributesRequestVariant1VoiceMicrosoftType value)
        {
            return value switch
            {
                UpdatePresenterAttributesRequestVariant1VoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePresenterAttributesRequestVariant1VoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => UpdatePresenterAttributesRequestVariant1VoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}