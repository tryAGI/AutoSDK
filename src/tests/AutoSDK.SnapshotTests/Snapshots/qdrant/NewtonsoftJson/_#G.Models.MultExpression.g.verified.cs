//HintName: G.Models.MultExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mult", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Expression> Mult { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultExpression" /> class.
        /// </summary>
        /// <param name="mult"></param>
        public MultExpression(
            global::System.Collections.Generic.IList<global::G.Expression> mult)
        {
            this.Mult = mult ?? throw new global::System.ArgumentNullException(nameof(mult));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultExpression" /> class.
        /// </summary>
        public MultExpression()
        {
        }
    }
}