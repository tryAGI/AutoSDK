//HintName: G.Models.UpdateAppClientRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAppClientRequest
    {
        /// <summary>
        /// The new App Client description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The new roles attached to the App Client. These roles will replace the current roles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_roles")]
        public global::System.Collections.Generic.IList<global::G.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppClientRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// The new App Client description.
        /// </param>
        /// <param name="apiRoles">
        /// The new roles attached to the App Client. These roles will replace the current roles.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAppClientRequest(
            string? description,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles)
        {
            this.Description = description;
            this.ApiRoles = apiRoles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppClientRequest" /> class.
        /// </summary>
        public UpdateAppClientRequest()
        {
        }
    }
}