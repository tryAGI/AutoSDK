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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ActivityItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsGetUserActivityResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// List of activity items
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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