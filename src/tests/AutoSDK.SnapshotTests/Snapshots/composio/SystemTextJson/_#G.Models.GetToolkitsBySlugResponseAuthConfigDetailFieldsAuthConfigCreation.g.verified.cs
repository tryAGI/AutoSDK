//HintName: G.Models.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Form fields needed when creating an authentication configuration
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem> Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optional")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem> Optional { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation" /> class.
        /// </summary>
        /// <param name="required"></param>
        /// <param name="optional"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation(
            global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationRequiredItem> required,
            global::System.Collections.Generic.IList<global::G.GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem> optional)
        {
            this.Required = required ?? throw new global::System.ArgumentNullException(nameof(required));
            this.Optional = optional ?? throw new global::System.ArgumentNullException(nameof(optional));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreation()
        {
        }
    }
}