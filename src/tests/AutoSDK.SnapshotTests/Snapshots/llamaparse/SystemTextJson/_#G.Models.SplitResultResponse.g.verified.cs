//HintName: G.Models.SplitResultResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result of a completed split job.
    /// </summary>
    public sealed partial class SplitResultResponse
    {
        /// <summary>
        /// List of document segments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SplitSegmentResponse> Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitResultResponse" /> class.
        /// </summary>
        /// <param name="segments">
        /// List of document segments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitResultResponse(
            global::System.Collections.Generic.IList<global::G.SplitSegmentResponse> segments)
        {
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitResultResponse" /> class.
        /// </summary>
        public SplitResultResponse()
        {
        }
    }
}