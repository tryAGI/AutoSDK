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
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The timestamp of the cancellation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public int TimestampSeconds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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