//HintName: G.Models.GetToolkitsBySlugResponseAuthConfigDetailFields.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Field groups required for different authentication stages
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseAuthConfigDetailFields
    {
        /// <summary>
        /// Form fields needed when creating an authentication configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_config_creation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation AuthConfigCreation { get; set; } = default!;

        /// <summary>
        /// Form fields needed when connecting a user account with this authentication method
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connected_account_initiation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation ConnectedAccountInitiation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFields" /> class.
        /// </summary>
        /// <param name="authConfigCreation">
        /// Form fields needed when creating an authentication configuration
        /// </param>
        /// <param name="connectedAccountInitiation">
        /// Form fields needed when connecting a user account with this authentication method
        /// </param>
        public GetToolkitsBySlugResponseAuthConfigDetailFields(
            global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation authConfigCreation,
            global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation connectedAccountInitiation)
        {
            this.AuthConfigCreation = authConfigCreation ?? throw new global::System.ArgumentNullException(nameof(authConfigCreation));
            this.ConnectedAccountInitiation = connectedAccountInitiation ?? throw new global::System.ArgumentNullException(nameof(connectedAccountInitiation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFields" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseAuthConfigDetailFields()
        {
        }
    }
}