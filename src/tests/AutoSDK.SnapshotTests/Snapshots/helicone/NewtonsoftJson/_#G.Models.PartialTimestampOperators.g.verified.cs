//HintName: G.Models.PartialTimestampOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialTimestampOperators
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("equals")]
        public string? EqualsValue { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("lt")]
        public string? Lt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gt")]
        public string? Gt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTimestampOperators" /> class.
        /// </summary>
        /// <param name="equalsValue"></param>
        /// <param name="gte"></param>
        /// <param name="lte"></param>
        /// <param name="lt"></param>
        /// <param name="gt"></param>
        public PartialTimestampOperators(
            string? equalsValue,
            string? gte,
            string? lte,
            string? lt,
            string? gt)
        {
            this.EqualsValue = equalsValue;
            this.Gte = gte;
            this.Lte = lte;
            this.Lt = lt;
            this.Gt = gt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTimestampOperators" /> class.
        /// </summary>
        public PartialTimestampOperators()
        {
        }
    }
}