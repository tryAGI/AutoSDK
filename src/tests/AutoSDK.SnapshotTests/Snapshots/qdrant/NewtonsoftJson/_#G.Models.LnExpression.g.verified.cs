//HintName: G.Models.LnExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LnExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ln", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression Ln { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LnExpression" /> class.
        /// </summary>
        /// <param name="ln"></param>
        public LnExpression(
            global::G.Expression ln)
        {
            this.Ln = ln;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LnExpression" /> class.
        /// </summary>
        public LnExpression()
        {
        }
    }
}