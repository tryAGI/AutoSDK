//HintName: G.Models.IssueSearchResultItemLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssueSearchResultItemLabel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueSearchResultItemLabel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="default"></param>
        /// <param name="description"></param>
        public IssueSearchResultItemLabel(
            long? id,
            string? nodeId,
            string? url,
            string? name,
            string? color,
            bool? @default,
            string? description)
        {
            this.Id = id;
            this.NodeId = nodeId;
            this.Url = url;
            this.Name = name;
            this.Color = color;
            this.Default = @default;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueSearchResultItemLabel" /> class.
        /// </summary>
        public IssueSearchResultItemLabel()
        {
        }
    }
}