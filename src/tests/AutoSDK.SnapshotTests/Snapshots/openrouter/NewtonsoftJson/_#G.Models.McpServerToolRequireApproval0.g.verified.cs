//HintName: G.Models.McpServerToolRequireApproval0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerToolRequireApproval0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("never")]
        public global::G.McpServerToolRequireApprovalOneOf0Never? Never { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("always")]
        public global::G.McpServerToolRequireApprovalOneOf0Always? Always { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolRequireApproval0" /> class.
        /// </summary>
        /// <param name="never"></param>
        /// <param name="always"></param>
        public McpServerToolRequireApproval0(
            global::G.McpServerToolRequireApprovalOneOf0Never? never,
            global::G.McpServerToolRequireApprovalOneOf0Always? always)
        {
            this.Never = never;
            this.Always = always;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolRequireApproval0" /> class.
        /// </summary>
        public McpServerToolRequireApproval0()
        {
        }
    }
}