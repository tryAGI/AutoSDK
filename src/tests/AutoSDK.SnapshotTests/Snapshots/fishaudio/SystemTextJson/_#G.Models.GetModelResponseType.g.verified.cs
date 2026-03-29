//HintName: G.Models.GetModelResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelResponseType
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
    public static class GetModelResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelResponseType value)
        {
            return value switch
            {
                GetModelResponseType.Svc => "svc",
                GetModelResponseType.Tts => "tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelResponseType? ToEnum(string value)
        {
            return value switch
            {
                "svc" => GetModelResponseType.Svc,
                "tts" => GetModelResponseType.Tts,
                _ => null,
            };
        }
    }
}