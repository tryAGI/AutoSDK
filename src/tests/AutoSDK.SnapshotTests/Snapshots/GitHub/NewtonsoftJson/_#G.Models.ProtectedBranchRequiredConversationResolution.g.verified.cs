//HintName: G.Models.ProtectedBranchRequiredConversationResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProtectedBranchRequiredConversationResolution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredConversationResolution" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        public ProtectedBranchRequiredConversationResolution(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredConversationResolution" /> class.
        /// </summary>
        public ProtectedBranchRequiredConversationResolution()
        {
        }
    }
}