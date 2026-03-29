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
        [global::Newtonsoft.Json.JsonProperty("add_acls")]
        public global::System.Collections.Generic.IList<global::G.AclItem>? AddAcls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove_acls")]
        public global::System.Collections.Generic.IList<global::G.AclItem>? RemoveAcls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AclBatchUpdateRequest" /> class.
        /// </summary>
        /// <param name="addAcls"></param>
        /// <param name="removeAcls"></param>
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