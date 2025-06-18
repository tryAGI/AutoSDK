//HintName: G.Models.MCPToolRequireApprovalEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPToolRequireApprovalEnum
    {
        /// <summary>
        /// A list of tools that always require approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("always")]
        public global::G.MCPToolRequireApprovalEnumAlways? Always { get; set; }

        /// <summary>
        /// A list of tools that never require approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("never")]
        public global::G.MCPToolRequireApprovalEnumNever? Never { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolRequireApprovalEnum" /> class.
        /// </summary>
        /// <param name="always">
        /// A list of tools that always require approval.
        /// </param>
        /// <param name="never">
        /// A list of tools that never require approval.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolRequireApprovalEnum(
            global::G.MCPToolRequireApprovalEnumAlways? always,
            global::G.MCPToolRequireApprovalEnumNever? never)
        {
            this.Always = always;
            this.Never = never;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolRequireApprovalEnum" /> class.
        /// </summary>
        public MCPToolRequireApprovalEnum()
        {
        }
    }
}