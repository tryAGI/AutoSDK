//HintName: G.Models.ContextQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ContextInput Context { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextQuery" /> class.
        /// </summary>
        /// <param name="context"></param>
        public ContextQuery(
            global::G.ContextInput context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextQuery" /> class.
        /// </summary>
        public ContextQuery()
        {
        }
    }
}