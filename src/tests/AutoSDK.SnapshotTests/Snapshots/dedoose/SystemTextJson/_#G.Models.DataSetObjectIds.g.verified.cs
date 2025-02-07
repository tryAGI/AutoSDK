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
        [global::System.Text.Json.Serialization.JsonPropertyName("includedTagIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedTagIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includedDescriptorIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedDescriptorIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includedResourceIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includedExcerptIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedExcerptIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includedUserIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? IncludedUserIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludedExcerptIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExcludedExcerptIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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