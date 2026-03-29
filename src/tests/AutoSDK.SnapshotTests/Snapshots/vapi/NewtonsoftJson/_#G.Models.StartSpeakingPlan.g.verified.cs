//HintName: G.Models.StartSpeakingPlan.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartSpeakingPlan
    {
        /// <summary>
        /// This is how long assistant waits before speaking. Defaults to 0.4.<br/>
        /// This is the minimum it will wait but if there is latency is the pipeline, this minimum will be exceeded. This is intended as a stopgap in case the pipeline is moving too fast.<br/>
        /// Example:<br/>
        /// - If model generates tokens and voice generates bytes within 100ms, the pipeline still waits 300ms before outputting speech.<br/>
        /// Usage:<br/>
        /// - If the customer is taking long pauses, set this to a higher value.<br/>
        /// - If the assistant is accidentally jumping in too much, set this to a higher value.<br/>
        /// @default 0.4<br/>
        /// Example: 0.4F
        /// </summary>
        /// <example>0.4F</example>
        [global::Newtonsoft.Json.JsonProperty("waitSeconds")]
        public double? WaitSeconds { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("smartEndpointingEnabled")]
        public global::G.OneOf<bool?, global::G.StartSpeakingPlanSmartEndpointingEnabled?>? SmartEndpointingEnabled { get; set; }

        /// <summary>
        /// This is the plan for smart endpointing. Pick between Vapi smart endpointing, LiveKit, or custom endpointing model (or nothing). We strongly recommend using livekit endpointing when working in English. LiveKit endpointing is not supported in other languages, yet.<br/>
        /// If this is set, it will override and take precedence over `transcriptionEndpointingPlan`.<br/>
        /// This plan will still be overridden by any matching `customEndpointingRules`.<br/>
        /// If this is not set, the system will automatically use the transcriber's built-in endpointing capabilities if available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smartEndpointingPlan")]
        public global::G.OneOf<global::G.VapiSmartEndpointingPlan, global::G.LivekitSmartEndpointingPlan, global::G.CustomEndpointingModelSmartEndpointingPlan>? SmartEndpointingPlan { get; set; }

        /// <summary>
        /// These are the custom endpointing rules to set an endpointing timeout based on a regex on the customer's speech or the assistant's last message.<br/>
        /// Usage:<br/>
        /// - If you have yes/no questions like "are you interested in a loan?", you can set a shorter timeout.<br/>
        /// - If you have questions where the customer may pause to look up information like "what's my account number?", you can set a longer timeout.<br/>
        /// - If you want to wait longer while customer is enumerating a list of numbers, you can set a longer timeout.<br/>
        /// These rules have the highest precedence and will override both `smartEndpointingPlan` and `transcriptionEndpointingPlan` when a rule is matched.<br/>
        /// The rules are evaluated in order and the first one that matches will be used.<br/>
        /// Order of precedence for endpointing:<br/>
        /// 1. customEndpointingRules (if any match)<br/>
        /// 2. smartEndpointingPlan (if set)<br/>
        /// 3. transcriptionEndpointingPlan<br/>
        /// @default []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customEndpointingRules")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.AssistantCustomEndpointingRule, global::G.CustomerCustomEndpointingRule, global::G.BothCustomEndpointingRule>>? CustomEndpointingRules { get; set; }

        /// <summary>
        /// This determines how a customer speech is considered done (endpointing) using the transcription of customer's speech.<br/>
        /// Once an endpoint is triggered, the request is sent to `assistant.model`.<br/>
        /// Note: This plan is only used if `smartEndpointingPlan` is not set and transcriber does not have built-in endpointing capabilities. If both are provided, `smartEndpointingPlan` takes precedence.<br/>
        /// This plan will also be overridden by any matching `customEndpointingRules`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptionEndpointingPlan")]
        public global::G.TranscriptionEndpointingPlan? TranscriptionEndpointingPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartSpeakingPlan" /> class.
        /// </summary>
        /// <param name="waitSeconds">
        /// This is how long assistant waits before speaking. Defaults to 0.4.<br/>
        /// This is the minimum it will wait but if there is latency is the pipeline, this minimum will be exceeded. This is intended as a stopgap in case the pipeline is moving too fast.<br/>
        /// Example:<br/>
        /// - If model generates tokens and voice generates bytes within 100ms, the pipeline still waits 300ms before outputting speech.<br/>
        /// Usage:<br/>
        /// - If the customer is taking long pauses, set this to a higher value.<br/>
        /// - If the assistant is accidentally jumping in too much, set this to a higher value.<br/>
        /// @default 0.4<br/>
        /// Example: 0.4F
        /// </param>
        /// <param name="smartEndpointingPlan">
        /// This is the plan for smart endpointing. Pick between Vapi smart endpointing, LiveKit, or custom endpointing model (or nothing). We strongly recommend using livekit endpointing when working in English. LiveKit endpointing is not supported in other languages, yet.<br/>
        /// If this is set, it will override and take precedence over `transcriptionEndpointingPlan`.<br/>
        /// This plan will still be overridden by any matching `customEndpointingRules`.<br/>
        /// If this is not set, the system will automatically use the transcriber's built-in endpointing capabilities if available.
        /// </param>
        /// <param name="customEndpointingRules">
        /// These are the custom endpointing rules to set an endpointing timeout based on a regex on the customer's speech or the assistant's last message.<br/>
        /// Usage:<br/>
        /// - If you have yes/no questions like "are you interested in a loan?", you can set a shorter timeout.<br/>
        /// - If you have questions where the customer may pause to look up information like "what's my account number?", you can set a longer timeout.<br/>
        /// - If you want to wait longer while customer is enumerating a list of numbers, you can set a longer timeout.<br/>
        /// These rules have the highest precedence and will override both `smartEndpointingPlan` and `transcriptionEndpointingPlan` when a rule is matched.<br/>
        /// The rules are evaluated in order and the first one that matches will be used.<br/>
        /// Order of precedence for endpointing:<br/>
        /// 1. customEndpointingRules (if any match)<br/>
        /// 2. smartEndpointingPlan (if set)<br/>
        /// 3. transcriptionEndpointingPlan<br/>
        /// @default []
        /// </param>
        /// <param name="transcriptionEndpointingPlan">
        /// This determines how a customer speech is considered done (endpointing) using the transcription of customer's speech.<br/>
        /// Once an endpoint is triggered, the request is sent to `assistant.model`.<br/>
        /// Note: This plan is only used if `smartEndpointingPlan` is not set and transcriber does not have built-in endpointing capabilities. If both are provided, `smartEndpointingPlan` takes precedence.<br/>
        /// This plan will also be overridden by any matching `customEndpointingRules`.
        /// </param>
        public StartSpeakingPlan(
            double? waitSeconds,
            global::G.OneOf<global::G.VapiSmartEndpointingPlan, global::G.LivekitSmartEndpointingPlan, global::G.CustomEndpointingModelSmartEndpointingPlan>? smartEndpointingPlan,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AssistantCustomEndpointingRule, global::G.CustomerCustomEndpointingRule, global::G.BothCustomEndpointingRule>>? customEndpointingRules,
            global::G.TranscriptionEndpointingPlan? transcriptionEndpointingPlan)
        {
            this.WaitSeconds = waitSeconds;
            this.SmartEndpointingPlan = smartEndpointingPlan;
            this.CustomEndpointingRules = customEndpointingRules;
            this.TranscriptionEndpointingPlan = transcriptionEndpointingPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartSpeakingPlan" /> class.
        /// </summary>
        public StartSpeakingPlan()
        {
        }
    }
}