//HintName: G.Models.KPIMetadataCalculationFormula.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formula for calculated KPIs defining how to derive the value from component KPIs. Structure: {"type": "ratio|sum|difference|product", "numerator": "kpi_key", "denominator": "kpi_key"}
    /// </summary>
    public sealed partial class KPIMetadataCalculationFormula
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}