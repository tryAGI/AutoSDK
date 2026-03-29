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
        [global::Newtonsoft.Json.JsonProperty("lin_decay", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DecayParamsExpression LinDecay { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinDecayExpression" /> class.
        /// </summary>
        /// <param name="linDecay"></param>
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