//HintName: G.Models.GetUserMetricsOverviewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserMetricsOverviewRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useInterquartile")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UseInterquartile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pSize")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PSizeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PSize PSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UserFilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UserFilterNode Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserMetricsOverviewRequest" /> class.
        /// </summary>
        /// <param name="useInterquartile"></param>
        /// <param name="pSize"></param>
        /// <param name="filter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUserMetricsOverviewRequest(
            bool useInterquartile,
            global::G.PSize pSize,
            global::G.UserFilterNode filter)
        {
            this.UseInterquartile = useInterquartile;
            this.PSize = pSize;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserMetricsOverviewRequest" /> class.
        /// </summary>
        public GetUserMetricsOverviewRequest()
        {
        }
    }
}