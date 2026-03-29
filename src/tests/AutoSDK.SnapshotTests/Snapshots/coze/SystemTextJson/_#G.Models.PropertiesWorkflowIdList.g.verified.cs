//HintName: G.Models.PropertiesWorkflowIdList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesWorkflowIdList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<global::G.PropertiesWorkflowIdListPropertiesIdsItems>? Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesWorkflowIdList" /> class.
        /// </summary>
        /// <param name="ids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesWorkflowIdList(
            global::System.Collections.Generic.IList<global::G.PropertiesWorkflowIdListPropertiesIdsItems>? ids)
        {
            this.Ids = ids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesWorkflowIdList" /> class.
        /// </summary>
        public PropertiesWorkflowIdList()
        {
        }
    }
}