//HintName: G.Models.MeterDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current usage and limits for the user for the given metric
    /// </summary>
    public sealed partial class MeterDetail
    {
        /// <summary>
        /// Maximum limit for the current billing period
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max")]
        public int? Max { get; set; }

        /// <summary>
        /// Unique system generated ID for the meteric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meterId")]
        public string? MeterId { get; set; }

        /// <summary>
        /// Current usage for the current billing period
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public int? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeterDetail" /> class.
        /// </summary>
        /// <param name="max">
        /// Maximum limit for the current billing period
        /// </param>
        /// <param name="meterId">
        /// Unique system generated ID for the meteric
        /// </param>
        /// <param name="value">
        /// Current usage for the current billing period
        /// </param>
        public MeterDetail(
            int? max,
            string? meterId,
            int? value)
        {
            this.Max = max;
            this.MeterId = meterId;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeterDetail" /> class.
        /// </summary>
        public MeterDetail()
        {
        }
    }
}