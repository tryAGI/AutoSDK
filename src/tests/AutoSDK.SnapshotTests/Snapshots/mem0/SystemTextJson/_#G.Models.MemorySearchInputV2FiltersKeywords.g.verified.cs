//HintName: G.Models.MemorySearchInputV2FiltersKeywords.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemorySearchInputV2FiltersKeywords
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contains")]
        public string? Contains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icontains")]
        public string? Icontains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemorySearchInputV2FiltersKeywords" /> class.
        /// </summary>
        /// <param name="contains"></param>
        /// <param name="icontains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemorySearchInputV2FiltersKeywords(
            string? contains,
            string? icontains)
        {
            this.Contains = contains;
            this.Icontains = icontains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemorySearchInputV2FiltersKeywords" /> class.
        /// </summary>
        public MemorySearchInputV2FiltersKeywords()
        {
        }
    }
}