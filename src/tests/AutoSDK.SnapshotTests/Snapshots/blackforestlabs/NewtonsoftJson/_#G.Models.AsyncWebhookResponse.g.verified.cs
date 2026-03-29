//HintName: G.Models.AsyncWebhookResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsyncWebhookResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string WebhookUrl { get; set; } = default!;

        /// <summary>
        /// Cost in credits for this request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Input megapixels (2 decimal places)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_mp")]
        public double? InputMp { get; set; }

        /// <summary>
        /// Output megapixels (2 decimal places)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_mp")]
        public double? OutputMp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncWebhookResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="cost">
        /// Cost in credits for this request
        /// </param>
        /// <param name="inputMp">
        /// Input megapixels (2 decimal places)
        /// </param>
        /// <param name="outputMp">
        /// Output megapixels (2 decimal places)
        /// </param>
        public AsyncWebhookResponse(
            string id,
            string status,
            string webhookUrl,
            double? cost,
            double? inputMp,
            double? outputMp)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.Cost = cost;
            this.InputMp = inputMp;
            this.OutputMp = outputMp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncWebhookResponse" /> class.
        /// </summary>
        public AsyncWebhookResponse()
        {
        }
    }
}