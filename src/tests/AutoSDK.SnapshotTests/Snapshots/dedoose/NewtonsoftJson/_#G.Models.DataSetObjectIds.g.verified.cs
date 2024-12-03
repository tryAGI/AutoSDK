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
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedTagIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includedDescriptorIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedDescriptorIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includedResourceIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includedExcerptIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedExcerptIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includedUserIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedUserIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excludedExcerptIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExcludedExcerptIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetObjectIds" /> class.
        /// </summary>
        /// <param name="includedTagIds"></param>
        /// <param name="includedDescriptorIds"></param>
        /// <param name="includedResourceIds"></param>
        /// <param name="includedExcerptIds"></param>
        /// <param name="includedUserIds"></param>
        /// <param name="excludedExcerptIds"></param>
        public DataSetObjectIds(
            global::System.Collections.Generic.IList<global::System.Guid>? includedTagIds,
            global::System.Collections.Generic.IList<global::System.Guid>? includedDescriptorIds,
            global::System.Collections.Generic.IList<global::System.Guid>? includedResourceIds,
            global::System.Collections.Generic.IList<global::System.Guid>? includedExcerptIds,
            global::System.Collections.Generic.IList<global::System.Guid>? includedUserIds,
            global::System.Collections.Generic.IList<global::System.Guid>? excludedExcerptIds)
        {
            this.IncludedTagIds = includedTagIds;
            this.IncludedDescriptorIds = includedDescriptorIds;
            this.IncludedResourceIds = includedResourceIds;
            this.IncludedExcerptIds = includedExcerptIds;
            this.IncludedUserIds = includedUserIds;
            this.ExcludedExcerptIds = excludedExcerptIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetObjectIds" /> class.
        /// </summary>
        public DataSetObjectIds()
        {
        }
    }
}