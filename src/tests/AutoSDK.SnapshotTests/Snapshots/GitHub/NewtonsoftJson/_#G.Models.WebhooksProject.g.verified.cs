//HintName: G.Models.WebhooksProject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksProject
    {
        /// <summary>
        /// Body of the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columns_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksProjectCreator? Creator { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerUrl { get; set; } = default!;

        /// <summary>
        /// State of the project; either 'open' or 'closed'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksProjectState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksProject" /> class.
        /// </summary>
        /// <param name="body">
        /// Body of the project
        /// </param>
        /// <param name="columnsUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="number"></param>
        /// <param name="ownerUrl"></param>
        /// <param name="state">
        /// State of the project; either 'open' or 'closed'
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        public WebhooksProject(
            string? body,
            string columnsUrl,
            global::System.DateTime createdAt,
            global::G.WebhooksProjectCreator? creator,
            string htmlUrl,
            int id,
            string name,
            string nodeId,
            int number,
            string ownerUrl,
            global::G.WebhooksProjectState state,
            global::System.DateTime updatedAt,
            string url)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.ColumnsUrl = columnsUrl ?? throw new global::System.ArgumentNullException(nameof(columnsUrl));
            this.CreatedAt = createdAt;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Number = number;
            this.OwnerUrl = ownerUrl ?? throw new global::System.ArgumentNullException(nameof(ownerUrl));
            this.State = state;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksProject" /> class.
        /// </summary>
        public WebhooksProject()
        {
        }
    }
}