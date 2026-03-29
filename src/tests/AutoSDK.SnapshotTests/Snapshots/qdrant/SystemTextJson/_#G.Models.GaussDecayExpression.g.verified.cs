//HintName: G.Models.GaussDecayExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GaussDecayExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gauss_decay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DecayParamsExpression GaussDecay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GaussDecayExpression" /> class.
        /// </summary>
        /// <param name="gaussDecay"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GaussDecayExpression(
            global::G.DecayParamsExpression gaussDecay)
        {
            this.GaussDecay = gaussDecay ?? throw new global::System.ArgumentNullException(nameof(gaussDecay));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GaussDecayExpression" /> class.
        /// </summary>
        public GaussDecayExpression()
        {
        }
    }
}