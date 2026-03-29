//HintName: G.Models.NegExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NegExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("neg", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression Neg { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NegExpression" /> class.
        /// </summary>
        /// <param name="neg"></param>
        public NegExpression(
            global::G.Expression neg)
        {
            this.Neg = neg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NegExpression" /> class.
        /// </summary>
        public NegExpression()
        {
        }
    }
}