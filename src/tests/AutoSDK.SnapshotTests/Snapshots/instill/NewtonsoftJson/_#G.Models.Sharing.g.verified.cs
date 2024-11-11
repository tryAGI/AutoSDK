//HintName: G.Models.Sharing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sharing contains the information to share a resource with other users.<br/>
    /// For more information, see [Share Pipelines](https://www.instill.tech/docs/vdp/share).
    /// </summary>
    public sealed partial class Sharing
    {
        /// <summary>
        /// Defines sharing rules for a set of user resource names.<br/>
        /// Each key in this object should contain a pattern that can be matched<br/>
        /// against user names.<br/>
        /// Each value is a user sharing configuration.<br/>
        /// **NOTE**: For now, the only accepted key is `*/*`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users")]
        public global::System.Collections.Generic.Dictionary<string, global::G.SharingUser>? Users { get; set; }

        /// <summary>
        /// Defines the configuration to share a resource via link.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shareCode")]
        public global::G.ShareCode? ShareCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sharing" /> class.
        /// </summary>
        /// <param name="users">
        /// Defines sharing rules for a set of user resource names.<br/>
        /// Each key in this object should contain a pattern that can be matched<br/>
        /// against user names.<br/>
        /// Each value is a user sharing configuration.<br/>
        /// **NOTE**: For now, the only accepted key is `*/*`.
        /// </param>
        /// <param name="shareCode">
        /// Defines the configuration to share a resource via link.
        /// </param>
        public Sharing(
            global::System.Collections.Generic.Dictionary<string, global::G.SharingUser>? users,
            global::G.ShareCode? shareCode)
        {
            this.Users = users;
            this.ShareCode = shareCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sharing" /> class.
        /// </summary>
        public Sharing()
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
        public static global::G.Sharing? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Sharing>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Sharing?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Sharing?>(serializer.Deserialize<global::G.Sharing>(jsonReader));
        }

    }
}