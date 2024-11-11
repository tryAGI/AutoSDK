//HintName: G.Models.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost
    {
        /// <summary>
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost" /> class.
        /// </summary>
        /// <param name="newName">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        public BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost(
            string newName)
        {
            this.NewName = newName ?? throw new global::System.ArgumentNullException(nameof(newName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost" /> class.
        /// </summary>
        public BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost()
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
        public static global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost?>(serializer.Deserialize<global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost>(jsonReader));
        }

    }
}