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
        [global::Newtonsoft.Json.JsonProperty("uuid", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Uuid { get; set; } = default!;

        /// <summary>
        /// Whether the user is an admin
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_admin")]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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