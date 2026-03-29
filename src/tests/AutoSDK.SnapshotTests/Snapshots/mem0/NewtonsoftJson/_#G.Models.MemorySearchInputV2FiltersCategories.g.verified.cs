//HintName: G.Models.MemorySearchInputV2FiltersCategories.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemorySearchInputV2FiltersCategories
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in")]
        public global::System.Collections.Generic.IList<string>? In { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemorySearchInputV2FiltersCategories" /> class.
        /// </summary>
        /// <param name="in"></param>
        public MemorySearchInputV2FiltersCategories(
            global::System.Collections.Generic.IList<string>? @in)
        {
            this.In = @in;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemorySearchInputV2FiltersCategories" /> class.
        /// </summary>
        public MemorySearchInputV2FiltersCategories()
        {
        }
    }
}