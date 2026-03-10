//HintName: G.Models.ToolResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolConfig2 ToolConfig { get; set; } = default!;

        /// <summary>
        /// Example: {"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </summary>
        /// <example>{"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}</example>
        [global::Newtonsoft.Json.JsonProperty("access_info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResourceAccessInfo AccessInfo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_stats", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolUsageStatsResponseModel UsageStats { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="toolConfig">
        /// The type of tool
        /// </param>
        /// <param name="accessInfo">
        /// Example: {"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </param>
        /// <param name="usageStats"></param>
        public ToolResponseModel(
            string id,
            global::G.ToolConfig2 toolConfig,
            global::G.ResourceAccessInfo accessInfo,
            global::G.ToolUsageStatsResponseModel usageStats)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ToolConfig = toolConfig;
            this.AccessInfo = accessInfo ?? throw new global::System.ArgumentNullException(nameof(accessInfo));
            this.UsageStats = usageStats ?? throw new global::System.ArgumentNullException(nameof(usageStats));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResponseModel" /> class.
        /// </summary>
        public ToolResponseModel()
        {
        }
    }
}