//HintName: G.Models.GetOrganizationResponseTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Limits associated with the organization's tier.
    /// </summary>
    public sealed partial class GetOrganizationResponseTier
    {
        /// <summary>
        /// The maximum number of credits that can be purchased in a month.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxMonthlyCreditSpend", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxMonthlyCreditSpend { get; set; } = default!;

        /// <summary>
        /// An object containing model-specific limits. Each key represents a model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.GetOrganizationResponseTierModels2> Models { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponseTier" /> class.
        /// </summary>
        /// <param name="maxMonthlyCreditSpend">
        /// The maximum number of credits that can be purchased in a month.
        /// </param>
        /// <param name="models">
        /// An object containing model-specific limits. Each key represents a model.
        /// </param>
        public GetOrganizationResponseTier(
            int maxMonthlyCreditSpend,
            global::System.Collections.Generic.Dictionary<string, global::G.GetOrganizationResponseTierModels2> models)
        {
            this.MaxMonthlyCreditSpend = maxMonthlyCreditSpend;
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponseTier" /> class.
        /// </summary>
        public GetOrganizationResponseTier()
        {
        }
    }
}