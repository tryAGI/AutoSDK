//HintName: G.Models.BranchProtectionRequiredConversationResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchProtectionRequiredConversationResolution
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
        /// Initializes a new instance of the <see cref="BranchProtectionRequiredConversationResolution" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        public BranchProtectionRequiredConversationResolution(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtectionRequiredConversationResolution" /> class.
        /// </summary>
        public BranchProtectionRequiredConversationResolution()
        {
        }
    }
}