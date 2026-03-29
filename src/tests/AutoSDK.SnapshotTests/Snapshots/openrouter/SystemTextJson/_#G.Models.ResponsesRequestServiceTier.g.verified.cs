//HintName: G.Models.ResponsesRequestServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum ResponsesRequestServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Flex,
        /// <summary>
        /// 
        /// </summary>
        Priority,
        /// <summary>
        /// 
        /// </summary>
        Scale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestServiceTier value)
        {
            return value switch
            {
                ResponsesRequestServiceTier.Auto => "auto",
                ResponsesRequestServiceTier.Default => "default",
                ResponsesRequestServiceTier.Flex => "flex",
                ResponsesRequestServiceTier.Priority => "priority",
                ResponsesRequestServiceTier.Scale => "scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsesRequestServiceTier.Auto,
                "default" => ResponsesRequestServiceTier.Default,
                "flex" => ResponsesRequestServiceTier.Flex,
                "priority" => ResponsesRequestServiceTier.Priority,
                "scale" => ResponsesRequestServiceTier.Scale,
                _ => null,
            };
        }
    }
}