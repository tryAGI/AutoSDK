//HintName: G.Models.PorterAuthor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Porter Author
    /// </summary>
    public sealed partial class PorterAuthor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remote_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RemoteId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remote_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string RemoteName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("import_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImportUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PorterAuthor" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="remoteId"></param>
        /// <param name="remoteName"></param>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="importUrl"></param>
        public PorterAuthor(
            int id,
            string remoteId,
            string remoteName,
            string email,
            string name,
            string url,
            string importUrl)
        {
            this.Id = id;
            this.RemoteId = remoteId ?? throw new global::System.ArgumentNullException(nameof(remoteId));
            this.RemoteName = remoteName ?? throw new global::System.ArgumentNullException(nameof(remoteName));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ImportUrl = importUrl ?? throw new global::System.ArgumentNullException(nameof(importUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PorterAuthor" /> class.
        /// </summary>
        public PorterAuthor()
        {
        }
    }
}