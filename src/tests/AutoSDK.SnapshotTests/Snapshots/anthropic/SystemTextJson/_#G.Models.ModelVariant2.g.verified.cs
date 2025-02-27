//HintName: G.Models.ModelVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Our most intelligent model
    /// </summary>
    public enum ModelVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Claude37SonnetLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant2 value)
        {
            return value switch
            {
                ModelVariant2.Claude37SonnetLatest => "claude-3-7-sonnet-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant2? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-7-sonnet-latest" => ModelVariant2.Claude37SonnetLatest,
                _ => null,
            };
        }
    }
}