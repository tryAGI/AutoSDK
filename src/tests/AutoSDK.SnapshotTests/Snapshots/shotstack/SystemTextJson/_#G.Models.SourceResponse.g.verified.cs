//HintName: G.Models.SourceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response returned by the Ingest API [get source](#get-source) request. Includes details of the ingested source file. The response follows the [json:api](https://jsonapi.org/) specification.
    /// </summary>
    public sealed partial class SourceResponse
    {
        /// <summary>
        /// The type of resource (a source), it's id and attributes of the source file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SourceResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The type of resource (a source), it's id and attributes of the source file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceResponse(
            global::G.SourceResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceResponse" /> class.
        /// </summary>
        public SourceResponse()
        {
        }
    }
}