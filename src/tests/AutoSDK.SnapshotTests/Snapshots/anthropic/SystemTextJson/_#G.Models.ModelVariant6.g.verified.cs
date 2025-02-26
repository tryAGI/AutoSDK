//HintName: G.Models.ModelVariant6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Our previous most intelligent model
    /// </summary>
    public enum ModelVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20240620,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant6 value)
        {
            return value switch
            {
                ModelVariant6.Claude35Sonnet20240620 => "claude-3-5-sonnet-20240620",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant6? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-sonnet-20240620" => ModelVariant6.Claude35Sonnet20240620,
                _ => null,
            };
        }
    }
}