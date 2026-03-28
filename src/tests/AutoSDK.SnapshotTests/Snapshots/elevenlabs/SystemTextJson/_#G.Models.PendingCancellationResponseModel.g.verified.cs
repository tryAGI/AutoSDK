//HintName: G.Models.PendingCancellationResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingCancellationResponseModel
    {
        /// <summary>
        /// Default Value: cancellation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The timestamp of the cancellation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimestampSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingCancellationResponseModel" /> class.
        /// </summary>
        /// <param name="timestampSeconds">
        /// The timestamp of the cancellation.
        /// </param>
        /// <param name="kind">
        /// Default Value: cancellation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PendingCancellationResponseModel(
            int timestampSeconds,
            string? kind)
        {
            this.Kind = kind;
            this.TimestampSeconds = timestampSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingCancellationResponseModel" /> class.
        /// </summary>
        public PendingCancellationResponseModel()
        {
        }
    }
}