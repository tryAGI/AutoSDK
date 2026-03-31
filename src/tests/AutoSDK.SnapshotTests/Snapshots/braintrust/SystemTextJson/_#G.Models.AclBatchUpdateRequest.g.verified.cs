//HintName: G.Models.AclBatchUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AclBatchUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_acls")]
        public global::System.Collections.Generic.IList<global::G.AclItem>? AddAcls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_acls")]
        public global::System.Collections.Generic.IList<global::G.AclItem>? RemoveAcls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AclBatchUpdateRequest" /> class.
        /// </summary>
        /// <param name="addAcls"></param>
        /// <param name="removeAcls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AclBatchUpdateRequest(
            global::System.Collections.Generic.IList<global::G.AclItem>? addAcls,
            global::System.Collections.Generic.IList<global::G.AclItem>? removeAcls)
        {
            this.AddAcls = addAcls;
            this.RemoveAcls = removeAcls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AclBatchUpdateRequest" /> class.
        /// </summary>
        public AclBatchUpdateRequest()
        {
        }
    }
}