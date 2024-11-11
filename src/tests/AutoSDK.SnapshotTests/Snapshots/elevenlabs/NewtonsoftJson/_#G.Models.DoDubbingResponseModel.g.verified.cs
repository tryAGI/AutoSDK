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
        [global::Newtonsoft.Json.JsonProperty("dubbing_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DubbingId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected_duration_sec", Required = global::Newtonsoft.Json.Required.Always)]
        public double ExpectedDurationSec { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DoDubbingResponseModel" /> class.
        /// </summary>
        /// <param name="dubbingId"></param>
        /// <param name="expectedDurationSec"></param>
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