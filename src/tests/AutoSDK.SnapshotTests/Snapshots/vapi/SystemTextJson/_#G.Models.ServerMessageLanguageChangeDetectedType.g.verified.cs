//HintName: G.Models.ServerMessageLanguageChangeDetectedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "language-change-detected" is sent when the transcriber is automatically switched based on the detected language.
    /// </summary>
    public enum ServerMessageLanguageChangeDetectedType
    {
        /// <summary>
        /// 
        /// </summary>
        LanguageChangeDetected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageLanguageChangeDetectedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageLanguageChangeDetectedType value)
        {
            return value switch
            {
                ServerMessageLanguageChangeDetectedType.LanguageChangeDetected => "language-change-detected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageLanguageChangeDetectedType? ToEnum(string value)
        {
            return value switch
            {
                "language-change-detected" => ServerMessageLanguageChangeDetectedType.LanguageChangeDetected,
                _ => null,
            };
        }
    }
}