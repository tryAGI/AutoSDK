//HintName: G.Models.PartialTimestampOperatorsTyped.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialTimestampOperatorsTyped
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("equals")]
        public global::System.DateTime? EqualsValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gte")]
        public global::System.DateTime? Gte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lte")]
        public global::System.DateTime? Lte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lt")]
        public global::System.DateTime? Lt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gt")]
        public global::System.DateTime? Gt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTimestampOperatorsTyped" /> class.
        /// </summary>
        /// <param name="equalsValue"></param>
        /// <param name="gte"></param>
        /// <param name="lte"></param>
        /// <param name="lt"></param>
        /// <param name="gt"></param>
        public PartialTimestampOperatorsTyped(
            global::System.DateTime? equalsValue,
            global::System.DateTime? gte,
            global::System.DateTime? lte,
            global::System.DateTime? lt,
            global::System.DateTime? gt)
        {
            this.EqualsValue = equalsValue;
            this.Gte = gte;
            this.Lte = lte;
            this.Lt = lt;
            this.Gt = gt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTimestampOperatorsTyped" /> class.
        /// </summary>
        public PartialTimestampOperatorsTyped()
        {
        }
    }
}