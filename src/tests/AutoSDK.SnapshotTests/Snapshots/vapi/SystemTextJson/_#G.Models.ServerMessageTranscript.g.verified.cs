//HintName: G.Models.ServerMessageTranscript.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageTranscript
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>))]
        public global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "transcript" is sent as transcriber outputs partial or final transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ServerMessageTranscriptTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ServerMessageTranscriptType Type { get; set; }

        /// <summary>
        /// This is the timestamp of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// This is a live version of the `call.artifact`.<br/>
        /// This matches what is stored on `call.artifact` after the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact")]
        public global::G.Artifact? Artifact { get; set; }

        /// <summary>
        /// This is the assistant that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// This is the customer that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer")]
        public global::G.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// This is the call that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call")]
        public global::G.Call? Call { get; set; }

        /// <summary>
        /// This is the chat object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        public global::G.Chat? Chat { get; set; }

        /// <summary>
        /// This is the role for which the transcript is for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ServerMessageTranscriptRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ServerMessageTranscriptRole Role { get; set; }

        /// <summary>
        /// This is the type of the transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ServerMessageTranscriptTranscriptTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ServerMessageTranscriptTranscriptType TranscriptType { get; set; }

        /// <summary>
        /// This is the transcript content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Indicates if the transcript was filtered for security reasons.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFiltered")]
        public bool? IsFiltered { get; set; }

        /// <summary>
        /// List of detected security threats if the transcript was filtered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectedThreats")]
        public global::System.Collections.Generic.IList<string>? DetectedThreats { get; set; }

        /// <summary>
        /// The original transcript before filtering (only included if content was filtered).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalTranscript")]
        public string? OriginalTranscript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageTranscript" /> class.
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
        /// <param name="artifact">
        /// This is a live version of the `call.artifact`.<br/>
        /// This matches what is stored on `call.artifact` after the call.
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
        /// <param name="isFiltered">
        /// Indicates if the transcript was filtered for security reasons.
        /// </param>
        /// <param name="detectedThreats">
        /// List of detected security threats if the transcript was filtered.
        /// </param>
        /// <param name="originalTranscript">
        /// The original transcript before filtering (only included if content was filtered).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessageTranscript(
            global::G.ServerMessageTranscriptType type,
            global::G.ServerMessageTranscriptRole role,
            global::G.ServerMessageTranscriptTranscriptType transcriptType,
            string transcript,
            global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            double? timestamp,
            global::G.Artifact? artifact,
            global::G.CreateAssistantDTO? assistant,
            global::G.CreateCustomerDTO? customer,
            global::G.Call? call,
            global::G.Chat? chat,
            bool? isFiltered,
            global::System.Collections.Generic.IList<string>? detectedThreats,
            string? originalTranscript)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Timestamp = timestamp;
            this.Artifact = artifact;
            this.Assistant = assistant;
            this.Customer = customer;
            this.Call = call;
            this.Chat = chat;
            this.Role = role;
            this.TranscriptType = transcriptType;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.IsFiltered = isFiltered;
            this.DetectedThreats = detectedThreats;
            this.OriginalTranscript = originalTranscript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageTranscript" /> class.
        /// </summary>
        public ServerMessageTranscript()
        {
        }
    }
}