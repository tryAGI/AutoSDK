//HintName: G.Models.UploadConsentRequestBodyDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadConsentRequestBodyDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadConsentRequestBodyDto" /> class.
        /// </summary>
        /// <param name="sourceUrl"></param>
        /// <param name="name"></param>
        /// <param name="webhook"></param>
        public UploadConsentRequestBodyDto(
            string sourceUrl,
            string name,
            string? webhook)
        {
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Webhook = webhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadConsentRequestBodyDto" /> class.
        /// </summary>
        public UploadConsentRequestBodyDto()
        {
        }
    }
}