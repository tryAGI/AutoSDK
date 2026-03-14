//HintName: G.Models.McpToolAnnotations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional hints about tool behaviour/metadata.
    /// </summary>
    public sealed partial class McpToolAnnotations
    {
        /// <summary>
        /// If true, the tool does not modify its environment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only_hint")]
        public bool? ReadOnlyHint { get; set; }

        /// <summary>
        /// If true, the tool may perform destructive updates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destructive_hint")]
        public bool? DestructiveHint { get; set; }

        /// <summary>
        /// If true, repeated calls with same args have no additional effect.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idempotent_hint")]
        public bool? IdempotentHint { get; set; }

        /// <summary>
        /// If true, tool interacts with external entities.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("open_world_hint")]
        public bool? OpenWorldHint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolAnnotations" /> class.
        /// </summary>
        /// <param name="readOnlyHint">
        /// If true, the tool does not modify its environment.
        /// </param>
        /// <param name="destructiveHint">
        /// If true, the tool may perform destructive updates.
        /// </param>
        /// <param name="idempotentHint">
        /// If true, repeated calls with same args have no additional effect.
        /// </param>
        /// <param name="openWorldHint">
        /// If true, tool interacts with external entities.
        /// </param>
        public McpToolAnnotations(
            bool? readOnlyHint,
            bool? destructiveHint,
            bool? idempotentHint,
            bool? openWorldHint)
        {
            this.ReadOnlyHint = readOnlyHint;
            this.DestructiveHint = destructiveHint;
            this.IdempotentHint = idempotentHint;
            this.OpenWorldHint = openWorldHint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolAnnotations" /> class.
        /// </summary>
        public McpToolAnnotations()
        {
        }
    }
}