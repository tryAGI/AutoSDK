﻿//HintName: G.Models.PullModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response class for pulling a model. <br/>
    /// The first object is the manifest. Then there is a series of downloading responses. Until any of the download is completed, the `completed` key may not be included. <br/>
    /// The number of files to be downloaded depends on the number of layers specified in the manifest.
    /// </summary>
    public sealed partial class PullModelResponse
    {
        /// <summary>
        /// Status pulling the model.<br/>
        /// Example: pulling manifest
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.PullModelStatus? Status { get; set; }

        /// <summary>
        /// The model's digest.<br/>
        /// Example: sha256:bc07c81de745696fdf5afca05e065818a8149fb0c77266fb584d9b2cba3711a
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// Total size of the model.<br/>
        /// Example: 2142590208L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public long? Total { get; set; }

        /// <summary>
        /// Total bytes transferred.<br/>
        /// Example: 2142590208L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed")]
        public long? Completed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.PullModelResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PullModelResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}