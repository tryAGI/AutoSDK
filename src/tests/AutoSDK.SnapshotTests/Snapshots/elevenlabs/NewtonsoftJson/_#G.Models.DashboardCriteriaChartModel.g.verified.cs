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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Default Value: criteria
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DashboardCriteriaChartModelType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("criteria_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CriteriaId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardCriteriaChartModel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: criteria
        /// </param>
        /// <param name="criteriaId"></param>
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