//HintName: G.Models.Memory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents the in-context memory (i.e. Core memory) of the agent. This includes both the `Block` objects (labelled by sections), as well as tools to edit the blocks.
    /// </summary>
    public sealed partial class Memory
    {
        /// <summary>
        /// Agent type controlling prompt rendering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.AgentType?, string, object>))]
        public global::G.AnyOf<global::G.AgentType?, string, object>? AgentType { get; set; }

        /// <summary>
        /// Whether this agent uses git-backed memory with structured labels.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_enabled")]
        public bool? GitEnabled { get; set; }

        /// <summary>
        /// Memory blocks contained in the agent's in-context memory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Block> Blocks { get; set; }

        /// <summary>
        /// Special blocks representing the agent's in-context memory of an attached file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_blocks")]
        public global::System.Collections.Generic.IList<global::G.FileBlock>? FileBlocks { get; set; }

        /// <summary>
        /// Deprecated. Ignored for performance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Memory" /> class.
        /// </summary>
        /// <param name="blocks">
        /// Memory blocks contained in the agent's in-context memory
        /// </param>
        /// <param name="agentType">
        /// Agent type controlling prompt rendering.
        /// </param>
        /// <param name="gitEnabled">
        /// Whether this agent uses git-backed memory with structured labels.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="fileBlocks">
        /// Special blocks representing the agent's in-context memory of an attached file
        /// </param>
        /// <param name="promptTemplate">
        /// Deprecated. Ignored for performance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Memory(
            global::System.Collections.Generic.IList<global::G.Block> blocks,
            global::G.AnyOf<global::G.AgentType?, string, object>? agentType,
            bool? gitEnabled,
            global::System.Collections.Generic.IList<global::G.FileBlock>? fileBlocks,
            string? promptTemplate)
        {
            this.AgentType = agentType;
            this.GitEnabled = gitEnabled;
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
            this.FileBlocks = fileBlocks;
            this.PromptTemplate = promptTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Memory" /> class.
        /// </summary>
        public Memory()
        {
        }
    }
}