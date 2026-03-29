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
        [global::Newtonsoft.Json.JsonProperty("added_acls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Acl> AddedAcls { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("removed_acls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Acl> RemovedAcls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AclBatchUpdateResponse" /> class.
        /// </summary>
        /// <param name="addedAcls"></param>
        /// <param name="removedAcls"></param>
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