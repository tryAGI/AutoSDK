//HintName: G.Models.ChatCompletionServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the processing type used for serving the request.<br/>
    /// - If set to 'auto', then the request will be processed with the service tier<br/>
    ///   configured in the Project settings. Unless otherwise configured, the Project<br/>
    ///   will use 'default'.<br/>
    /// - If set to 'default', then the request will be processed with the standard<br/>
    ///   pricing and performance for the selected model.<br/>
    /// - If set to '[flex](https://platform.openai.com/docs/guides/flex-processing)' or<br/>
    ///   'priority', then the request will be processed with the corresponding service<br/>
    ///   tier. [Contact sales](https://openai.com/contact-sales) to learn more about<br/>
    ///   Priority processing.<br/>
    /// - When not set, the default behavior is 'auto'.<br/>
    /// When the `service_tier` parameter is set, the response body will include the<br/>
    /// `service_tier` value based on the processing mode actually used to serve the<br/>
    /// request. This response value may be different from the value set in the<br/>
    /// parameter.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// //platform.openai.com/docs/guides/flex-processing)' or
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flex")]
        Flex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="priority")]
        Priority,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scale")]
        Scale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionServiceTier value)
        {
            return value switch
            {
                ChatCompletionServiceTier.Auto => "auto",
                ChatCompletionServiceTier.Default => "default",
                ChatCompletionServiceTier.Flex => "flex",
                ChatCompletionServiceTier.Priority => "priority",
                ChatCompletionServiceTier.Scale => "scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionServiceTier.Auto,
                "default" => ChatCompletionServiceTier.Default,
                "flex" => ChatCompletionServiceTier.Flex,
                "priority" => ChatCompletionServiceTier.Priority,
                "scale" => ChatCompletionServiceTier.Scale,
                _ => null,
            };
        }
    }
}