//HintName: G.Models.ModelVariant9.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Excels at writing and complex tasks
    /// </summary>
    public enum ModelVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        Claude3OpusLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant9 value)
        {
            return value switch
            {
                ModelVariant9.Claude3OpusLatest => "claude-3-opus-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant9? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-opus-latest" => ModelVariant9.Claude3OpusLatest,
                _ => null,
            };
        }
    }
}