//HintName: G.Models.PathwayNode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PathwayNode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Node type (e.g. Default, End Call, Transfer Call, Webhook, Knowledge Base, SMS, Custom Code)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Node-specific configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PathwayNode" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type">
        /// Node type (e.g. Default, End Call, Transfer Call, Webhook, Knowledge Base, SMS, Custom Code)
        /// </param>
        /// <param name="data">
        /// Node-specific configuration
        /// </param>
        public PathwayNode(
            string? id,
            string? type,
            object? data)
        {
            this.Id = id;
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PathwayNode" /> class.
        /// </summary>
        public PathwayNode()
        {
        }
    }
}