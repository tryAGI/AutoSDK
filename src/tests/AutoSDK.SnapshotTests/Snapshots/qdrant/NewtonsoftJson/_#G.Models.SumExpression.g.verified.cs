//HintName: G.Models.SumExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SumExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sum", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Expression> Sum { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SumExpression" /> class.
        /// </summary>
        /// <param name="sum"></param>
        public SumExpression(
            global::System.Collections.Generic.IList<global::G.Expression> sum)
        {
            this.Sum = sum ?? throw new global::System.ArgumentNullException(nameof(sum));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SumExpression" /> class.
        /// </summary>
        public SumExpression()
        {
        }
    }
}