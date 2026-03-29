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
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ContextInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ContextInput Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextQuery" /> class.
        /// </summary>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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