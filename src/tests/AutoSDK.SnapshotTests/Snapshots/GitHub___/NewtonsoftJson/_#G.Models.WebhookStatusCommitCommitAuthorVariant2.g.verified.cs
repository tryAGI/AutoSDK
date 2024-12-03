//HintName: G.Models.WebhookStatusCommitCommitAuthorVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookStatusCommitCommitAuthorVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date", Required = global::Newtonsoft.Json.Required.Always)]
        public string Date { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommitAuthorVariant2" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="email"></param>
        /// <param name="name"></param>
        public WebhookStatusCommitCommitAuthorVariant2(
            string date,
            string? email,
            string? name)
        {
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.Email = email;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommitAuthorVariant2" /> class.
        /// </summary>
        public WebhookStatusCommitCommitAuthorVariant2()
        {
        }
    }
}