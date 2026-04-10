//HintName: G.Models.SpanScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Process individual spans
    /// </summary>
    public sealed partial class SpanScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SpanScopeTypeJsonConverter))]
        public global::G.SpanScopeType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanScope" /> class.
        /// </summary>
        /// <param name="type"></param>
        public SpanScope(
            global::G.SpanScopeType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanScope" /> class.
        /// </summary>
        public SpanScope()
        {
        }
    }
}