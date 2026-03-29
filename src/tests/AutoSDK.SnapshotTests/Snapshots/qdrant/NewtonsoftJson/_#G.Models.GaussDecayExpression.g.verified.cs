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
        [global::Newtonsoft.Json.JsonProperty("gauss_decay", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DecayParamsExpression GaussDecay { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GaussDecayExpression" /> class.
        /// </summary>
        /// <param name="gaussDecay"></param>
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