//HintName: G.Models.Invite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an individual `invite` to the organization.
    /// </summary>
    public sealed partial class Invite
    {
        /// <summary>
        /// The object type, which is always `organization.invite`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.InviteObject Object { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The email address of the individual to whom the invite was sent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// `owner` or `reader`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InviteRole Role { get; set; } = default!;

        /// <summary>
        /// `accepted`,`expired`, or `pending`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InviteStatus Status { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the invite was sent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invited_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset InvitedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the invite expires.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset ExpiresAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the invite was accepted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accepted_at")]
        public global::System.DateTimeOffset? AcceptedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Invite" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `organization.invite`
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="email">
        /// The email address of the individual to whom the invite was sent
        /// </param>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        /// <param name="status">
        /// `accepted`,`expired`, or `pending`
        /// </param>
        /// <param name="invitedAt">
        /// The Unix timestamp (in seconds) of when the invite was sent.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) of when the invite expires.
        /// </param>
        /// <param name="acceptedAt">
        /// The Unix timestamp (in seconds) of when the invite was accepted.
        /// </param>
        public Invite(
            string id,
            string email,
            global::G.InviteRole role,
            global::G.InviteStatus status,
            global::System.DateTimeOffset invitedAt,
            global::System.DateTimeOffset expiresAt,
            global::G.InviteObject @object,
            global::System.DateTimeOffset? acceptedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role;
            this.Status = status;
            this.InvitedAt = invitedAt;
            this.ExpiresAt = expiresAt;
            this.Object = @object;
            this.AcceptedAt = acceptedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invite" /> class.
        /// </summary>
        public Invite()
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
        public static global::G.Invite? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Invite>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Invite?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Invite?>(serializer.Deserialize<global::G.Invite>(jsonReader));
        }

    }
}