//HintName: G.Models.PowExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PowExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pow", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PowParams Pow { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PowExpression" /> class.
        /// </summary>
        /// <param name="pow"></param>
        public PowExpression(
            global::G.PowParams pow)
        {
            this.Pow = pow ?? throw new global::System.ArgumentNullException(nameof(pow));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowExpression" /> class.
        /// </summary>
        public PowExpression()
        {
        }
    }
}