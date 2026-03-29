//HintName: G.Models.CreateChatCompletionResponseServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The service tier used for the request.
    /// </summary>
    public enum CreateChatCompletionResponseServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Flex,
        /// <summary>
        /// 
        /// </summary>
        OnDemand,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        Performance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionResponseServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionResponseServiceTier value)
        {
            return value switch
            {
                CreateChatCompletionResponseServiceTier.Auto => "auto",
                CreateChatCompletionResponseServiceTier.Flex => "flex",
                CreateChatCompletionResponseServiceTier.OnDemand => "on_demand",
                CreateChatCompletionResponseServiceTier.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                CreateChatCompletionResponseServiceTier.Performance => "performance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionResponseServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateChatCompletionResponseServiceTier.Auto,
                "flex" => CreateChatCompletionResponseServiceTier.Flex,
                "on_demand" => CreateChatCompletionResponseServiceTier.OnDemand,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => CreateChatCompletionResponseServiceTier.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "performance" => CreateChatCompletionResponseServiceTier.Performance,
                _ => null,
            };
        }
    }
}