//HintName: G.Models.PaginatedLlmConnections.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedLlmConnections
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LlmConnection> Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UtilsMetaResponse Meta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedLlmConnections" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="meta"></param>
        public PaginatedLlmConnections(
            global::System.Collections.Generic.IList<global::G.LlmConnection> data,
            global::G.UtilsMetaResponse meta)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedLlmConnections" /> class.
        /// </summary>
        public PaginatedLlmConnections()
        {
        }
    }
}