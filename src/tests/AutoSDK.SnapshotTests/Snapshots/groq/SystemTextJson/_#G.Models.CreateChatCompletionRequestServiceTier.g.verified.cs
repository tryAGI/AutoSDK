//HintName: G.Models.CreateChatCompletionRequestServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The service tier to use for the request. Defaults to `on_demand`.<br/>
    /// - `auto` will automatically select the highest tier available within the rate limits of your organization.<br/>
    /// - `flex` uses the flex tier, which will succeed or fail quickly.
    /// </summary>
    public enum CreateChatCompletionRequestServiceTier
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
    public static class CreateChatCompletionRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestServiceTier value)
        {
            return value switch
            {
                CreateChatCompletionRequestServiceTier.Auto => "auto",
                CreateChatCompletionRequestServiceTier.Flex => "flex",
                CreateChatCompletionRequestServiceTier.OnDemand => "on_demand",
                CreateChatCompletionRequestServiceTier.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                CreateChatCompletionRequestServiceTier.Performance => "performance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateChatCompletionRequestServiceTier.Auto,
                "flex" => CreateChatCompletionRequestServiceTier.Flex,
                "on_demand" => CreateChatCompletionRequestServiceTier.OnDemand,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => CreateChatCompletionRequestServiceTier.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "performance" => CreateChatCompletionRequestServiceTier.Performance,
                _ => null,
            };
        }
    }
}