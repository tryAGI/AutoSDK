//HintName: G.Models.MemoryGetInputV2FiltersKeywords.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryGetInputV2FiltersKeywords
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contains")]
        public string? Contains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icontains")]
        public string? Icontains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryGetInputV2FiltersKeywords" /> class.
        /// </summary>
        /// <param name="contains"></param>
        /// <param name="icontains"></param>
        public MemoryGetInputV2FiltersKeywords(
            string? contains,
            string? icontains)
        {
            this.Contains = contains;
            this.Icontains = icontains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryGetInputV2FiltersKeywords" /> class.
        /// </summary>
        public MemoryGetInputV2FiltersKeywords()
        {
        }
    }
}