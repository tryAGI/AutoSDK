//HintName: G.Models.AnalyticsGetUserActivityResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsGetUserActivityResponse200
    {
        /// <summary>
        /// List of activity items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ActivityItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsGetUserActivityResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// List of activity items
        /// </param>
        public AnalyticsGetUserActivityResponse200(
            global::System.Collections.Generic.IList<global::G.ActivityItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsGetUserActivityResponse200" /> class.
        /// </summary>
        public AnalyticsGetUserActivityResponse200()
        {
        }
    }
}