//HintName: G.Models.AclBatchUpdateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AclBatchUpdateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_acls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Acl> AddedAcls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed_acls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Acl> RemovedAcls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AclBatchUpdateResponse" /> class.
        /// </summary>
        /// <param name="addedAcls"></param>
        /// <param name="removedAcls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AclBatchUpdateResponse(
            global::System.Collections.Generic.IList<global::G.Acl> addedAcls,
            global::System.Collections.Generic.IList<global::G.Acl> removedAcls)
        {
            this.AddedAcls = addedAcls ?? throw new global::System.ArgumentNullException(nameof(addedAcls));
            this.RemovedAcls = removedAcls ?? throw new global::System.ArgumentNullException(nameof(removedAcls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AclBatchUpdateResponse" /> class.
        /// </summary>
        public AclBatchUpdateResponse()
        {
        }
    }
}