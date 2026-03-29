//HintName: G.Models.AuthResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthResponse
    {
        /// <summary>
        /// UUID of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Uuid { get; set; }

        /// <summary>
        /// Whether the user is an admin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_admin")]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthResponse" /> class.
        /// </summary>
        /// <param name="uuid">
        /// UUID of the user
        /// </param>
        /// <param name="isAdmin">
        /// Whether the user is an admin
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthResponse(
            global::System.Guid uuid,
            bool? isAdmin)
        {
            this.Uuid = uuid;
            this.IsAdmin = isAdmin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthResponse" /> class.
        /// </summary>
        public AuthResponse()
        {
        }
    }
}