//HintName: G.Models.DivExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DivExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("div", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DivParams Div { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DivExpression" /> class.
        /// </summary>
        /// <param name="div"></param>
        public DivExpression(
            global::G.DivParams div)
        {
            this.Div = div ?? throw new global::System.ArgumentNullException(nameof(div));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DivExpression" /> class.
        /// </summary>
        public DivExpression()
        {
        }
    }
}