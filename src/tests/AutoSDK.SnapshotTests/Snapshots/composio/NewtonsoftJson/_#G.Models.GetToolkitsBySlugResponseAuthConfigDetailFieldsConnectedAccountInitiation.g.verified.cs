//HintName: G.Models.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Form fields needed when connecting a user account with this authentication method
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem> Required { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optional", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem> Optional { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation" /> class.
        /// </summary>
        /// <param name="required"></param>
        /// <param name="optional"></param>
        public GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation(
            global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem> required,
            global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem> optional)
        {
            this.Required = required ?? throw new global::System.ArgumentNullException(nameof(required));
            this.Optional = optional ?? throw new global::System.ArgumentNullException(nameof(optional));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation()
        {
        }
    }
}