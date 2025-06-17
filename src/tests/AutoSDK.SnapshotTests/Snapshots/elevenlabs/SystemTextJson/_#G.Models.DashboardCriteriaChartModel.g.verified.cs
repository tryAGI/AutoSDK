//HintName: G.Models.DashboardCriteriaChartModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashboardCriteriaChartModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: criteria
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DashboardCriteriaChartModelTypeJsonConverter))]
        public global::G.DashboardCriteriaChartModelType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CriteriaId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardCriteriaChartModel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: criteria
        /// </param>
        /// <param name="criteriaId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashboardCriteriaChartModel(
            string name,
            string criteriaId,
            global::G.DashboardCriteriaChartModelType? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CriteriaId = criteriaId ?? throw new global::System.ArgumentNullException(nameof(criteriaId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardCriteriaChartModel" /> class.
        /// </summary>
        public DashboardCriteriaChartModel()
        {
        }
    }
}