//HintName: G.Models.CreateResponseRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResponseRequest
    {
        /// <summary>
        /// ID of the model to use. For details on which models are compatible with the Responses API, see available [models](https://console.groq.com/docs/models)<br/>
        /// Example: llama-3.3-70b-versatile
        /// </summary>
        /// <example>llama-3.3-70b-versatile</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::G.CreateResponseRequestModel?> Model { get; set; } = default!;

        /// <summary>
        /// Text input to the model, used to generate a response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ResponseInputItem>> Input { get; set; } = default!;

        /// <summary>
        /// Inserts a system (or developer) message as the first item in the model's context.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// An upper bound for the number of tokens that can be generated for a response, including visible output tokens and reasoning tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Controls randomness in the response generation. Range: 0 to 2. Lower values produce more deterministic outputs, higher values increase variety and creativity.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling parameter that controls the cumulative probability cutoff. Range: 0 to 1. A value of 0.1 restricts sampling to tokens within the top 10% probability mass.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// List of tools available to the model. Currently supports function definitions only. Maximum of 128 functions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ResponseTool>? Tools { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools.<br/>
        /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// `none` is the default when no tools are present. `auto` is the default if tools are present.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public global::G.ResponseToolChoiceOption? ToolChoice { get; set; }

        /// <summary>
        /// Response format configuration. Supports plain text or structured JSON output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public global::G.CreateResponseRequestText? Text { get; set; }

        /// <summary>
        /// Configuration for reasoning capabilities when using [models that support reasoning](https://console.groq.com/docs/reasoning).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning")]
        public global::G.CreateResponseRequestReasoning? Reasoning { get; set; }

        /// <summary>
        /// Custom key-value pairs for storing additional information. Maximum of 16 pairs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Enable parallel execution of multiple tool calls.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Response storage flag. Note: Currently only supports false or null values.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Enable streaming mode to receive response data as server-sent events.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Optional identifier for tracking end-user requests. Useful for usage monitoring and compliance.<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Specifies the latency tier to use for processing the request.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_tier")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateResponseRequestServiceTierJsonConverter))]
        public global::G.CreateResponseRequestServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Context truncation strategy. Supported values: `auto` or `disabled`.<br/>
        /// Default Value: disabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncation")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateResponseRequestTruncationJsonConverter))]
        public global::G.CreateResponseRequestTruncation? Truncation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use. For details on which models are compatible with the Responses API, see available [models](https://console.groq.com/docs/models)<br/>
        /// Example: llama-3.3-70b-versatile
        /// </param>
        /// <param name="input">
        /// Text input to the model, used to generate a response.
        /// </param>
        /// <param name="instructions">
        /// Inserts a system (or developer) message as the first item in the model's context.
        /// </param>
        /// <param name="maxOutputTokens">
        /// An upper bound for the number of tokens that can be generated for a response, including visible output tokens and reasoning tokens.
        /// </param>
        /// <param name="temperature">
        /// Controls randomness in the response generation. Range: 0 to 2. Lower values produce more deterministic outputs, higher values increase variety and creativity.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter that controls the cumulative probability cutoff. Range: 0 to 1. A value of 0.1 restricts sampling to tokens within the top 10% probability mass.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="tools">
        /// List of tools available to the model. Currently supports function definitions only. Maximum of 128 functions.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools.<br/>
        /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// `none` is the default when no tools are present. `auto` is the default if tools are present.
        /// </param>
        /// <param name="text">
        /// Response format configuration. Supports plain text or structured JSON output.
        /// </param>
        /// <param name="reasoning">
        /// Configuration for reasoning capabilities when using [models that support reasoning](https://console.groq.com/docs/reasoning).
        /// </param>
        /// <param name="metadata">
        /// Custom key-value pairs for storing additional information. Maximum of 16 pairs.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Enable parallel execution of multiple tool calls.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="store">
        /// Response storage flag. Note: Currently only supports false or null values.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stream">
        /// Enable streaming mode to receive response data as server-sent events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="user">
        /// Optional identifier for tracking end-user requests. Useful for usage monitoring and compliance.<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="serviceTier">
        /// Specifies the latency tier to use for processing the request.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="truncation">
        /// Context truncation strategy. Supported values: `auto` or `disabled`.<br/>
        /// Default Value: disabled
        /// </param>
        public CreateResponseRequest(
            global::G.AnyOf<string, global::G.CreateResponseRequestModel?> model,
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ResponseInputItem>> input,
            string? instructions,
            int? maxOutputTokens,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<global::G.ResponseTool>? tools,
            global::G.ResponseToolChoiceOption? toolChoice,
            global::G.CreateResponseRequestText? text,
            global::G.CreateResponseRequestReasoning? reasoning,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            bool? parallelToolCalls,
            bool? store,
            bool? stream,
            string? user,
            global::G.CreateResponseRequestServiceTier? serviceTier,
            global::G.CreateResponseRequestTruncation? truncation)
        {
            this.Model = model;
            this.Input = input;
            this.Instructions = instructions;
            this.MaxOutputTokens = maxOutputTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Text = text;
            this.Reasoning = reasoning;
            this.Metadata = metadata;
            this.ParallelToolCalls = parallelToolCalls;
            this.Store = store;
            this.Stream = stream;
            this.User = user;
            this.ServiceTier = serviceTier;
            this.Truncation = truncation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequest" /> class.
        /// </summary>
        public CreateResponseRequest()
        {
        }
    }
}