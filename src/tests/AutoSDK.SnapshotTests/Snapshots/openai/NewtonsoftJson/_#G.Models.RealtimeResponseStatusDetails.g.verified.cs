//HintName: G.Models.RealtimeResponseStatusDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional details about the status.
    /// </summary>
    public sealed partial class RealtimeResponseStatusDetails
    {
        /// <summary>
        /// The type of error that caused the response to fail, corresponding <br/>
        /// with the `status` field (`cancelled`, `incomplete`, `failed`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeResponseStatusDetailsType? Type { get; set; }

        /// <summary>
        /// The reason the Response did not complete. For a `cancelled` Response, <br/>
        /// one of `turn_detected` (the server VAD detected a new start of speech) <br/>
        /// or `client_cancelled` (the client sent a cancel event). For an <br/>
        /// `incomplete` Response, one of `max_output_tokens` or `content_filter` <br/>
        /// (the server-side safety filter activated and cut off the response).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public global::G.RealtimeResponseStatusDetailsReason? Reason { get; set; }

        /// <summary>
        /// A description of the error that caused the response to fail, <br/>
        /// populated when the `status` is `failed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.RealtimeResponseStatusDetailsError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseStatusDetails" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of error that caused the response to fail, corresponding <br/>
        /// with the `status` field (`cancelled`, `incomplete`, `failed`).
        /// </param>
        /// <param name="reason">
        /// The reason the Response did not complete. For a `cancelled` Response, <br/>
        /// one of `turn_detected` (the server VAD detected a new start of speech) <br/>
        /// or `client_cancelled` (the client sent a cancel event). For an <br/>
        /// `incomplete` Response, one of `max_output_tokens` or `content_filter` <br/>
        /// (the server-side safety filter activated and cut off the response).
        /// </param>
        /// <param name="error">
        /// A description of the error that caused the response to fail, <br/>
        /// populated when the `status` is `failed`.
        /// </param>
        public RealtimeResponseStatusDetails(
            global::G.RealtimeResponseStatusDetailsType? type,
            global::G.RealtimeResponseStatusDetailsReason? reason,
            global::G.RealtimeResponseStatusDetailsError? error)
        {
            this.Type = type;
            this.Reason = reason;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseStatusDetails" /> class.
        /// </summary>
        public RealtimeResponseStatusDetails()
        {
        }
    }
}