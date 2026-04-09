//HintName: G.Models.CustomTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CustomToolTypeJsonConverter))]
        public global::G.CustomToolType Type { get; set; }

        /// <summary>
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Describes what this tool does and when to call this tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Method to use for the request, default to POST.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CustomToolMethodJsonConverter))]
        public global::G.CustomToolMethod? Method { get; set; }

        /// <summary>
        /// Headers to add to the request.<br/>
        /// Example: {"Authorization":"Bearer 1234567890"}
        /// </summary>
        /// <example>{"Authorization":"Bearer 1234567890"}</example>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Query parameters to append to the request URL.<br/>
        /// Example: {"page":"1","sort":"asc"}
        /// </summary>
        /// <example>{"page":"1","sort":"asc"}</example>
        [global::Newtonsoft.Json.JsonProperty("query_params")]
        public global::System.Collections.Generic.Dictionary<string, string>? QueryParams { get; set; }

        /// <summary>
        /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.ToolParameter? Parameters { get; set; }

        /// <summary>
        /// A mapping of variable names to JSON paths in the response body. These values will be extracted from the response and made available as dynamic variables for use.<br/>
        /// Example: {"user_name":"data.user.name"}
        /// </summary>
        /// <example>{"user_name":"data.user.name"}</example>
        [global::Newtonsoft.Json.JsonProperty("response_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? ResponseVariables { get; set; }

        /// <summary>
        /// Determines whether the agent would say sentence like "One moment, let me check that." when executing the function. Recommend to turn on if your function call takes over 1s (including network) to complete, so that your agent remains responsive.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// Determines whether the agent would call LLM another time and speak when the result of function is obtained. Usually this needs to get turned on so user can get update for the function call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speak_after_execution")]
        public bool? SpeakAfterExecution { get; set; }

        /// <summary>
        /// The description for the sentence agent say during execution. Only applicable when speak_during_execution is true. Can write what to say or even provide examples. The default is "The message you will say to callee when calling this tool. Make sure it fits into the conversation smoothly.".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_message_description")]
        public string? ExecutionMessageDescription { get; set; }

        /// <summary>
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_message_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CustomToolExecutionMessageTypeJsonConverter))]
        public global::G.CustomToolExecutionMessageType? ExecutionMessageType { get; set; }

        /// <summary>
        /// The maximum time in milliseconds the tool can run before it's considered timeout. If the tool times out, the agent would have that info. The minimum value allowed is 1000 ms (1 s), and maximum value allowed is 600,000 ms (10 min). By default, this is set to 120,000 ms (2 min).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// If set to true, the parameters will be passed as root level JSON object instead of nested under "args".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args_at_root")]
        public bool? ArgsAtRoot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </param>
        /// <param name="url">
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </param>
        /// <param name="type"></param>
        /// <param name="description">
        /// Describes what this tool does and when to call this tool.
        /// </param>
        /// <param name="method">
        /// Method to use for the request, default to POST.
        /// </param>
        /// <param name="headers">
        /// Headers to add to the request.<br/>
        /// Example: {"Authorization":"Bearer 1234567890"}
        /// </param>
        /// <param name="queryParams">
        /// Query parameters to append to the request URL.<br/>
        /// Example: {"page":"1","sort":"asc"}
        /// </param>
        /// <param name="parameters">
        /// The parameters the functions accepts, described as a JSON Schema object. See [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. Omitting parameters defines a function with an empty parameter list.
        /// </param>
        /// <param name="responseVariables">
        /// A mapping of variable names to JSON paths in the response body. These values will be extracted from the response and made available as dynamic variables for use.<br/>
        /// Example: {"user_name":"data.user.name"}
        /// </param>
        /// <param name="speakDuringExecution">
        /// Determines whether the agent would say sentence like "One moment, let me check that." when executing the function. Recommend to turn on if your function call takes over 1s (including network) to complete, so that your agent remains responsive.
        /// </param>
        /// <param name="speakAfterExecution">
        /// Determines whether the agent would call LLM another time and speak when the result of function is obtained. Usually this needs to get turned on so user can get update for the function call.
        /// </param>
        /// <param name="executionMessageDescription">
        /// The description for the sentence agent say during execution. Only applicable when speak_during_execution is true. Can write what to say or even provide examples. The default is "The message you will say to callee when calling this tool. Make sure it fits into the conversation smoothly.".
        /// </param>
        /// <param name="executionMessageType">
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </param>
        /// <param name="timeoutMs">
        /// The maximum time in milliseconds the tool can run before it's considered timeout. If the tool times out, the agent would have that info. The minimum value allowed is 1000 ms (1 s), and maximum value allowed is 600,000 ms (10 min). By default, this is set to 120,000 ms (2 min).
        /// </param>
        /// <param name="argsAtRoot">
        /// If set to true, the parameters will be passed as root level JSON object instead of nested under "args".
        /// </param>
        public CustomTool(
            string name,
            string url,
            global::G.CustomToolType type,
            string? description,
            global::G.CustomToolMethod? method,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, string>? queryParams,
            global::G.ToolParameter? parameters,
            global::System.Collections.Generic.Dictionary<string, string>? responseVariables,
            bool? speakDuringExecution,
            bool? speakAfterExecution,
            string? executionMessageDescription,
            global::G.CustomToolExecutionMessageType? executionMessageType,
            int? timeoutMs,
            bool? argsAtRoot)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Description = description;
            this.Method = method;
            this.Headers = headers;
            this.QueryParams = queryParams;
            this.Parameters = parameters;
            this.ResponseVariables = responseVariables;
            this.SpeakDuringExecution = speakDuringExecution;
            this.SpeakAfterExecution = speakAfterExecution;
            this.ExecutionMessageDescription = executionMessageDescription;
            this.ExecutionMessageType = executionMessageType;
            this.TimeoutMs = timeoutMs;
            this.ArgsAtRoot = argsAtRoot;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTool" /> class.
        /// </summary>
        public CustomTool()
        {
        }
    }
}