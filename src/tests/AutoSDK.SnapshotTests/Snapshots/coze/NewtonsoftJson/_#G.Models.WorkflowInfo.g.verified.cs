//HintName: G.Models.WorkflowInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowInfo
    {
        /// <summary>
        /// workflow描述
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// workflow图片url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// workflow_id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// workflow名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInfo" /> class.
        /// </summary>
        /// <param name="description">
        /// workflow描述
        /// </param>
        /// <param name="iconUrl">
        /// workflow图片url
        /// </param>
        /// <param name="id">
        /// workflow_id
        /// </param>
        /// <param name="name">
        /// workflow名称
        /// </param>
        public WorkflowInfo(
            string? description,
            string? iconUrl,
            string? id,
            string? name)
        {
            this.Description = description;
            this.IconUrl = iconUrl;
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInfo" /> class.
        /// </summary>
        public WorkflowInfo()
        {
        }
    }
}