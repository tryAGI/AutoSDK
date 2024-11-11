//HintName: G.Models.GetDatasetUsageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetUsageResponse
    {
        /// <summary>
        /// The total number of bytes used by the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_usage")]
        public double? OrganizationUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetUsageResponse" /> class.
        /// </summary>
        /// <param name="organizationUsage">
        /// The total number of bytes used by the organization.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetDatasetUsageResponse(
            double? organizationUsage)
        {
            this.OrganizationUsage = organizationUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetUsageResponse" /> class.
        /// </summary>
        public GetDatasetUsageResponse()
        {
        }
    }
}