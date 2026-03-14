//HintName: G.Models.InitialInstruction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An initial instruction that provides guidance to the agent before user messages.
    /// </summary>
    public sealed partial class InitialInstruction
    {
        /// <summary>
        /// The unique identifier for an instruction.<br/>
        /// Example: ins_customer_support_init
        /// </summary>
        /// <example>ins_customer_support_init</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of instruction.<br/>
        /// Default Value: initial<br/>
        /// Example: initial
        /// </summary>
        /// <default>"initial"</default>
        /// <example>initial</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The human-readable name of an instruction.<br/>
        /// Example: Customer Support Initial Instruction
        /// </summary>
        /// <example>Customer Support Initial Instruction</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A detailed description of what this instruction does.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The templating engine used for instructions.<br/>
        /// Default Value: velocity<br/>
        /// Example: velocity
        /// </summary>
        /// <default>global::G.TemplateType.Velocity</default>
        /// <example>velocity</example>
        [global::Newtonsoft.Json.JsonProperty("template_type")]
        public global::G.TemplateType TemplateType { get; set; } = global::G.TemplateType.Velocity;

        /// <summary>
        /// The instruction template content using the specified template engine.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.key` - Agent key<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map (includes user-provided context from test/runtime)<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// - `$tools` - List of tool maps, each with `name` and `description` fields<br/>
        /// Example: `You are a helpful customer support agent. Agent: $agent.name. Today is $currentDate. Available tools: #foreach($tool in $tools)${tool.name}#if($foreach.hasNext), #end#end`<br/>
        /// Example: You are an expert customer support agent for $agent.name. Available tools: #foreach($tool in $tools)${tool.name}#if($foreach.hasNext), #end#end
        /// </summary>
        /// <example>You are an expert customer support agent for $agent.name. Available tools: #foreach($tool in $tools)${tool.name}#if($foreach.hasNext), #end#end</example>
        [global::Newtonsoft.Json.JsonProperty("template", Required = global::Newtonsoft.Json.Required.Always)]
        public string Template { get; set; } = default!;

        /// <summary>
        /// The version identifier for this instruction. This is automatically incremented when the instruction is updated.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// Arbitrary metadata associated with the instruction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the instruction is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Timestamp when the instruction was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the instruction was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitialInstruction" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for an instruction.<br/>
        /// Example: ins_customer_support_init
        /// </param>
        /// <param name="type">
        /// The type of instruction.<br/>
        /// Default Value: initial<br/>
        /// Example: initial
        /// </param>
        /// <param name="name">
        /// The human-readable name of an instruction.<br/>
        /// Example: Customer Support Initial Instruction
        /// </param>
        /// <param name="description">
        /// A detailed description of what this instruction does.
        /// </param>
        /// <param name="templateType">
        /// The templating engine used for instructions.<br/>
        /// Default Value: velocity<br/>
        /// Example: velocity
        /// </param>
        /// <param name="template">
        /// The instruction template content using the specified template engine.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.key` - Agent key<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map (includes user-provided context from test/runtime)<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// - `$tools` - List of tool maps, each with `name` and `description` fields<br/>
        /// Example: `You are a helpful customer support agent. Agent: $agent.name. Today is $currentDate. Available tools: #foreach($tool in $tools)${tool.name}#if($foreach.hasNext), #end#end`<br/>
        /// Example: You are an expert customer support agent for $agent.name. Available tools: #foreach($tool in $tools)${tool.name}#if($foreach.hasNext), #end#end
        /// </param>
        /// <param name="version">
        /// The version identifier for this instruction. This is automatically incremented when the instruction is updated.<br/>
        /// Example: 1
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the instruction.
        /// </param>
        /// <param name="enabled">
        /// Whether the instruction is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the instruction was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the instruction was last updated.
        /// </param>
        public InitialInstruction(
            string id,
            string type,
            string name,
            string template,
            int version,
            bool enabled,
            string? description,
            object? metadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::G.TemplateType templateType = global::G.TemplateType.Velocity)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
            this.Version = version;
            this.Enabled = enabled;
            this.Description = description;
            this.TemplateType = templateType;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitialInstruction" /> class.
        /// </summary>
        public InitialInstruction()
        {
        }
    }
}