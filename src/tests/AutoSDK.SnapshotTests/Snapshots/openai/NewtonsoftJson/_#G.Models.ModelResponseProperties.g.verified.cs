//HintName: G.Models.ModelResponseProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelResponseProperties
    {
        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// We generally recommend altering this or `top_p` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling,<br/>
        /// where the model considers the results of the tokens with top_p probability<br/>
        /// mass. So 0.1 means only the tokens comprising the top 10% probability mass<br/>
        /// are considered.<br/>
        /// We generally recommend altering this or `temperature` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Specifies the latency tier to use for processing the request. This parameter is relevant for customers subscribed to the scale tier service:<br/>
        ///   - If set to 'auto', and the Project is Scale tier enabled, the system<br/>
        ///     will utilize scale tier credits until they are exhausted.<br/>
        ///   - If set to 'auto', and the Project is not Scale tier enabled, the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - If set to 'default', the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - If set to 'flex', the request will be processed with the Flex Processing service tier. [Learn more](/docs/guides/flex-processing).<br/>
        ///   - When not set, the default behavior is 'auto'.<br/>
        ///   When this parameter is set, the response body will include the `service_tier` utilized.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_tier")]
        public global::G.ServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponseProperties" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// We generally recommend altering this or `top_p` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling,<br/>
        /// where the model considers the results of the tokens with top_p probability<br/>
        /// mass. So 0.1 means only the tokens comprising the top 10% probability mass<br/>
        /// are considered.<br/>
        /// We generally recommend altering this or `temperature` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="serviceTier">
        /// Specifies the latency tier to use for processing the request. This parameter is relevant for customers subscribed to the scale tier service:<br/>
        ///   - If set to 'auto', and the Project is Scale tier enabled, the system<br/>
        ///     will utilize scale tier credits until they are exhausted.<br/>
        ///   - If set to 'auto', and the Project is not Scale tier enabled, the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - If set to 'default', the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - If set to 'flex', the request will be processed with the Flex Processing service tier. [Learn more](/docs/guides/flex-processing).<br/>
        ///   - When not set, the default behavior is 'auto'.<br/>
        ///   When this parameter is set, the response body will include the `service_tier` utilized.<br/>
        /// Default Value: auto
        /// </param>
        public ModelResponseProperties(
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            double? temperature,
            double? topP,
            string? user,
            global::G.ServiceTier? serviceTier)
        {
            this.Metadata = metadata;
            this.Temperature = temperature;
            this.TopP = topP;
            this.User = user;
            this.ServiceTier = serviceTier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponseProperties" /> class.
        /// </summary>
        public ModelResponseProperties()
        {
        }
    }
}