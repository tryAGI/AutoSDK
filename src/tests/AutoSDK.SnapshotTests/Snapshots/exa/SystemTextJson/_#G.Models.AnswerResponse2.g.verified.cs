//HintName: G.Models.AnswerResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnswerResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        public global::G.CostDollars? CostDollars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResponse2" /> class.
        /// </summary>
        /// <param name="costDollars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerResponse2(
            global::G.CostDollars? costDollars)
        {
            this.CostDollars = costDollars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResponse2" /> class.
        /// </summary>
        public AnswerResponse2()
        {
        }
    }
}