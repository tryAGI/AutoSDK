//HintName: G.Models.PartialNumberOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialNumberOperators
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("not-equals")]
        public double? NotEquals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("equals")]
        public double? EqualsValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gte")]
        public double? Gte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lte")]
        public double? Lte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lt")]
        public double? Lt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gt")]
        public double? Gt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialNumberOperators" /> class.
        /// </summary>
        /// <param name="notEquals"></param>
        /// <param name="equalsValue"></param>
        /// <param name="gte"></param>
        /// <param name="lte"></param>
        /// <param name="lt"></param>
        /// <param name="gt"></param>
        public PartialNumberOperators(
            double? notEquals,
            double? equalsValue,
            double? gte,
            double? lte,
            double? lt,
            double? gt)
        {
            this.NotEquals = notEquals;
            this.EqualsValue = equalsValue;
            this.Gte = gte;
            this.Lte = lte;
            this.Lt = lt;
            this.Gt = gt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialNumberOperators" /> class.
        /// </summary>
        public PartialNumberOperators()
        {
        }
    }
}