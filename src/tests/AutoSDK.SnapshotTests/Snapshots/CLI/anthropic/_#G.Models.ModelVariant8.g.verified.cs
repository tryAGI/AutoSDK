//HintName: G.Models.ModelVariant8.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20240620,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant8 value)
        {
            return value switch
            {
                ModelVariant8.Claude35Sonnet20240620 => "claude-3-5-sonnet-20240620",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant8? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-sonnet-20240620" => ModelVariant8.Claude35Sonnet20240620,
                _ => null,
            };
        }
    }
}