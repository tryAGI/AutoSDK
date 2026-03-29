//HintName: G.Models.CreateModelResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Svc,
        /// <summary>
        /// 
        /// </summary>
        Tts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelResponseType value)
        {
            return value switch
            {
                CreateModelResponseType.Svc => "svc",
                CreateModelResponseType.Tts => "tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelResponseType? ToEnum(string value)
        {
            return value switch
            {
                "svc" => CreateModelResponseType.Svc,
                "tts" => CreateModelResponseType.Tts,
                _ => null,
            };
        }
    }
}