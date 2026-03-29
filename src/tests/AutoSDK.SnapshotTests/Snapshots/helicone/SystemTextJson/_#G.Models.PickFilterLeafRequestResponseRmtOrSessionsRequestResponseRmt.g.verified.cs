//HintName: G.Models.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_response_rmt")]
        public global::G.PartialRequestResponseRMTToOperators? RequestResponseRmt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions_request_response_rmt")]
        public global::G.PartialSessionsRequestResponseRMTToOperators? SessionsRequestResponseRmt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt" /> class.
        /// </summary>
        /// <param name="requestResponseRmt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionsRequestResponseRmt">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt(
            global::G.PartialRequestResponseRMTToOperators? requestResponseRmt,
            global::G.PartialSessionsRequestResponseRMTToOperators? sessionsRequestResponseRmt)
        {
            this.RequestResponseRmt = requestResponseRmt;
            this.SessionsRequestResponseRmt = sessionsRequestResponseRmt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt" /> class.
        /// </summary>
        public PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt()
        {
        }
    }
}