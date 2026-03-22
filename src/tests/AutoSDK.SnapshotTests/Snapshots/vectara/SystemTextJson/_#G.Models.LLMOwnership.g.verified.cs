//HintName: G.Models.LLMOwnership.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates whether the LLM is provided by the platform or created by the customer. Platform LLMs are pre-configured and cannot be modified or deleted. Customer LLMs are created and managed by the customer.<br/>
    /// Example: platform
    /// </summary>
    public enum LLMOwnership
    {
        /// <summary>
        /// 
        /// </summary>
        Customer,
        /// <summary>
        /// 
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMOwnershipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMOwnership value)
        {
            return value switch
            {
                LLMOwnership.Customer => "customer",
                LLMOwnership.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMOwnership? ToEnum(string value)
        {
            return value switch
            {
                "customer" => LLMOwnership.Customer,
                "platform" => LLMOwnership.Platform,
                _ => null,
            };
        }
    }
}