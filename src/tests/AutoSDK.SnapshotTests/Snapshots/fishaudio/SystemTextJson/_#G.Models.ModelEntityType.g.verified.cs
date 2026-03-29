//HintName: G.Models.ModelEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelEntityType
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
    public static class ModelEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEntityType value)
        {
            return value switch
            {
                ModelEntityType.Svc => "svc",
                ModelEntityType.Tts => "tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEntityType? ToEnum(string value)
        {
            return value switch
            {
                "svc" => ModelEntityType.Svc,
                "tts" => ModelEntityType.Tts,
                _ => null,
            };
        }
    }
}