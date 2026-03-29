//HintName: G.Models.ModelUsageUnit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Unit of usage in Langfuse
    /// </summary>
    public enum ModelUsageUnit
    {
        /// <summary>
        /// 
        /// </summary>
        Characters,
        /// <summary>
        /// 
        /// </summary>
        Images,
        /// <summary>
        /// 
        /// </summary>
        Milliseconds,
        /// <summary>
        /// 
        /// </summary>
        Requests,
        /// <summary>
        /// 
        /// </summary>
        Seconds,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelUsageUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelUsageUnit value)
        {
            return value switch
            {
                ModelUsageUnit.Characters => "CHARACTERS",
                ModelUsageUnit.Images => "IMAGES",
                ModelUsageUnit.Milliseconds => "MILLISECONDS",
                ModelUsageUnit.Requests => "REQUESTS",
                ModelUsageUnit.Seconds => "SECONDS",
                ModelUsageUnit.Tokens => "TOKENS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelUsageUnit? ToEnum(string value)
        {
            return value switch
            {
                "CHARACTERS" => ModelUsageUnit.Characters,
                "IMAGES" => ModelUsageUnit.Images,
                "MILLISECONDS" => ModelUsageUnit.Milliseconds,
                "REQUESTS" => ModelUsageUnit.Requests,
                "SECONDS" => ModelUsageUnit.Seconds,
                "TOKENS" => ModelUsageUnit.Tokens,
                _ => null,
            };
        }
    }
}