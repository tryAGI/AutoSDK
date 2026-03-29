//HintName: G.Models.SpreadsheetParsingConfigSpecialization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional specialization mode for domain-specific extraction. Supported values: 'financial-standard', 'financial-enhanced', 'financial-precise'. Default None uses the general-purpose pipeline.
    /// </summary>
    public sealed partial class SpreadsheetParsingConfigSpecialization
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}