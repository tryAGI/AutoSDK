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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolConfig2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolConfig2 ToolConfig { get; set; }

        /// <summary>
        /// Example: {"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </summary>
        /// <example>{"creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResourceAccessInfo AccessInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolUsageStatsResponseModel UsageStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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