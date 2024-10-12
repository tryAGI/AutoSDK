//HintName: G.Models.IdentityAnnotationQueueRunStatusCreateSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identity annotation queue run status create schema.
    /// </summary>
    public sealed partial class IdentityAnnotationQueueRunStatusCreateSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("override_added_at")]
        public global::System.DateTime? OverrideAddedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}