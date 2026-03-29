//HintName: G.Models.BodyImportAgent.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyImportAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// If set to True, existing tools can get their source code overwritten by the uploaded tool definitions. Note that Letta core tools can never be updated externally.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("override_existing_tools")]
        public bool? OverrideExistingTools { get; set; }

        /// <summary>
        /// If set to True, strips all messages from the agent before importing.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strip_messages")]
        public bool? StripMessages { get; set; }

        /// <summary>
        /// Secrets as a JSON string to pass to the agent for tool execution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secrets")]
        public string? Secrets { get; set; }

        /// <summary>
        /// If provided, overrides the agent name with this value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Embedding handle to override with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public string? Embedding { get; set; }

        /// <summary>
        /// Model handle to override the agent's default model. This allows the imported agent to use a different model while keeping other defaults (e.g., context size) from the original configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// If set to True, appends "_copy" to the end of the agent name.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("append_copy_suffix")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? AppendCopySuffix { get; set; }

        /// <summary>
        /// If provided, overrides the agent name with this value. Use 'name' instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("override_name")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? OverrideName { get; set; }

        /// <summary>
        /// Override import with specific embedding handle. Use 'embedding' instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("override_embedding_handle")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? OverrideEmbeddingHandle { get; set; }

        /// <summary>
        /// Model handle to override the agent's default model. Use 'model' instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("override_model_handle")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? OverrideModelHandle { get; set; }

        /// <summary>
        /// The project ID to associate the uploaded agent with. This is now passed via headers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Environment variables as a JSON string to pass to the agent for tool execution. Use 'secrets' instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("env_vars_json")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EnvVarsJson { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyImportAgent" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="overrideExistingTools">
        /// If set to True, existing tools can get their source code overwritten by the uploaded tool definitions. Note that Letta core tools can never be updated externally.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="stripMessages">
        /// If set to True, strips all messages from the agent before importing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="secrets">
        /// Secrets as a JSON string to pass to the agent for tool execution.
        /// </param>
        /// <param name="name">
        /// If provided, overrides the agent name with this value.
        /// </param>
        /// <param name="embedding">
        /// Embedding handle to override with.
        /// </param>
        /// <param name="model">
        /// Model handle to override the agent's default model. This allows the imported agent to use a different model while keeping other defaults (e.g., context size) from the original configuration.
        /// </param>
        public BodyImportAgent(
            byte[] file,
            string filename,
            bool? overrideExistingTools,
            bool? stripMessages,
            string? secrets,
            string? name,
            string? embedding,
            string? model)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.OverrideExistingTools = overrideExistingTools;
            this.StripMessages = stripMessages;
            this.Secrets = secrets;
            this.Name = name;
            this.Embedding = embedding;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyImportAgent" /> class.
        /// </summary>
        public BodyImportAgent()
        {
        }
    }
}