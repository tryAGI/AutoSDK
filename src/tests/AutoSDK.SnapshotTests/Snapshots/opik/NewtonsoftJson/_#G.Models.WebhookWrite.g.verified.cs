//HintName: G.Models.WebhookWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_token")]
        public string? SecretToken { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookWrite" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="secretToken"></param>
        /// <param name="headers"></param>
        public WebhookWrite(
            string url,
            global::System.Guid? id,
            string? name,
            string? secretToken,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.Id = id;
            this.Name = name;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.SecretToken = secretToken;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWrite" /> class.
        /// </summary>
        public WebhookWrite()
        {
        }
    }
}