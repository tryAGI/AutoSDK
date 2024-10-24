﻿//HintName: G.Models.SingleRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Either set beacon (direct reference) or set class and schema (concept reference)
    /// </summary>
    public sealed partial class SingleRef
    {
        /// <summary>
        /// If using a concept reference (rather than a direct reference), specify the desired class name here
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class")]
        public string? Class { get; set; }

        /// <summary>
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// If using a direct reference, specify the URI to point to the cross-ref here. Should be in the form of weaviate://localhost/&lt;uuid&gt; for the example of a local cross-ref to an object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("beacon")]
        public string? Beacon { get; set; }

        /// <summary>
        /// If using a direct reference, this read-only fields provides a link to the referenced resource. If 'origin' is globally configured, an absolute URI is shown - a relative URI otherwise.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("href")]
        public string? Href { get; set; }

        /// <summary>
        /// This meta field contains additional info about the classified reference property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification")]
        public global::G.ReferenceMetaClassification? Classification { get; set; }

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
        public static global::G.SingleRef? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SingleRef>(
                json,
                jsonSerializerOptions);
        }

    }
}