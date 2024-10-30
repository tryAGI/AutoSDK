//HintName: G.Models.AppType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AppType represents the type of the app.<br/>
    ///  - APP_TYPE_AI_ASSISTANT: AppType is a AI assistant app.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppType
    {
        /// <summary>
        /// AppType is a AI assistant app.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="APP_TYPE_AI_ASSISTANT")]
        AIASSISTANT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppType value)
        {
            return value switch
            {
                AppType.AIASSISTANT => "APP_TYPE_AI_ASSISTANT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppType? ToEnum(string value)
        {
            return value switch
            {
                "APP_TYPE_AI_ASSISTANT" => AppType.AIASSISTANT,
                _ => null,
            };
        }
    }
}