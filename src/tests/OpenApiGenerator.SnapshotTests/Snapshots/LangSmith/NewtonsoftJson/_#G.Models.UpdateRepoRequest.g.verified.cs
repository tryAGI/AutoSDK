//HintName: G.Models.UpdateRepoRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Fields to update a repo
    /// </summary>
    public sealed partial class UpdateRepoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::System.AnyOf<string?, object?>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public global::System.AnyOf<string?, object?>? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.AnyOf<global::System.Collections.Generic.IList<string?>?, object?>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_public")]
        public global::System.AnyOf<bool, object?>? IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_archived")]
        public global::System.AnyOf<bool, object?>? IsArchived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}