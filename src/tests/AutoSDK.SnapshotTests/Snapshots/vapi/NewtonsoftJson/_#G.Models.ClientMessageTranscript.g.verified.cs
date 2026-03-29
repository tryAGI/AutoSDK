//HintName: G.Models.ClientMessageTranscript.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientMessageTranscript
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumber")]
        public global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "transcript" is sent as transcriber outputs partial or final transcript.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ClientMessageTranscriptType Type { get; set; } = default!;

        /// <summary>
        /// This is the timestamp of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// This is the call that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call")]
        public global::G.Call? Call { get; set; }

        /// <summary>
        /// This is the customer that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer")]
        public global::G.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// This is the assistant that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// This is the role for which the transcript is for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ClientMessageTranscriptRole Role { get; set; } = default!;

        /// <summary>
        /// This is the type of the transcript.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptType", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ClientMessageTranscriptTranscriptType TranscriptType { get; set; } = default!;

        /// <summary>
        /// This is the transcript content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public string Transcript { get; set; } = default!;

        /// <summary>
        /// Indicates if the transcript was filtered for security reasons.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isFiltered")]
        public bool? IsFiltered { get; set; }

        /// <summary>
        /// List of detected security threats if the transcript was filtered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detectedThreats")]
        public global::System.Collections.Generic.IList<string>? DetectedThreats { get; set; }

        /// <summary>
        /// The original transcript before filtering (only included if content was filtered).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("originalTranscript")]
        public string? OriginalTranscript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageTranscript" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of the message. "transcript" is sent as transcriber outputs partial or final transcript.
        /// </param>
        /// <param name="role">
        /// This is the role for which the transcript is for.
        /// </param>
        /// <param name="transcriptType">
        /// This is the type of the transcript.
        /// </param>
        /// <param name="transcript">
        /// This is the transcript content.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="timestamp">
        /// This is the timestamp of the message.
        /// </param>
        /// <param name="call">
        /// This is the call that the message is associated with.
        /// </param>
        /// <param name="customer">
        /// This is the customer that the message is associated with.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that the message is associated with.
        /// </param>
        /// <param name="isFiltered">
        /// Indicates if the transcript was filtered for security reasons.
        /// </param>
        /// <param name="detectedThreats">
        /// List of detected security threats if the transcript was filtered.
        /// </param>
        /// <param name="originalTranscript">
        /// The original transcript before filtering (only included if content was filtered).
        /// </param>
        public ClientMessageTranscript(
            global::G.ClientMessageTranscriptType type,
            global::G.ClientMessageTranscriptRole role,
            global::G.ClientMessageTranscriptTranscriptType transcriptType,
            string transcript,
            global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            double? timestamp,
            global::G.Call? call,
            global::G.CreateCustomerDTO? customer,
            global::G.CreateAssistantDTO? assistant,
            bool? isFiltered,
            global::System.Collections.Generic.IList<string>? detectedThreats,
            string? originalTranscript)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Timestamp = timestamp;
            this.Call = call;
            this.Customer = customer;
            this.Assistant = assistant;
            this.Role = role;
            this.TranscriptType = transcriptType;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.IsFiltered = isFiltered;
            this.DetectedThreats = detectedThreats;
            this.OriginalTranscript = originalTranscript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageTranscript" /> class.
        /// </summary>
        public ClientMessageTranscript()
        {
        }
    }
}