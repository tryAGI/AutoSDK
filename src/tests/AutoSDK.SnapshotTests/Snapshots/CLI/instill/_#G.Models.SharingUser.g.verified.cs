﻿//HintName: G.Models.SharingUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes the sharing configuration with a given user.
    /// </summary>
    public sealed partial class SharingUser
    {
        /// <summary>
        /// Defines whether the sharing option with this user is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Defines the role the user will have over the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RoleJsonConverter))]
        public global::G.Role? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingUser" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Defines whether the sharing option with this user is enabled.
        /// </param>
        /// <param name="role">
        /// Defines the role the user will have over the resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharingUser(
            bool? enabled,
            global::G.Role? role)
        {
            this.Enabled = enabled;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingUser" /> class.
        /// </summary>
        public SharingUser()
        {
        }
    }
}