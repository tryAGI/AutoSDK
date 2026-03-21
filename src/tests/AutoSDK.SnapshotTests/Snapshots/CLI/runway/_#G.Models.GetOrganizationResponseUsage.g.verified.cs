//HintName: G.Models.GetOrganizationResponseUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage data for the organization.
    /// </summary>
    public sealed partial class GetOrganizationResponseUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.GetOrganizationResponseUsageModels2> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponseUsage" /> class.
        /// </summary>
        /// <param name="models"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationResponseUsage(
            global::System.Collections.Generic.Dictionary<string, global::G.GetOrganizationResponseUsageModels2> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponseUsage" /> class.
        /// </summary>
        public GetOrganizationResponseUsage()
        {
        }
    }
}