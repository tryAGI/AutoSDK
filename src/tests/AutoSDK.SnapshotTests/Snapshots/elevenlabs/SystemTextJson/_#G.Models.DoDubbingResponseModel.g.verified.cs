//HintName: G.Models.DoDubbingResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DoDubbingResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubbing_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DubbingId { get; set; }

        /// <summary>
        /// 
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
        /// <param name="dubbingId"></param>
        /// <param name="expectedDurationSec"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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