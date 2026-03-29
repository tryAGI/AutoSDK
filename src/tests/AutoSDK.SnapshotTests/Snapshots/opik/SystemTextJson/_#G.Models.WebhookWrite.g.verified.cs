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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_token")]
        public string? SecretToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWrite" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="secretToken"></param>
        /// <param name="headers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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