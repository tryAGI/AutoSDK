//HintName: G.Models.ProviderApiKeyPagePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderApiKeyPagePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public long? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::G.ProviderApiKeyPublic>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortableBy")]
        public global::System.Collections.Generic.IList<string>? SortableBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderApiKeyPagePublic" /> class.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="total"></param>
        /// <param name="content"></param>
        /// <param name="sortableBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderApiKeyPagePublic(
            int? size,
            long? total,
            global::System.Collections.Generic.IList<global::G.ProviderApiKeyPublic>? content,
            global::System.Collections.Generic.IList<string>? sortableBy)
        {
            this.Size = size;
            this.Total = total;
            this.Content = content;
            this.SortableBy = sortableBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderApiKeyPagePublic" /> class.
        /// </summary>
        public ProviderApiKeyPagePublic()
        {
        }
    }
}