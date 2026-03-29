//HintName: G.Models.SourceListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of all ingested source files fetched or uploaded to a users account.
    /// </summary>
    public sealed partial class SourceListResponse
    {
        /// <summary>
        /// An array of ingested source files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SourceResponseData> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// An array of ingested source files.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceListResponse(
            global::System.Collections.Generic.IList<global::G.SourceResponseData> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceListResponse" /> class.
        /// </summary>
        public SourceListResponse()
        {
        }
    }
}