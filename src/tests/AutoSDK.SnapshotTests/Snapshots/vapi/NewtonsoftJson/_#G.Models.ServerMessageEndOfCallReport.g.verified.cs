//HintName: G.Models.ServerMessageEndOfCallReport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageEndOfCallReport
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumber")]
        public global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "end-of-call-report" is sent when the call ends and post-processing is complete.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ServerMessageEndOfCallReportType Type { get; set; }

        /// <summary>
        /// This is the reason the call ended. This can also be found at `call.endedReason` on GET /call/:id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endedReason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ServerMessageEndOfCallReportEndedReason EndedReason { get; set; } = default!;

        /// <summary>
        /// This is the cost of the call in USD. This can also be found at `call.cost` on GET /call/:id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// These are the costs of individual components of the call in USD. This can also be found at `call.costs` on GET /call/:id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("costs")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.TransportCost, global::G.TranscriberCost, global::G.ModelCost, global::G.VoiceCost, global::G.VapiCost, global::G.VoicemailDetectionCost, global::G.AnalysisCost, global::G.KnowledgeBaseCost>>? Costs { get; set; }

        /// <summary>
        /// This is the destination the call was transferred to, if the call was forwarded.<br/>
        /// This can also be found at `call.destination` on GET /call/:id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination")]
        public global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? Destination { get; set; }

        /// <summary>
        /// This is the timestamp of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// These are the artifacts from the call. This can also be found at `call.artifact` on GET /call/:id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifact", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Artifact Artifact { get; set; } = default!;

        /// <summary>
        /// This is the assistant that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// This is the customer that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer")]
        public global::G.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// This is the call that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call")]
        public global::G.Call? Call { get; set; }

        /// <summary>
        /// This is the chat object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat")]
        public global::G.Chat? Chat { get; set; }

        /// <summary>
        /// This is the analysis of the call. This can also be found at `call.analysis` on GET /call/:id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("analysis", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Analysis Analysis { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the call started. This can also be found at `call.startedAt` on GET /call/:id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the call ended. This can also be found at `call.endedAt` on GET /call/:id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// This is the compliance result of the call. This can also be found at `call.compliance` on GET /call/:id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compliance")]
        public global::G.Compliance? Compliance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageEndOfCallReport" /> class.
        /// </summary>
        /// <param name="endedReason">
        /// This is the reason the call ended. This can also be found at `call.endedReason` on GET /call/:id.
        /// </param>
        /// <param name="artifact">
        /// These are the artifacts from the call. This can also be found at `call.artifact` on GET /call/:id.
        /// </param>
        /// <param name="analysis">
        /// This is the analysis of the call. This can also be found at `call.analysis` on GET /call/:id.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "end-of-call-report" is sent when the call ends and post-processing is complete.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the call in USD. This can also be found at `call.cost` on GET /call/:id.
        /// </param>
        /// <param name="costs">
        /// These are the costs of individual components of the call in USD. This can also be found at `call.costs` on GET /call/:id.
        /// </param>
        /// <param name="destination">
        /// This is the destination the call was transferred to, if the call was forwarded.<br/>
        /// This can also be found at `call.destination` on GET /call/:id.
        /// </param>
        /// <param name="timestamp">
        /// This is the timestamp of the message.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that the message is associated with.
        /// </param>
        /// <param name="customer">
        /// This is the customer that the message is associated with.
        /// </param>
        /// <param name="call">
        /// This is the call that the message is associated with.
        /// </param>
        /// <param name="chat">
        /// This is the chat object.
        /// </param>
        /// <param name="startedAt">
        /// This is the ISO 8601 date-time string of when the call started. This can also be found at `call.startedAt` on GET /call/:id.
        /// </param>
        /// <param name="endedAt">
        /// This is the ISO 8601 date-time string of when the call ended. This can also be found at `call.endedAt` on GET /call/:id.
        /// </param>
        /// <param name="compliance">
        /// This is the compliance result of the call. This can also be found at `call.compliance` on GET /call/:id.
        /// </param>
        public ServerMessageEndOfCallReport(
            global::G.ServerMessageEndOfCallReportEndedReason endedReason,
            global::G.Artifact artifact,
            global::G.Analysis analysis,
            global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::G.ServerMessageEndOfCallReportType type,
            double? cost,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.TransportCost, global::G.TranscriberCost, global::G.ModelCost, global::G.VoiceCost, global::G.VapiCost, global::G.VoicemailDetectionCost, global::G.AnalysisCost, global::G.KnowledgeBaseCost>>? costs,
            global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? destination,
            double? timestamp,
            global::G.CreateAssistantDTO? assistant,
            global::G.CreateCustomerDTO? customer,
            global::G.Call? call,
            global::G.Chat? chat,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            global::G.Compliance? compliance)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.EndedReason = endedReason;
            this.Cost = cost;
            this.Costs = costs;
            this.Destination = destination;
            this.Timestamp = timestamp;
            this.Artifact = artifact ?? throw new global::System.ArgumentNullException(nameof(artifact));
            this.Assistant = assistant;
            this.Customer = customer;
            this.Call = call;
            this.Chat = chat;
            this.Analysis = analysis ?? throw new global::System.ArgumentNullException(nameof(analysis));
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.Compliance = compliance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageEndOfCallReport" /> class.
        /// </summary>
        public ServerMessageEndOfCallReport()
        {
        }
    }
}