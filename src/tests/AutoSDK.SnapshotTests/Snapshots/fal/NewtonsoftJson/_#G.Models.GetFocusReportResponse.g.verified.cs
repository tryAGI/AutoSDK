//HintName: G.Models.GetFocusReportResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Standard error response format
    /// </summary>
    public sealed partial class GetFocusReportResponse
    {
        /// <summary>
        /// Error details
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetFocusReportResponseError Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFocusReportResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error details
        /// </param>
        public GetFocusReportResponse(
            global::G.GetFocusReportResponseError error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFocusReportResponse" /> class.
        /// </summary>
        public GetFocusReportResponse()
        {
        }
    }
}