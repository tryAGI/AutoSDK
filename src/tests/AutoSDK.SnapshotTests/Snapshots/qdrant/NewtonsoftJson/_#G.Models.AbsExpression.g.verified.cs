//HintName: G.Models.AbsExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AbsExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("abs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression Abs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbsExpression" /> class.
        /// </summary>
        /// <param name="abs"></param>
        public AbsExpression(
            global::G.Expression abs)
        {
            this.Abs = abs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbsExpression" /> class.
        /// </summary>
        public AbsExpression()
        {
        }
    }
}