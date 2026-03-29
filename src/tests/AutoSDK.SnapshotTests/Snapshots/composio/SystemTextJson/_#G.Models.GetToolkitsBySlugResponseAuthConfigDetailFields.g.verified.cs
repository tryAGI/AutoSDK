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
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config_creation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation AuthConfigCreation { get; set; }

        /// <summary>
        /// Form fields needed when connecting a user account with this authentication method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_account_initiation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation ConnectedAccountInitiation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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