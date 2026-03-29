//HintName: G.Models.ExpExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression Exp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpExpression" /> class.
        /// </summary>
        /// <param name="exp"></param>
        public ExpExpression(
            global::G.Expression exp)
        {
            this.Exp = exp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpExpression" /> class.
        /// </summary>
        public ExpExpression()
        {
        }
    }
}