//HintName: G.Models.NullableIntegrationPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class NullableIntegrationPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issues")]
        public string? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("checks")]
        public string? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents")]
        public string? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployments")]
        public string? Deployments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableIntegrationPermissions" /> class.
        /// </summary>
        /// <param name="issues"></param>
        /// <param name="checks"></param>
        /// <param name="metadata"></param>
        /// <param name="contents"></param>
        /// <param name="deployments"></param>
        public NullableIntegrationPermissions(
            string? issues,
            string? checks,
            string? metadata,
            string? contents,
            string? deployments)
        {
            this.Issues = issues;
            this.Checks = checks;
            this.Metadata = metadata;
            this.Contents = contents;
            this.Deployments = deployments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableIntegrationPermissions" /> class.
        /// </summary>
        public NullableIntegrationPermissions()
        {
        }
    }
}