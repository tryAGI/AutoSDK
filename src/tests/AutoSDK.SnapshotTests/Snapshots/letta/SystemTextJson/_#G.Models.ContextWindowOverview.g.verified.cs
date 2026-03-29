//HintName: G.Models.ContextWindowOverview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Overview of the context window, including the number of messages and tokens.
    /// </summary>
    public sealed partial class ContextWindowOverview
    {
        /// <summary>
        /// The maximum amount of tokens the context window can hold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window_size_max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextWindowSizeMax { get; set; }

        /// <summary>
        /// The current number of tokens in the context window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window_size_current")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextWindowSizeCurrent { get; set; }

        /// <summary>
        /// The number of messages in the context window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumMessages { get; set; }

        /// <summary>
        /// The number of messages in the archival memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_archival_memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumArchivalMemory { get; set; }

        /// <summary>
        /// The number of messages in the recall memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_recall_memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumRecallMemory { get; set; }

        /// <summary>
        /// The number of tokens in the external memory summary (archival + recall metadata).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_tokens_external_memory_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumTokensExternalMemorySummary { get; set; }

        /// <summary>
        /// The metadata summary of the external memory sources (archival + recall metadata).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_memory_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalMemorySummary { get; set; }

        /// <summary>
        /// The number of tokens in the system prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_tokens_system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumTokensSystem { get; set; }

        /// <summary>
        /// The content of the system prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SystemPrompt { get; set; }

        /// <summary>
        /// The number of tokens in the core memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_tokens_core_memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumTokensCoreMemory { get; set; }

        /// <summary>
        /// The content of the core memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("core_memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CoreMemory { get; set; }

        /// <summary>
        /// The number of tokens in the memory filesystem section (git-enabled agents only).<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_tokens_memory_filesystem")]
        public int? NumTokensMemoryFilesystem { get; set; }

        /// <summary>
        /// The content of the memory filesystem section.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_filesystem")]
        public string? MemoryFilesystem { get; set; }

        /// <summary>
        /// The number of tokens in the tool usage rules section.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_tokens_tool_usage_rules")]
        public int? NumTokensToolUsageRules { get; set; }

        /// <summary>
        /// The content of the tool usage rules section.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_usage_rules")]
        public string? ToolUsageRules { get; set; }

        /// <summary>
        /// The number of tokens in the directories section (attached sources).<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_tokens_directories")]
        public int? NumTokensDirectories { get; set; }

        /// <summary>
        /// The content of the directories section.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directories")]
        public string? Directories { get; set; }

        /// <summary>
        /// The number of tokens in the summary memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_tokens_summary_memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumTokensSummaryMemory { get; set; }

        /// <summary>
        /// The content of the summary memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_memory")]
        public string? SummaryMemory { get; set; }

        /// <summary>
        /// The number of tokens in the functions definitions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_tokens_functions_definitions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumTokensFunctionsDefinitions { get; set; }

        /// <summary>
        /// The content of the functions definitions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions_definitions")]
        public global::System.Collections.Generic.IList<global::G.FunctionTool>? FunctionsDefinitions { get; set; }

        /// <summary>
        /// The number of tokens in the messages list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_tokens_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumTokensMessages { get; set; }

        /// <summary>
        /// The messages in the context window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Message> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextWindowOverview" /> class.
        /// </summary>
        /// <param name="contextWindowSizeMax">
        /// The maximum amount of tokens the context window can hold.
        /// </param>
        /// <param name="contextWindowSizeCurrent">
        /// The current number of tokens in the context window.
        /// </param>
        /// <param name="numMessages">
        /// The number of messages in the context window.
        /// </param>
        /// <param name="numArchivalMemory">
        /// The number of messages in the archival memory.
        /// </param>
        /// <param name="numRecallMemory">
        /// The number of messages in the recall memory.
        /// </param>
        /// <param name="numTokensExternalMemorySummary">
        /// The number of tokens in the external memory summary (archival + recall metadata).
        /// </param>
        /// <param name="externalMemorySummary">
        /// The metadata summary of the external memory sources (archival + recall metadata).
        /// </param>
        /// <param name="numTokensSystem">
        /// The number of tokens in the system prompt.
        /// </param>
        /// <param name="systemPrompt">
        /// The content of the system prompt.
        /// </param>
        /// <param name="numTokensCoreMemory">
        /// The number of tokens in the core memory.
        /// </param>
        /// <param name="coreMemory">
        /// The content of the core memory.
        /// </param>
        /// <param name="numTokensSummaryMemory">
        /// The number of tokens in the summary memory.
        /// </param>
        /// <param name="numTokensFunctionsDefinitions">
        /// The number of tokens in the functions definitions.
        /// </param>
        /// <param name="numTokensMessages">
        /// The number of tokens in the messages list.
        /// </param>
        /// <param name="messages">
        /// The messages in the context window.
        /// </param>
        /// <param name="numTokensMemoryFilesystem">
        /// The number of tokens in the memory filesystem section (git-enabled agents only).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="memoryFilesystem">
        /// The content of the memory filesystem section.
        /// </param>
        /// <param name="numTokensToolUsageRules">
        /// The number of tokens in the tool usage rules section.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="toolUsageRules">
        /// The content of the tool usage rules section.
        /// </param>
        /// <param name="numTokensDirectories">
        /// The number of tokens in the directories section (attached sources).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="directories">
        /// The content of the directories section.
        /// </param>
        /// <param name="summaryMemory">
        /// The content of the summary memory.
        /// </param>
        /// <param name="functionsDefinitions">
        /// The content of the functions definitions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextWindowOverview(
            int contextWindowSizeMax,
            int contextWindowSizeCurrent,
            int numMessages,
            int numArchivalMemory,
            int numRecallMemory,
            int numTokensExternalMemorySummary,
            string externalMemorySummary,
            int numTokensSystem,
            string systemPrompt,
            int numTokensCoreMemory,
            string coreMemory,
            int numTokensSummaryMemory,
            int numTokensFunctionsDefinitions,
            int numTokensMessages,
            global::System.Collections.Generic.IList<global::G.Message> messages,
            int? numTokensMemoryFilesystem,
            string? memoryFilesystem,
            int? numTokensToolUsageRules,
            string? toolUsageRules,
            int? numTokensDirectories,
            string? directories,
            string? summaryMemory,
            global::System.Collections.Generic.IList<global::G.FunctionTool>? functionsDefinitions)
        {
            this.ContextWindowSizeMax = contextWindowSizeMax;
            this.ContextWindowSizeCurrent = contextWindowSizeCurrent;
            this.NumMessages = numMessages;
            this.NumArchivalMemory = numArchivalMemory;
            this.NumRecallMemory = numRecallMemory;
            this.NumTokensExternalMemorySummary = numTokensExternalMemorySummary;
            this.ExternalMemorySummary = externalMemorySummary ?? throw new global::System.ArgumentNullException(nameof(externalMemorySummary));
            this.NumTokensSystem = numTokensSystem;
            this.SystemPrompt = systemPrompt ?? throw new global::System.ArgumentNullException(nameof(systemPrompt));
            this.NumTokensCoreMemory = numTokensCoreMemory;
            this.CoreMemory = coreMemory ?? throw new global::System.ArgumentNullException(nameof(coreMemory));
            this.NumTokensMemoryFilesystem = numTokensMemoryFilesystem;
            this.MemoryFilesystem = memoryFilesystem;
            this.NumTokensToolUsageRules = numTokensToolUsageRules;
            this.ToolUsageRules = toolUsageRules;
            this.NumTokensDirectories = numTokensDirectories;
            this.Directories = directories;
            this.NumTokensSummaryMemory = numTokensSummaryMemory;
            this.SummaryMemory = summaryMemory;
            this.NumTokensFunctionsDefinitions = numTokensFunctionsDefinitions;
            this.FunctionsDefinitions = functionsDefinitions;
            this.NumTokensMessages = numTokensMessages;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextWindowOverview" /> class.
        /// </summary>
        public ContextWindowOverview()
        {
        }
    }
}