//HintName: G.Models.DataOverTimeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataOverTimeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeFilter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DataOverTimeRequestTimeFilter TimeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFilter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RequestClickhouseFilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RequestClickhouseFilterNode UserFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbIncrement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TimeIncrementJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TimeIncrement DbIncrement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeZoneDifference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TimeZoneDifference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataOverTimeRequest" /> class.
        /// </summary>
        /// <param name="timeFilter"></param>
        /// <param name="userFilter"></param>
        /// <param name="dbIncrement"></param>
        /// <param name="timeZoneDifference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataOverTimeRequest(
            global::G.DataOverTimeRequestTimeFilter timeFilter,
            global::G.RequestClickhouseFilterNode userFilter,
            global::G.TimeIncrement dbIncrement,
            double timeZoneDifference)
        {
            this.TimeFilter = timeFilter ?? throw new global::System.ArgumentNullException(nameof(timeFilter));
            this.UserFilter = userFilter;
            this.DbIncrement = dbIncrement;
            this.TimeZoneDifference = timeZoneDifference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataOverTimeRequest" /> class.
        /// </summary>
        public DataOverTimeRequest()
        {
        }
    }
}