//HintName: G.Models.IngestErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error response data for validation and other errors returned by the Ingest API.
    /// </summary>
    public sealed partial class IngestErrorResponse
    {
        /// <summary>
        /// An array of errors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.IngestErrorResponseData> Errors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestErrorResponse" /> class.
        /// </summary>
        /// <param name="errors">
        /// An array of errors.
        /// </param>
        public IngestErrorResponse(
            global::System.Collections.Generic.IList<global::G.IngestErrorResponseData> errors)
        {
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestErrorResponse" /> class.
        /// </summary>
        public IngestErrorResponse()
        {
        }
    }
}