﻿//HintName: G.Models.ExtensionViewsVideoOverlay.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes how the extension is rendered if the extension may be activated as a video-overlay extension.
    /// </summary>
    public sealed partial class ExtensionViewsVideoOverlay
    {
        /// <summary>
        /// The HTML file that is shown to viewers on the channel page when the extension is activated on the Video - Overlay slot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("viewer_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ViewerUrl { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the extension can link to non-Twitch domains.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_link_external_content", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanLinkExternalContent { get; set; } = default!;

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
        public static global::G.ExtensionViewsVideoOverlay? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ExtensionViewsVideoOverlay>(
                json,
                jsonSerializerOptions);
        }

    }
}