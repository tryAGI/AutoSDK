//HintName: G.Models.CreateOrganizationUsageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateOrganizationUsageResponseResult> Results { get; set; } = default!;

        /// <summary>
        /// The list of models with usage during the queried time range.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateOrganizationUsageResponseModel> Models { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="models">
        /// The list of models with usage during the queried time range.
        /// </param>
        public CreateOrganizationUsageResponse(
            global::System.Collections.Generic.IList<global::G.CreateOrganizationUsageResponseResult> results,
            global::System.Collections.Generic.IList<global::G.CreateOrganizationUsageResponseModel> models)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationUsageResponse" /> class.
        /// </summary>
        public CreateOrganizationUsageResponse()
        {
        }
    }
}