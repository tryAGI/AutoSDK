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
        [global::Newtonsoft.Json.JsonProperty("context_window_size_max", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContextWindowSizeMax { get; set; } = default!;

        /// <summary>
        /// The current number of tokens in the context window.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_window_size_current", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContextWindowSizeCurrent { get; set; } = default!;

        /// <summary>
        /// The number of messages in the context window.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_messages", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumMessages { get; set; } = default!;

        /// <summary>
        /// The number of messages in the archival memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_archival_memory", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumArchivalMemory { get; set; } = default!;

        /// <summary>
        /// The number of messages in the recall memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_recall_memory", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumRecallMemory { get; set; } = default!;

        /// <summary>
        /// The number of tokens in the external memory summary (archival + recall metadata).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_tokens_external_memory_summary", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumTokensExternalMemorySummary { get; set; } = default!;

        /// <summary>
        /// The metadata summary of the external memory sources (archival + recall metadata).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_memory_summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExternalMemorySummary { get; set; } = default!;

        /// <summary>
        /// The number of tokens in the system prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_tokens_system", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumTokensSystem { get; set; } = default!;

        /// <summary>
        /// The content of the system prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string SystemPrompt { get; set; } = default!;

        /// <summary>
        /// The number of tokens in the core memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_tokens_core_memory", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumTokensCoreMemory { get; set; } = default!;

        /// <summary>
        /// The content of the core memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("core_memory", Required = global::Newtonsoft.Json.Required.Always)]
        public string CoreMemory { get; set; } = default!;

        /// <summary>
        /// The number of tokens in the memory filesystem section (git-enabled agents only).<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_tokens_memory_filesystem")]
        public int? NumTokensMemoryFilesystem { get; set; }

        /// <summary>
        /// The content of the memory filesystem section.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory_filesystem")]
        public string? MemoryFilesystem { get; set; }

        /// <summary>
        /// The number of tokens in the tool usage rules section.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_tokens_tool_usage_rules")]
        public int? NumTokensToolUsageRules { get; set; }

        /// <summary>
        /// The content of the tool usage rules section.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_usage_rules")]
        public string? ToolUsageRules { get; set; }

        /// <summary>
        /// The number of tokens in the directories section (attached sources).<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_tokens_directories")]
        public int? NumTokensDirectories { get; set; }

        /// <summary>
        /// The content of the directories section.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("directories")]
        public string? Directories { get; set; }

        /// <summary>
        /// The number of tokens in the summary memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_tokens_summary_memory", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumTokensSummaryMemory { get; set; } = default!;

        /// <summary>
        /// The content of the summary memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_memory")]
        public string? SummaryMemory { get; set; }

        /// <summary>
        /// The number of tokens in the functions definitions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_tokens_functions_definitions", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumTokensFunctionsDefinitions { get; set; } = default!;

        /// <summary>
        /// The content of the functions definitions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("functions_definitions")]
        public global::System.Collections.Generic.IList<global::G.FunctionTool>? FunctionsDefinitions { get; set; }

        /// <summary>
        /// The number of tokens in the messages list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_tokens_messages", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumTokensMessages { get; set; } = default!;

        /// <summary>
        /// The messages in the context window.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Message> Messages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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