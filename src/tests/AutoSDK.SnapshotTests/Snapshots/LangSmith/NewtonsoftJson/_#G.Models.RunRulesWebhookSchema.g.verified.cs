//HintName: G.Models.RunRulesWebhookSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunRulesWebhookSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunRulesWebhookSchema" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="headers"></param>
        public RunRulesWebhookSchema(
            string url,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunRulesWebhookSchema" /> class.
        /// </summary>
        public RunRulesWebhookSchema()
        {
        }
    }
}