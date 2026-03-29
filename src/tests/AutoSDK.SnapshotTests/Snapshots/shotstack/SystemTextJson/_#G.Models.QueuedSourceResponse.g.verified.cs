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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.QueuedSourceResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueuedSourceResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The type of resource (a source) and the newly created source id. Returned with [QueuedSourceResponse](#tocs_queuedsourceresponse).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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