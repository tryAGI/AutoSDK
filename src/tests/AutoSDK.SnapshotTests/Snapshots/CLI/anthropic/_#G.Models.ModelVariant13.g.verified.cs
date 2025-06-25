//HintName: G.Models.ModelVariant13.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelVariant13
    {
        /// <summary>
        /// 
        /// </summary>
        Claude21,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant13 value)
        {
            return value switch
            {
                ModelVariant13.Claude21 => "claude-2.1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant13? ToEnum(string value)
        {
            return value switch
            {
                "claude-2.1" => ModelVariant13.Claude21,
                _ => null,
            };
        }
    }
}