//HintName: G.Models.StreamingNewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingNewRequest
    {
        /// <summary>
        /// Example: medium
        /// </summary>
        /// <example>medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public string? Quality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingNewRequest" /> class.
        /// </summary>
        /// <param name="quality">
        /// Example: medium
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StreamingNewRequest(
            string? quality)
        {
            this.Quality = quality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingNewRequest" /> class.
        /// </summary>
        public StreamingNewRequest()
        {
        }
    }
}