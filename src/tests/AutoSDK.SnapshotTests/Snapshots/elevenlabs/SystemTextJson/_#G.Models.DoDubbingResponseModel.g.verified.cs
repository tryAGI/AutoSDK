//HintName: G.Models.DoDubbingResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"dubbing_id":"21m00Tcm4TlvDq8ikWAM","expected_duration_sec":127.5}
    /// </summary>
    public sealed partial class DoDubbingResponseModel
    {
        /// <summary>
        /// The ID of the dubbing project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubbing_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DubbingId { get; set; }

        /// <summary>
        /// The expected duration of the dubbing project in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_duration_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpectedDurationSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DoDubbingResponseModel" /> class.
        /// </summary>
        /// <param name="dubbingId">
        /// The ID of the dubbing project.
        /// </param>
        /// <param name="expectedDurationSec">
        /// The expected duration of the dubbing project in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DoDubbingResponseModel(
            string dubbingId,
            double expectedDurationSec)
        {
            this.DubbingId = dubbingId ?? throw new global::System.ArgumentNullException(nameof(dubbingId));
            this.ExpectedDurationSec = expectedDurationSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoDubbingResponseModel" /> class.
        /// </summary>
        public DoDubbingResponseModel()
        {
        }
    }
}