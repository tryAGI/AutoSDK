//HintName: G.Models.AssistantMessageJudgePlanAI.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessageJudgePlanAI
    {
        /// <summary>
        /// This is the model to use for the LLM-as-a-judge.<br/>
        /// If not provided, will default to the assistant's model.<br/>
        /// The instructions on how to evaluate the model output with this LLM-Judge must be passed as a system message in the messages array of the model.<br/>
        /// The Mock conversation can be passed to the LLM-Judge to evaluate using the prompt {{messages}} and will be evaluated as a LiquidJS Variable. To access and judge only the last message, use {{messages[-1]}}<br/>
        /// The LLM-Judge must respond with "pass" or "fail" and only those two responses are allowed.<br/>
        /// Example: {
        /// </summary>
        /// <example>{</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.EvalOpenAIModel, global::G.EvalAnthropicModel, global::G.EvalGoogleModel, global::G.EvalCustomModel> Model { get; set; } = default!;

        /// <summary>
        /// This is the type of the judge plan.<br/>
        /// Use 'ai' to evaluate the assistant message content using LLM-as-a-judge.<br/>
        /// @default 'ai'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AssistantMessageJudgePlanAITypeJsonConverter))]
        public global::G.AssistantMessageJudgePlanAIType Type { get; set; }

        /// <summary>
        /// This is the flag to enable automatically adding the liquid variable {{messages}} to the model's messages array<br/>
        /// This is only applicable if the user has not provided any messages in the model's messages array<br/>
        /// @default true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoIncludeMessageHistory")]
        public bool? AutoIncludeMessageHistory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageJudgePlanAI" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the model to use for the LLM-as-a-judge.<br/>
        /// If not provided, will default to the assistant's model.<br/>
        /// The instructions on how to evaluate the model output with this LLM-Judge must be passed as a system message in the messages array of the model.<br/>
        /// The Mock conversation can be passed to the LLM-Judge to evaluate using the prompt {{messages}} and will be evaluated as a LiquidJS Variable. To access and judge only the last message, use {{messages[-1]}}<br/>
        /// The LLM-Judge must respond with "pass" or "fail" and only those two responses are allowed.<br/>
        /// Example: {
        /// </param>
        /// <param name="type">
        /// This is the type of the judge plan.<br/>
        /// Use 'ai' to evaluate the assistant message content using LLM-as-a-judge.<br/>
        /// @default 'ai'
        /// </param>
        /// <param name="autoIncludeMessageHistory">
        /// This is the flag to enable automatically adding the liquid variable {{messages}} to the model's messages array<br/>
        /// This is only applicable if the user has not provided any messages in the model's messages array<br/>
        /// @default true
        /// </param>
        public AssistantMessageJudgePlanAI(
            global::G.OneOf<global::G.EvalOpenAIModel, global::G.EvalAnthropicModel, global::G.EvalGoogleModel, global::G.EvalCustomModel> model,
            global::G.AssistantMessageJudgePlanAIType type,
            bool? autoIncludeMessageHistory)
        {
            this.Model = model;
            this.Type = type;
            this.AutoIncludeMessageHistory = autoIncludeMessageHistory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageJudgePlanAI" /> class.
        /// </summary>
        public AssistantMessageJudgePlanAI()
        {
        }
    }
}