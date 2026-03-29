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
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationRequiredItem> Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optional")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiationOptionalItem> Optional { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFieldsConnectedAccountInitiation" /> class.
        /// </summary>
        /// <param name="required"></param>
        /// <param name="optional"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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