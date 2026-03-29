//HintName: G.Models.CreateModelRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model type, tts is for text to speech
    /// </summary>
    public enum CreateModelRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Tts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelRequestType value)
        {
            return value switch
            {
                CreateModelRequestType.Tts => "tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelRequestType? ToEnum(string value)
        {
            return value switch
            {
                "tts" => CreateModelRequestType.Tts,
                _ => null,
            };
        }
    }
}