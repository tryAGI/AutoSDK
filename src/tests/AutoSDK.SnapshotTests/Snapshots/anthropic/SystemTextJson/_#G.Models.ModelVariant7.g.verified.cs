//HintName: G.Models.ModelVariant7.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Excels at writing and complex tasks
    /// </summary>
    public enum ModelVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        Claude3OpusLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVariant7 value)
        {
            return value switch
            {
                ModelVariant7.Claude3OpusLatest => "claude-3-opus-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVariant7? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-opus-latest" => ModelVariant7.Claude3OpusLatest,
                _ => null,
            };
        }
    }
}