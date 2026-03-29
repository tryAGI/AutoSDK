//HintName: G.Models.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? Values { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public global::G.PartialResponseTableToOperators? Response { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request")]
        public global::G.PartialRequestTableToOperators? Request { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback")]
        public global::G.PartialFeedbackTableToOperators? Feedback { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_response_rmt")]
        public global::G.PartialRequestResponseRMTToOperators? RequestResponseRmt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessions_request_response_rmt")]
        public global::G.PartialSessionsRequestResponseRMTToOperators? SessionsRequestResponseRmt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt" /> class.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="response">
        /// Make all properties in T optional
        /// </param>
        /// <param name="request">
        /// Make all properties in T optional
        /// </param>
        /// <param name="feedback">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestResponseRmt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionsRequestResponseRmt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="properties"></param>
        public PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt(
            global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? values,
            global::G.PartialResponseTableToOperators? response,
            global::G.PartialRequestTableToOperators? request,
            global::G.PartialFeedbackTableToOperators? feedback,
            global::G.PartialRequestResponseRMTToOperators? requestResponseRmt,
            global::G.PartialSessionsRequestResponseRMTToOperators? sessionsRequestResponseRmt,
            global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? properties)
        {
            this.Values = values;
            this.Response = response;
            this.Request = request;
            this.Feedback = feedback;
            this.RequestResponseRmt = requestResponseRmt;
            this.SessionsRequestResponseRmt = sessionsRequestResponseRmt;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt" /> class.
        /// </summary>
        public PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt()
        {
        }
    }
}