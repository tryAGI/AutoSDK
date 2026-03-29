//HintName: G.Models.EntityCompanyPropertiesWebTraffic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Company web traffic information.
    /// </summary>
    public sealed partial class EntityCompanyPropertiesWebTraffic
    {
        /// <summary>
        /// Estimated monthly website visits.<br/>
        /// Example: 266306714
        /// </summary>
        /// <example>266306714</example>
        [global::Newtonsoft.Json.JsonProperty("visitsMonthly")]
        public int? VisitsMonthly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCompanyPropertiesWebTraffic" /> class.
        /// </summary>
        /// <param name="visitsMonthly">
        /// Estimated monthly website visits.<br/>
        /// Example: 266306714
        /// </param>
        public EntityCompanyPropertiesWebTraffic(
            int? visitsMonthly)
        {
            this.VisitsMonthly = visitsMonthly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCompanyPropertiesWebTraffic" /> class.
        /// </summary>
        public EntityCompanyPropertiesWebTraffic()
        {
        }
    }
}