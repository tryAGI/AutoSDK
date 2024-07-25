//HintName: G.Models.AnnotationQueueUpdateSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// AnnotationQueue update schema.
    /// </summary>
    public sealed partial class AnnotationQueueUpdateSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::System.AnyOf<string?, object?>? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::System.AnyOf<string?, object?>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_dataset")]
        public global::System.AnyOf<string?, object?>? DefaultDataset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}