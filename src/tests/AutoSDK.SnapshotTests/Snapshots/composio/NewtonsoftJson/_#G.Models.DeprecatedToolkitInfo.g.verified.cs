//HintName: G.Models.DeprecatedToolkitInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated toolkit ID<br/>
    /// Example: {"toolkitId":"550e8400-e29b-41d4-a716-446655440000"}
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class DeprecatedToolkitInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkitId", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string ToolkitId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeprecatedToolkitInfo" /> class.
        /// </summary>
        /// <param name="toolkitId"></param>
        public DeprecatedToolkitInfo(
            string toolkitId)
        {
            this.ToolkitId = toolkitId ?? throw new global::System.ArgumentNullException(nameof(toolkitId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeprecatedToolkitInfo" /> class.
        /// </summary>
        public DeprecatedToolkitInfo()
        {
        }
    }
}