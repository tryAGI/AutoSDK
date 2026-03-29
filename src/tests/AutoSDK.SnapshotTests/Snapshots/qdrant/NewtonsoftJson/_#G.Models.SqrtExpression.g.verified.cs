//HintName: G.Models.SqrtExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SqrtExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sqrt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression Sqrt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SqrtExpression" /> class.
        /// </summary>
        /// <param name="sqrt"></param>
        public SqrtExpression(
            global::G.Expression sqrt)
        {
            this.Sqrt = sqrt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqrtExpression" /> class.
        /// </summary>
        public SqrtExpression()
        {
        }
    }
}