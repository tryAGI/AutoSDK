//HintName: G.Models.QueuedSourceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response returned by the Ingest API [fetch source](#fetch-source) request. Includes the id of the source file. The response follows the [json:api](https://jsonapi.org/) specification.
    /// </summary>
    public sealed partial class QueuedSourceResponse
    {
        /// <summary>
        /// The type of resource (a source) and the newly created source id. Returned with [QueuedSourceResponse](#tocs_queuedsourceresponse).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.QueuedSourceResponseData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueuedSourceResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The type of resource (a source) and the newly created source id. Returned with [QueuedSourceResponse](#tocs_queuedsourceresponse).
        /// </param>
        public QueuedSourceResponse(
            global::G.QueuedSourceResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueuedSourceResponse" /> class.
        /// </summary>
        public QueuedSourceResponse()
        {
        }
    }
}