//HintName: G.Models.BodyCloneDatasetApiV1DatasetsClonePost.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCloneDatasetApiV1DatasetsClonePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TargetDatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SourceDatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("as_of")]
        public global::G.AnyOf<global::G.AnyOf<global::System.DateTime?, string>?, object>? AsOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("examples")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}