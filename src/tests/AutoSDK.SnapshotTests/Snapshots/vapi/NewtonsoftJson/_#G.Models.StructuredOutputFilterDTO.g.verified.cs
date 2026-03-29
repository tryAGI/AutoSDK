//HintName: G.Models.StructuredOutputFilterDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredOutputFilterDTO
    {
        /// <summary>
        /// Equal to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eq")]
        public string? Eq { get; set; }

        /// <summary>
        /// Not equal to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("neq")]
        public string? Neq { get; set; }

        /// <summary>
        /// Greater than
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gt")]
        public string? Gt { get; set; }

        /// <summary>
        /// Greater than or equal to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gte")]
        public string? Gte { get; set; }

        /// <summary>
        /// Less than
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lt")]
        public string? Lt { get; set; }

        /// <summary>
        /// Less than or equal to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lte")]
        public string? Lte { get; set; }

        /// <summary>
        /// Contains
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contains")]
        public string? Contains { get; set; }

        /// <summary>
        /// Not contains
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notContains")]
        public string? NotContains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputFilterDTO" /> class.
        /// </summary>
        /// <param name="eq">
        /// Equal to
        /// </param>
        /// <param name="neq">
        /// Not equal to
        /// </param>
        /// <param name="gt">
        /// Greater than
        /// </param>
        /// <param name="gte">
        /// Greater than or equal to
        /// </param>
        /// <param name="lt">
        /// Less than
        /// </param>
        /// <param name="lte">
        /// Less than or equal to
        /// </param>
        /// <param name="contains">
        /// Contains
        /// </param>
        /// <param name="notContains">
        /// Not contains
        /// </param>
        public StructuredOutputFilterDTO(
            string? eq,
            string? neq,
            string? gt,
            string? gte,
            string? lt,
            string? lte,
            string? contains,
            string? notContains)
        {
            this.Eq = eq;
            this.Neq = neq;
            this.Gt = gt;
            this.Gte = gte;
            this.Lt = lt;
            this.Lte = lte;
            this.Contains = contains;
            this.NotContains = notContains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputFilterDTO" /> class.
        /// </summary>
        public StructuredOutputFilterDTO()
        {
        }
    }
}