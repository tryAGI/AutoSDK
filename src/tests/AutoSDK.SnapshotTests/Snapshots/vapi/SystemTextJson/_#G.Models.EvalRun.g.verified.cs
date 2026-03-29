//HintName: G.Models.EvalRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalRun
    {
        /// <summary>
        /// This is the status of the eval run. When an eval run is created, the status is 'running'.<br/>
        /// When the eval run is completed, the status is 'ended'.<br/>
        /// Example: running
        /// </summary>
        /// <example>running</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalRunStatus Status { get; set; }

        /// <summary>
        /// This is the reason for the eval run to end.<br/>
        /// When the eval run is completed normally i.e end of mock conversation, the status is 'mockConversation.done'.<br/>
        /// When the eval fails due to an error like Chat error or incorrect configuration, the status is 'error'.<br/>
        /// When the eval runs for too long, due to model issues or tool call issues, the status is 'timeout'.<br/>
        /// When the eval run is cancelled by the user, the status is 'cancelled'.<br/>
        /// When the eval run is cancelled by Vapi for any reason, the status is 'aborted'.<br/>
        /// Example: mockConversation.done
        /// </summary>
        /// <example>mockConversation.done</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalRunEndedReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalRunEndedReason EndedReason { get; set; }

        /// <summary>
        /// This is the transient eval that will be run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval")]
        public global::G.CreateEvalDTO? Eval { get; set; }

        /// <summary>
        /// This is the target that will be run against the eval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.EvalRunTargetAssistant, global::G.EvalRunTargetSquad>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.EvalRunTargetAssistant, global::G.EvalRunTargetSquad> Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndedAt { get; set; }

        /// <summary>
        /// This is the ended message when the eval run ended for any reason apart from mockConversation.done<br/>
        /// Example: The Assistant returned an error
        /// </summary>
        /// <example>The Assistant returned an error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedMessage")]
        public string? EndedMessage { get; set; }

        /// <summary>
        /// This is the results of the eval or suite run.<br/>
        /// The array will have a single item for an eval run, and multiple items each corresponding to the an eval in a suite run in the same order as the evals in the suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EvalRunResult> Results { get; set; }

        /// <summary>
        /// This is the cost of the eval or suite run in USD.<br/>
        /// Example: 0.01F
        /// </summary>
        /// <example>0.01F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// This is the break up of costs of the eval or suite run.<br/>
        /// Example: [{ type: "model", model: "gpt-4o", cost: 0.01 }]
        /// </summary>
        /// <example>[{ type: "model", model: "gpt-4o", cost: 0.01 }]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("costs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Costs { get; set; }

        /// <summary>
        /// This is the type of the run.<br/>
        /// Currently it is fixed to `eval`.<br/>
        /// Example: eval
        /// </summary>
        /// <example>eval</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalRunTypeJsonConverter))]
        public global::G.EvalRunType Type { get; set; }

        /// <summary>
        /// This is the id of the eval that will be run.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("evalId")]
        public string? EvalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRun" /> class.
        /// </summary>
        /// <param name="status">
        /// This is the status of the eval run. When an eval run is created, the status is 'running'.<br/>
        /// When the eval run is completed, the status is 'ended'.<br/>
        /// Example: running
        /// </param>
        /// <param name="endedReason">
        /// This is the reason for the eval run to end.<br/>
        /// When the eval run is completed normally i.e end of mock conversation, the status is 'mockConversation.done'.<br/>
        /// When the eval fails due to an error like Chat error or incorrect configuration, the status is 'error'.<br/>
        /// When the eval runs for too long, due to model issues or tool call issues, the status is 'timeout'.<br/>
        /// When the eval run is cancelled by the user, the status is 'cancelled'.<br/>
        /// When the eval run is cancelled by Vapi for any reason, the status is 'aborted'.<br/>
        /// Example: mockConversation.done
        /// </param>
        /// <param name="target">
        /// This is the target that will be run against the eval
        /// </param>
        /// <param name="id"></param>
        /// <param name="orgId"></param>
        /// <param name="createdAt"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="results">
        /// This is the results of the eval or suite run.<br/>
        /// The array will have a single item for an eval run, and multiple items each corresponding to the an eval in a suite run in the same order as the evals in the suite.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the eval or suite run in USD.<br/>
        /// Example: 0.01F
        /// </param>
        /// <param name="costs">
        /// This is the break up of costs of the eval or suite run.<br/>
        /// Example: [{ type: "model", model: "gpt-4o", cost: 0.01 }]
        /// </param>
        /// <param name="eval">
        /// This is the transient eval that will be run
        /// </param>
        /// <param name="endedMessage">
        /// This is the ended message when the eval run ended for any reason apart from mockConversation.done<br/>
        /// Example: The Assistant returned an error
        /// </param>
        /// <param name="type">
        /// This is the type of the run.<br/>
        /// Currently it is fixed to `eval`.<br/>
        /// Example: eval
        /// </param>
        /// <param name="evalId">
        /// This is the id of the eval that will be run.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalRun(
            global::G.EvalRunStatus status,
            global::G.EvalRunEndedReason endedReason,
            global::G.OneOf<global::G.EvalRunTargetAssistant, global::G.EvalRunTargetSquad> target,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime startedAt,
            global::System.DateTime endedAt,
            global::System.Collections.Generic.IList<global::G.EvalRunResult> results,
            double cost,
            global::System.Collections.Generic.IList<object> costs,
            global::G.CreateEvalDTO? eval,
            string? endedMessage,
            global::G.EvalRunType type,
            string? evalId)
        {
            this.Status = status;
            this.EndedReason = endedReason;
            this.Eval = eval;
            this.Target = target;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.EndedMessage = endedMessage;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Cost = cost;
            this.Costs = costs ?? throw new global::System.ArgumentNullException(nameof(costs));
            this.Type = type;
            this.EvalId = evalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRun" /> class.
        /// </summary>
        public EvalRun()
        {
        }
    }
}