//HintName: G.Models.ClientMessageLanguageChangeDetectedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "language-change-detected" is sent when the transcriber is automatically switched based on the detected language.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientMessageLanguageChangeDetectedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="language-change-detected")]
        LanguageChangeDetected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageLanguageChangeDetectedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageLanguageChangeDetectedType value)
        {
            return value switch
            {
                ClientMessageLanguageChangeDetectedType.LanguageChangeDetected => "language-change-detected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageLanguageChangeDetectedType? ToEnum(string value)
        {
            return value switch
            {
                "language-change-detected" => ClientMessageLanguageChangeDetectedType.LanguageChangeDetected,
                _ => null,
            };
        }
    }
}