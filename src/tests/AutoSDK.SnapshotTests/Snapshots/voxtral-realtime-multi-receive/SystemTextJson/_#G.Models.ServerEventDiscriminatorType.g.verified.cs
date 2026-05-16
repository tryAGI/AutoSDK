//HintName: G.Models.ServerEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
        /// <summary>
        /// 
        /// </summary>
        TranscriptionLanguage,
        /// <summary>
        /// 
        /// </summary>
        TranscriptionTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ServerEventDiscriminatorType.Error => "error",
                ServerEventDiscriminatorType.SessionCreated => "session.created",
                ServerEventDiscriminatorType.TranscriptionLanguage => "transcription.language",
                ServerEventDiscriminatorType.TranscriptionTextDelta => "transcription.text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ServerEventDiscriminatorType.Error,
                "session.created" => ServerEventDiscriminatorType.SessionCreated,
                "transcription.language" => ServerEventDiscriminatorType.TranscriptionLanguage,
                "transcription.text.delta" => ServerEventDiscriminatorType.TranscriptionTextDelta,
                _ => null,
            };
        }
    }
}