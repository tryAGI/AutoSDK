//HintName: G.Models.OrgMembership.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Org Membership
    /// </summary>
    public sealed partial class OrgMembership
    {
        /// <summary>
        /// Example: https://api.github.com/orgs/octocat/memberships/defunkt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The state of the member in the organization. The `pending` state indicates the user has not yet accepted an invitation.<br/>
        /// Example: active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrgMembershipState State { get; set; } = default!;

        /// <summary>
        /// The user's membership type in the organization.<br/>
        /// Example: admin
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrgMembershipRole Role { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/octocat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationUrl { get; set; } = default!;

        /// <summary>
        /// A GitHub organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrganizationSimple Organization { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::G.OrgMembershipPermissions? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgMembership" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/orgs/octocat/memberships/defunkt
        /// </param>
        /// <param name="state">
        /// The state of the member in the organization. The `pending` state indicates the user has not yet accepted an invitation.<br/>
        /// Example: active
        /// </param>
        /// <param name="role">
        /// The user's membership type in the organization.<br/>
        /// Example: admin
        /// </param>
        /// <param name="organizationUrl">
        /// Example: https://api.github.com/orgs/octocat
        /// </param>
        /// <param name="organization">
        /// A GitHub organization.
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="permissions"></param>
        public OrgMembership(
            string url,
            global::G.OrgMembershipState state,
            global::G.OrgMembershipRole role,
            string organizationUrl,
            global::G.OrganizationSimple organization,
            global::G.NullableSimpleUser? user,
            global::G.OrgMembershipPermissions? permissions)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.State = state;
            this.Role = role;
            this.OrganizationUrl = organizationUrl ?? throw new global::System.ArgumentNullException(nameof(organizationUrl));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgMembership" /> class.
        /// </summary>
        public OrgMembership()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.OrgMembership? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.OrgMembership>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.OrgMembership?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.OrgMembership?>(serializer.Deserialize<global::G.OrgMembership>(jsonReader));
        }

    }
}