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
        [global::Newtonsoft.Json.JsonProperty("exp_decay", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DecayParamsExpression ExpDecay { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpDecayExpression" /> class.
        /// </summary>
        /// <param name="expDecay"></param>
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