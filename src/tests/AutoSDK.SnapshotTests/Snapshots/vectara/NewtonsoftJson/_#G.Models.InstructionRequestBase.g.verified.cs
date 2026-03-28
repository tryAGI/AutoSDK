//HintName: G.Models.InstructionRequestBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base properties for creating an instruction, without the type discriminator field.
    /// </summary>
    public sealed partial class InstructionRequestBase
    {
        /// <summary>
        /// The human-readable name of an instruction.<br/>
        /// Example: Customer Support Initial Instruction
        /// </summary>
        /// <example>Customer Support Initial Instruction</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A detailed description of what this instruction does.<br/>
        /// Example: Provides initial context and guidelines for customer support interactions
        /// </summary>
        /// <example>Provides initial context and guidelines for customer support interactions</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The templating engine used for instructions.<br/>
        /// Default Value: velocity<br/>
        /// Example: velocity
        /// </summary>
        /// <example>velocity</example>
        [global::Newtonsoft.Json.JsonProperty("template_type")]
        public global::G.TemplateType? TemplateType { get; set; }

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
        /// Arbitrary metadata associated with the instruction.<br/>
        /// Default Value: {}<br/>
        /// Example: {"version":"1.0.0","author":"support-team"}
        /// </summary>
        /// <example>{"version":"1.0.0","author":"support-team"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the instruction should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstructionRequestBase" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of an instruction.<br/>
        /// Example: Customer Support Initial Instruction
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
        /// <param name="description">
        /// A detailed description of what this instruction does.<br/>
        /// Example: Provides initial context and guidelines for customer support interactions
        /// </param>
        /// <param name="templateType">
        /// The templating engine used for instructions.<br/>
        /// Default Value: velocity<br/>
        /// Example: velocity
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the instruction.<br/>
        /// Default Value: {}<br/>
        /// Example: {"version":"1.0.0","author":"support-team"}
        /// </param>
        /// <param name="enabled">
        /// Whether the instruction should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        public InstructionRequestBase(
            string name,
            string template,
            string? description,
            global::G.TemplateType? templateType,
            object? metadata,
            bool? enabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.TemplateType = templateType;
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
            this.Metadata = metadata;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstructionRequestBase" /> class.
        /// </summary>
        public InstructionRequestBase()
        {
        }
    }
}