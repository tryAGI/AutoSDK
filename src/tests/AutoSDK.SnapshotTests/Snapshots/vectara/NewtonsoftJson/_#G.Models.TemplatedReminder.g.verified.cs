//HintName: G.Models.TemplatedReminder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A templated reminder with a Velocity template that is compiled at session start and injected into messages matching the specified hooks.
    /// </summary>
    public sealed partial class TemplatedReminder
    {
        /// <summary>
        /// The type of reminder.<br/>
        /// Default Value: templated<br/>
        /// Example: templated
        /// </summary>
        /// <default>"templated"</default>
        /// <example>templated</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

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
        /// Event types that trigger this reminder to be appended to the corresponding message.<br/>
        /// Example: [tool_output]
        /// </summary>
        /// <example>[tool_output]</example>
        [global::Newtonsoft.Json.JsonProperty("hooks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TemplatedReminderHook> Hooks { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatedReminder" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of reminder.<br/>
        /// Default Value: templated<br/>
        /// Example: templated
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
        /// <param name="hooks">
        /// Event types that trigger this reminder to be appended to the corresponding message.<br/>
        /// Example: [tool_output]
        /// </param>
        /// <param name="templateType">
        /// The templating engine used for instructions.<br/>
        /// Default Value: velocity<br/>
        /// Example: velocity
        /// </param>
        public TemplatedReminder(
            string type,
            string template,
            global::System.Collections.Generic.IList<global::G.TemplatedReminderHook> hooks,
            global::G.TemplateType? templateType)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.TemplateType = templateType;
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
            this.Hooks = hooks ?? throw new global::System.ArgumentNullException(nameof(hooks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatedReminder" /> class.
        /// </summary>
        public TemplatedReminder()
        {
        }
    }
}