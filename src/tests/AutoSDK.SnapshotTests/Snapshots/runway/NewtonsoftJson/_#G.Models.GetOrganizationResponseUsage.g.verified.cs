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
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.GetOrganizationResponseUsageModels2> Models { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponseUsage" /> class.
        /// </summary>
        /// <param name="models"></param>
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