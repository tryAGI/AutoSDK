//HintName: G.Models.CreateConfigRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefault")]
        public int? IsDefault { get; set; }

        /// <summary>
        /// optional, when using organisation admin API keys
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConfigRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="config"></param>
        /// <param name="isDefault"></param>
        /// <param name="workspaceId">
        /// optional, when using organisation admin API keys
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConfigRequest(
            string? name,
            object? config,
            int? isDefault,
            global::System.Guid? workspaceId)
        {
            this.Name = name;
            this.Config = config;
            this.IsDefault = isDefault;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConfigRequest" /> class.
        /// </summary>
        public CreateConfigRequest()
        {
        }
    }
}