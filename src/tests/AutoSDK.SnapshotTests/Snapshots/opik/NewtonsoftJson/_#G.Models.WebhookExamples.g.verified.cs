//HintName: G.Models.WebhookExamples.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookExamples
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_examples")]
        public global::System.Collections.Generic.Dictionary<string, object>? ResponseExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookExamples" /> class.
        /// </summary>
        /// <param name="responseExamples"></param>
        public WebhookExamples(
            global::System.Collections.Generic.Dictionary<string, object>? responseExamples)
        {
            this.ResponseExamples = responseExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookExamples" /> class.
        /// </summary>
        public WebhookExamples()
        {
        }
    }
}