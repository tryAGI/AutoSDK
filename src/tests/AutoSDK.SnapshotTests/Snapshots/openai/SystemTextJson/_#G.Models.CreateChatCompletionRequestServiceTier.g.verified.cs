//HintName: G.Models.CreateChatCompletionRequestServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the latency tier to use for processing the request. This parameter is relevant for customers subscribed to the scale tier service:<br/>
    ///   - If set to 'auto', and the Project is Scale tier enabled, the system will utilize scale tier credits until they are exhausted.<br/>
    ///   - If set to 'auto', and the Project is not Scale tier enabled, the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
    ///   - If set to 'default', the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
    ///   - When not set, the default behavior is 'auto'.<br/>
    ///   When this parameter is set, the response body will include the `service_tier` utilized.<br/>
    /// Default Value: auto
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
        Default,
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
                CreateChatCompletionRequestServiceTier.Default => "default",
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
                "default" => CreateChatCompletionRequestServiceTier.Default,
                _ => null,
            };
        }
    }
}