//HintName: G.Models.MemoryGetInputV2Filters2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryGetInputV2Filters2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in")]
        public byte[]? In { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gte")]
        public string? Gte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lte")]
        public string? Lte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gt")]
        public string? Gt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lt")]
        public string? Lt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ne")]
        public string? Ne { get; set; }

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
        /// Initializes a new instance of the <see cref="MemoryGetInputV2Filters2" /> class.
        /// </summary>
        /// <param name="in"></param>
        /// <param name="gte"></param>
        /// <param name="lte"></param>
        /// <param name="gt"></param>
        /// <param name="lt"></param>
        /// <param name="ne"></param>
        /// <param name="contains"></param>
        /// <param name="icontains"></param>
        public MemoryGetInputV2Filters2(
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
        /// Initializes a new instance of the <see cref="MemoryGetInputV2Filters2" /> class.
        /// </summary>
        public MemoryGetInputV2Filters2()
        {
        }
    }
}