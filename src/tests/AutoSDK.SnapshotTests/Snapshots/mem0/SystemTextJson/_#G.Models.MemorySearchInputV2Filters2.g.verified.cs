//HintName: G.Models.MemorySearchInputV2Filters2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemorySearchInputV2Filters2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in")]
        public byte[]? In { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gte")]
        public string? Gte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lte")]
        public string? Lte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gt")]
        public string? Gt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lt")]
        public string? Lt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ne")]
        public string? Ne { get; set; }

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
        /// Initializes a new instance of the <see cref="MemorySearchInputV2Filters2" /> class.
        /// </summary>
        /// <param name="in"></param>
        /// <param name="gte"></param>
        /// <param name="lte"></param>
        /// <param name="gt"></param>
        /// <param name="lt"></param>
        /// <param name="ne"></param>
        /// <param name="contains"></param>
        /// <param name="icontains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemorySearchInputV2Filters2(
            byte[]? @in,
            string? gte,
            string? lte,
            string? gt,
            string? lt,
            string? ne,
            string? contains,
            string? icontains)
        {
            this.In = @in;
            this.Gte = gte;
            this.Lte = lte;
            this.Gt = gt;
            this.Lt = lt;
            this.Ne = ne;
            this.Contains = contains;
            this.Icontains = icontains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemorySearchInputV2Filters2" /> class.
        /// </summary>
        public MemorySearchInputV2Filters2()
        {
        }
    }
}