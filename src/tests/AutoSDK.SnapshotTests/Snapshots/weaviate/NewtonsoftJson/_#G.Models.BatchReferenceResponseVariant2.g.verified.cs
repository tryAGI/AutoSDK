//HintName: G.Models.BatchReferenceResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchReferenceResponseVariant2
    {
        /// <summary>
        /// Results for this specific reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.BatchReferenceResponseVariant2Result? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}