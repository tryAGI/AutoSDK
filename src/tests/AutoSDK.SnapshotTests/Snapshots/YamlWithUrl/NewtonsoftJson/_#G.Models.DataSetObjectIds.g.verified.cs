//HintName: G.Models.DataSetObjectIds.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataSetObjectIds
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includedTagIds")]
        public global::System.Collections.Generic.IList<string?>? IncludedTagIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includedDescriptorIds")]
        public global::System.Collections.Generic.IList<string?>? IncludedDescriptorIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includedResourceIds")]
        public global::System.Collections.Generic.IList<string?>? IncludedResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includedExcerptIds")]
        public global::System.Collections.Generic.IList<string?>? IncludedExcerptIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includedUserIds")]
        public global::System.Collections.Generic.IList<string?>? IncludedUserIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excludedExcerptIds")]
        public global::System.Collections.Generic.IList<string?>? ExcludedExcerptIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}