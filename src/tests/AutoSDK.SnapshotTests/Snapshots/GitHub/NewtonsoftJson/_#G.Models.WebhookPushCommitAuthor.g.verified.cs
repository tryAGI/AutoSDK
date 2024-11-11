//HintName: G.Models.WebhookPushCommitAuthor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metaproperties for Git author/committer information.
    /// </summary>
    public sealed partial class WebhookPushCommitAuthor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Email { get; set; } = default!;

        /// <summary>
        /// The git author's name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPushCommitAuthor" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="email"></param>
        /// <param name="name">
        /// The git author's name.
        /// </param>
        /// <param name="username"></param>
        public WebhookPushCommitAuthor(
            string? email,
            string name,
            global::System.DateTime? date,
            string? username)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Date = date;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPushCommitAuthor" /> class.
        /// </summary>
        public WebhookPushCommitAuthor()
        {
        }
    }
}