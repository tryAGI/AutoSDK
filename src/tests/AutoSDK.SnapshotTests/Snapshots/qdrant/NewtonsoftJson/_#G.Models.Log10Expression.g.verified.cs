//HintName: G.Models.Log10Expression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Log10Expression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log10", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression Log10 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Log10Expression" /> class.
        /// </summary>
        /// <param name="log10"></param>
        public Log10Expression(
            global::G.Expression log10)
        {
            this.Log10 = log10;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Log10Expression" /> class.
        /// </summary>
        public Log10Expression()
        {
        }
    }
}