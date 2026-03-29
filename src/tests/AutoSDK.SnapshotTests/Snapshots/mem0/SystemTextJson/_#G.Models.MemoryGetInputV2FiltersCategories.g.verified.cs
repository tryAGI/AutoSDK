//HintName: G.Models.MemoryGetInputV2FiltersCategories.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryGetInputV2FiltersCategories
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in")]
        public global::System.Collections.Generic.IList<string>? In { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryGetInputV2FiltersCategories" /> class.
        /// </summary>
        /// <param name="in"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoryGetInputV2FiltersCategories(
            global::System.Collections.Generic.IList<string>? @in)
        {
            this.In = @in;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryGetInputV2FiltersCategories" /> class.
        /// </summary>
        public MemoryGetInputV2FiltersCategories()
        {
        }
    }
}