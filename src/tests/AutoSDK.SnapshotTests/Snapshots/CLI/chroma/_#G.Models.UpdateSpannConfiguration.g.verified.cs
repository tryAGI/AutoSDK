//HintName: G.Models.UpdateSpannConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSpannConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ef_search")]
        public int? EfSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_nprobe")]
        public int? SearchNprobe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSpannConfiguration" /> class.
        /// </summary>
        /// <param name="efSearch"></param>
        /// <param name="searchNprobe"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSpannConfiguration(
            int? efSearch,
            int? searchNprobe)
        {
            this.EfSearch = efSearch;
            this.SearchNprobe = searchNprobe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSpannConfiguration" /> class.
        /// </summary>
        public UpdateSpannConfiguration()
        {
        }
    }
}