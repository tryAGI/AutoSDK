//HintName: G.Models.ServerMessageVoiceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageVoiceRequest
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>))]
        public global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "voice-request" is sent when using `assistant.voice={ "type": "custom-voice" }`.<br/>
        /// Here is what the request will look like:<br/>
        /// POST https://{assistant.voice.server.url}<br/>
        /// Content-Type: application/json<br/>
        /// {<br/>
        ///   "messsage": {<br/>
        ///     "type": "voice-request",<br/>
        ///     "text": "Hello, world!",<br/>
        ///     "sampleRate": 24000,<br/>
        ///     ...other metadata about the call...<br/>
        ///   }<br/>
        /// }<br/>
        /// The expected response is 1-channel 16-bit raw PCM audio at the sample rate specified in the request. Here is how the response will be piped to the transport:<br/>
        /// ```<br/>
        /// response.on('data', (chunk: Buffer) =&gt; {<br/>
        ///   outputStream.write(chunk);<br/>
        /// });<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ServerMessageVoiceRequestTypeJsonConverter))]
        public global::G.ServerMessageVoiceRequestType Type { get; set; }

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
        /// This is the text to be synthesized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// This is the sample rate to be synthesized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SampleRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageVoiceRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// This is the text to be synthesized.
        /// </param>
        /// <param name="sampleRate">
        /// This is the sample rate to be synthesized.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "voice-request" is sent when using `assistant.voice={ "type": "custom-voice" }`.<br/>
        /// Here is what the request will look like:<br/>
        /// POST https://{assistant.voice.server.url}<br/>
        /// Content-Type: application/json<br/>
        /// {<br/>
        ///   "messsage": {<br/>
        ///     "type": "voice-request",<br/>
        ///     "text": "Hello, world!",<br/>
        ///     "sampleRate": 24000,<br/>
        ///     ...other metadata about the call...<br/>
        ///   }<br/>
        /// }<br/>
        /// The expected response is 1-channel 16-bit raw PCM audio at the sample rate specified in the request. Here is how the response will be piped to the transport:<br/>
        /// ```<br/>
        /// response.on('data', (chunk: Buffer) =&gt; {<br/>
        ///   outputStream.write(chunk);<br/>
        /// });<br/>
        /// ```
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessageVoiceRequest(
            string text,
            double sampleRate,
            global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::G.ServerMessageVoiceRequestType type,
            double? timestamp,
            global::G.Artifact? artifact,
            global::G.CreateAssistantDTO? assistant,
            global::G.CreateCustomerDTO? customer,
            global::G.Call? call,
            global::G.Chat? chat)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Timestamp = timestamp;
            this.Artifact = artifact;
            this.Assistant = assistant;
            this.Customer = customer;
            this.Call = call;
            this.Chat = chat;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageVoiceRequest" /> class.
        /// </summary>
        public ServerMessageVoiceRequest()
        {
        }
    }
}