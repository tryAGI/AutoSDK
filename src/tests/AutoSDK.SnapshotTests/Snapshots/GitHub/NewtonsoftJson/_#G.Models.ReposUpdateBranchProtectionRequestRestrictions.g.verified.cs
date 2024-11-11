//HintName: G.Models.ReposUpdateBranchProtectionRequestRestrictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Restrict who can push to the protected branch. User, app, and team `restrictions` are only available for organization-owned repositories. Set to `null` to disable.
    /// </summary>
    public sealed partial class ReposUpdateBranchProtectionRequestRestrictions
    {
        /// <summary>
        /// The list of user `login`s with push access
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Users { get; set; } = default!;

        /// <summary>
        /// The list of team `slug`s with push access
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Teams { get; set; } = default!;

        /// <summary>
        /// The list of app `slug`s with push access
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apps")]
        public global::System.Collections.Generic.IList<string>? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateBranchProtectionRequestRestrictions" /> class.
        /// </summary>
        /// <param name="users">
        /// The list of user `login`s with push access
        /// </param>
        /// <param name="teams">
        /// The list of team `slug`s with push access
        /// </param>
        /// <param name="apps">
        /// The list of app `slug`s with push access
        /// </param>
        public ReposUpdateBranchProtectionRequestRestrictions(
            global::System.Collections.Generic.IList<string> users,
            global::System.Collections.Generic.IList<string> teams,
            global::System.Collections.Generic.IList<string>? apps)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateBranchProtectionRequestRestrictions" /> class.
        /// </summary>
        public ReposUpdateBranchProtectionRequestRestrictions()
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
        public static global::G.ReposUpdateBranchProtectionRequestRestrictions? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ReposUpdateBranchProtectionRequestRestrictions>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ReposUpdateBranchProtectionRequestRestrictions?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ReposUpdateBranchProtectionRequestRestrictions?>(serializer.Deserialize<global::G.ReposUpdateBranchProtectionRequestRestrictions>(jsonReader));
        }

    }
}