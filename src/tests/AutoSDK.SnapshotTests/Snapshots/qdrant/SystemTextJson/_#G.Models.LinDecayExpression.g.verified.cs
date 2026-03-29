//HintName: G.Models.LinDecayExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinDecayExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lin_decay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DecayParamsExpression LinDecay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinDecayExpression" /> class.
        /// </summary>
        /// <param name="linDecay"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LinDecayExpression(
            global::G.DecayParamsExpression linDecay)
        {
            this.LinDecay = linDecay ?? throw new global::System.ArgumentNullException(nameof(linDecay));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinDecayExpression" /> class.
        /// </summary>
        public LinDecayExpression()
        {
        }
    }
}