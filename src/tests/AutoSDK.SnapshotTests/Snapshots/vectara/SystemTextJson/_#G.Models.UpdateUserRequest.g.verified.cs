//HintName: G.Models.UpdateUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateUserRequest
    {
        /// <summary>
        /// Indicates whether to enable or disable the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The new role names of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_roles")]
        public global::System.Collections.Generic.IList<global::G.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Indicates whether to enable or disable the user.
        /// </param>
        /// <param name="apiRoles">
        /// The new role names of the user.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateUserRequest(
            bool? enabled,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles)
        {
            this.Enabled = enabled;
            this.ApiRoles = apiRoles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequest" /> class.
        /// </summary>
        public UpdateUserRequest()
        {
        }
    }
}