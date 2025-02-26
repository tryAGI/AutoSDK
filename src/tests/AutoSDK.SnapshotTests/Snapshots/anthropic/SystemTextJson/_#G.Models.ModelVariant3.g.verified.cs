//HintName: G.Models.ModelVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fast and cost-effective model
    /// </summary>
    public enum ModelVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35Haiku20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant3 value)
        {
            return value switch
            {
                ModelVariant3.Claude35Haiku20241022 => "claude-3-5-haiku-20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant3? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-haiku-20241022" => ModelVariant3.Claude35Haiku20241022,
                _ => null,
            };
        }
    }
}