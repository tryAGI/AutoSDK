//HintName: G.Models.BodyUpdateMemberV1WorkspaceMembersPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateMemberV1WorkspaceMembersPost
    {
        /// <summary>
        /// Email of the target user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Whether to lock or unlock the user account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_locked")]
        public bool? IsLocked { get; set; }

        /// <summary>
        /// Role dictating permissions in the workspace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_role")]
        public global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole? WorkspaceRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateMemberV1WorkspaceMembersPost" /> class.
        /// </summary>
        /// <param name="email">
        /// Email of the target user.
        /// </param>
        /// <param name="isLocked">
        /// Whether to lock or unlock the user account.
        /// </param>
        /// <param name="workspaceRole">
        /// Role dictating permissions in the workspace.
        /// </param>
        public BodyUpdateMemberV1WorkspaceMembersPost(
            string email,
            bool? isLocked,
            global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole? workspaceRole)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.IsLocked = isLocked;
            this.WorkspaceRole = workspaceRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateMemberV1WorkspaceMembersPost" /> class.
        /// </summary>
        public BodyUpdateMemberV1WorkspaceMembersPost()
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
        public static global::G.BodyUpdateMemberV1WorkspaceMembersPost? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BodyUpdateMemberV1WorkspaceMembersPost>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.BodyUpdateMemberV1WorkspaceMembersPost?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.BodyUpdateMemberV1WorkspaceMembersPost?>(serializer.Deserialize<global::G.BodyUpdateMemberV1WorkspaceMembersPost>(jsonReader));
        }

    }
}