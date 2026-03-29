//HintName: G.Models.ModifyApprovalRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for modifying tool approval requirements.
    /// </summary>
    public sealed partial class ModifyApprovalRequest
    {
        /// <summary>
        /// Whether the tool requires approval before execution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requires_approval")]
        public bool? RequiresApproval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyApprovalRequest" /> class.
        /// </summary>
        /// <param name="requiresApproval">
        /// Whether the tool requires approval before execution
        /// </param>
        public ModifyApprovalRequest(
            bool? requiresApproval)
        {
            this.RequiresApproval = requiresApproval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyApprovalRequest" /> class.
        /// </summary>
        public ModifyApprovalRequest()
        {
        }
    }
}