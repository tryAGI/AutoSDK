//HintName: G.Models.ExpDecayExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpDecayExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exp_decay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DecayParamsExpression ExpDecay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpDecayExpression" /> class.
        /// </summary>
        /// <param name="expDecay"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpDecayExpression(
            global::G.DecayParamsExpression expDecay)
        {
            this.ExpDecay = expDecay ?? throw new global::System.ArgumentNullException(nameof(expDecay));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpDecayExpression" /> class.
        /// </summary>
        public ExpDecayExpression()
        {
        }
    }
}