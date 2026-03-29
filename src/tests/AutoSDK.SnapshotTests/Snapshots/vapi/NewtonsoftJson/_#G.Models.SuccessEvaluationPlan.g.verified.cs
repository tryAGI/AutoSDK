//HintName: G.Models.SuccessEvaluationPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SuccessEvaluationPlan
    {
        /// <summary>
        /// This enforces the rubric of the evaluation. The output is stored in `call.analysis.successEvaluation`.<br/>
        /// Options include:<br/>
        /// - 'NumericScale': A scale of 1 to 10.<br/>
        /// - 'DescriptiveScale': A scale of Excellent, Good, Fair, Poor.<br/>
        /// - 'Checklist': A checklist of criteria and their status.<br/>
        /// - 'Matrix': A grid that evaluates multiple criteria across different performance levels.<br/>
        /// - 'PercentageScale': A scale of 0% to 100%.<br/>
        /// - 'LikertScale': A scale of Strongly Agree, Agree, Neutral, Disagree, Strongly Disagree.<br/>
        /// - 'AutomaticRubric': Automatically break down evaluation into several criteria, each with its own score.<br/>
        /// - 'PassFail': A simple 'true' if call passed, 'false' if not.<br/>
        /// Default is 'PassFail'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rubric")]
        public global::G.SuccessEvaluationPlanRubric? Rubric { get; set; }

        /// <summary>
        /// These are the messages used to generate the success evaluation.<br/>
        /// @default: ```<br/>
        /// [<br/>
        ///   {<br/>
        ///     "role": "system",<br/>
        ///     "content": "You are an expert call evaluator. You will be given a transcript of a call and the system prompt of the AI participant. Determine if the call was successful based on the objectives inferred from the system prompt. DO NOT return anything except the result.\n\nRubric:\\n{{rubric}}\n\nOnly respond with the result."<br/>
        ///   },<br/>
        ///   {<br/>
        ///     "role": "user",<br/>
        ///     "content": "Here is the transcript:\n\n{{transcript}}\n\n"<br/>
        ///   },<br/>
        ///   {<br/>
        ///     "role": "user",<br/>
        ///     "content": "Here was the system prompt of the call:\n\n{{systemPrompt}}\n\n. Here is the ended reason of the call:\n\n{{endedReason}}\n\n"<br/>
        ///   }<br/>
        /// ]```<br/>
        /// You can customize by providing any messages you want.<br/>
        /// Here are the template variables available:<br/>
        /// - {{transcript}}: the transcript of the call from `call.artifact.transcript`- {{systemPrompt}}: the system prompt of the call from `assistant.model.messages[type=system].content`- {{messages}}: the messages of the call from `assistant.model.messages`- {{rubric}}: the rubric of the success evaluation from `successEvaluationPlan.rubric`- {{endedReason}}: the ended reason of the call from `call.endedReason`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<object>? Messages { get; set; }

        /// <summary>
        /// This determines whether a success evaluation is generated and stored in `call.analysis.successEvaluation`. Defaults to true.<br/>
        /// Usage:<br/>
        /// - If you want to disable the success evaluation, set this to false.<br/>
        /// @default true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This is how long the request is tried before giving up. When request times out, `call.analysis.successEvaluation` will be empty.<br/>
        /// Usage:<br/>
        /// - To guarantee the success evaluation is generated, set this value high. Note, this will delay the end of call report in cases where model is slow to respond.<br/>
        /// @default 5 seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessEvaluationPlan" /> class.
        /// </summary>
        /// <param name="rubric">
        /// This enforces the rubric of the evaluation. The output is stored in `call.analysis.successEvaluation`.<br/>
        /// Options include:<br/>
        /// - 'NumericScale': A scale of 1 to 10.<br/>
        /// - 'DescriptiveScale': A scale of Excellent, Good, Fair, Poor.<br/>
        /// - 'Checklist': A checklist of criteria and their status.<br/>
        /// - 'Matrix': A grid that evaluates multiple criteria across different performance levels.<br/>
        /// - 'PercentageScale': A scale of 0% to 100%.<br/>
        /// - 'LikertScale': A scale of Strongly Agree, Agree, Neutral, Disagree, Strongly Disagree.<br/>
        /// - 'AutomaticRubric': Automatically break down evaluation into several criteria, each with its own score.<br/>
        /// - 'PassFail': A simple 'true' if call passed, 'false' if not.<br/>
        /// Default is 'PassFail'.
        /// </param>
        /// <param name="messages">
        /// These are the messages used to generate the success evaluation.<br/>
        /// @default: ```<br/>
        /// [<br/>
        ///   {<br/>
        ///     "role": "system",<br/>
        ///     "content": "You are an expert call evaluator. You will be given a transcript of a call and the system prompt of the AI participant. Determine if the call was successful based on the objectives inferred from the system prompt. DO NOT return anything except the result.\n\nRubric:\\n{{rubric}}\n\nOnly respond with the result."<br/>
        ///   },<br/>
        ///   {<br/>
        ///     "role": "user",<br/>
        ///     "content": "Here is the transcript:\n\n{{transcript}}\n\n"<br/>
        ///   },<br/>
        ///   {<br/>
        ///     "role": "user",<br/>
        ///     "content": "Here was the system prompt of the call:\n\n{{systemPrompt}}\n\n. Here is the ended reason of the call:\n\n{{endedReason}}\n\n"<br/>
        ///   }<br/>
        /// ]```<br/>
        /// You can customize by providing any messages you want.<br/>
        /// Here are the template variables available:<br/>
        /// - {{transcript}}: the transcript of the call from `call.artifact.transcript`- {{systemPrompt}}: the system prompt of the call from `assistant.model.messages[type=system].content`- {{messages}}: the messages of the call from `assistant.model.messages`- {{rubric}}: the rubric of the success evaluation from `successEvaluationPlan.rubric`- {{endedReason}}: the ended reason of the call from `call.endedReason`
        /// </param>
        /// <param name="enabled">
        /// This determines whether a success evaluation is generated and stored in `call.analysis.successEvaluation`. Defaults to true.<br/>
        /// Usage:<br/>
        /// - If you want to disable the success evaluation, set this to false.<br/>
        /// @default true
        /// </param>
        /// <param name="timeoutSeconds">
        /// This is how long the request is tried before giving up. When request times out, `call.analysis.successEvaluation` will be empty.<br/>
        /// Usage:<br/>
        /// - To guarantee the success evaluation is generated, set this value high. Note, this will delay the end of call report in cases where model is slow to respond.<br/>
        /// @default 5 seconds
        /// </param>
        public SuccessEvaluationPlan(
            global::G.SuccessEvaluationPlanRubric? rubric,
            global::System.Collections.Generic.IList<object>? messages,
            bool? enabled,
            double? timeoutSeconds)
        {
            this.Rubric = rubric;
            this.Messages = messages;
            this.Enabled = enabled;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessEvaluationPlan" /> class.
        /// </summary>
        public SuccessEvaluationPlan()
        {
        }
    }
}