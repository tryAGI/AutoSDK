//HintName: G.Models.UserProfile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UserProfile describes the public data of a user.
    /// </summary>
    public sealed partial class UserProfile
    {
        /// <summary>
        /// Display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Biography.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bio")]
        public string? Bio { get; set; }

        /// <summary>
        /// Avatar in base64 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Public email.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicEmail")]
        public string? PublicEmail { get; set; }

        /// <summary>
        /// Company name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("companyName")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Social profile links list the links to the user's social profiles.<br/>
        /// The key represents the provider, and the value is the corresponding URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("socialProfileLinks")]
        public global::System.Collections.Generic.Dictionary<string, string>? SocialProfileLinks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Display name.
        /// </param>
        /// <param name="bio">
        /// Biography.
        /// </param>
        /// <param name="avatar">
        /// Avatar in base64 format.
        /// </param>
        /// <param name="publicEmail">
        /// Public email.
        /// </param>
        /// <param name="companyName">
        /// Company name.
        /// </param>
        /// <param name="socialProfileLinks">
        /// Social profile links list the links to the user's social profiles.<br/>
        /// The key represents the provider, and the value is the corresponding URL.
        /// </param>
        public UserProfile(
            string? displayName,
            string? bio,
            string? avatar,
            string? publicEmail,
            string? companyName,
            global::System.Collections.Generic.Dictionary<string, string>? socialProfileLinks)
        {
            this.DisplayName = displayName;
            this.Bio = bio;
            this.Avatar = avatar;
            this.PublicEmail = publicEmail;
            this.CompanyName = companyName;
            this.SocialProfileLinks = socialProfileLinks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile" /> class.
        /// </summary>
        public UserProfile()
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
        public static global::G.UserProfile? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UserProfile>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.UserProfile?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.UserProfile?>(serializer.Deserialize<global::G.UserProfile>(jsonReader));
        }

    }
}