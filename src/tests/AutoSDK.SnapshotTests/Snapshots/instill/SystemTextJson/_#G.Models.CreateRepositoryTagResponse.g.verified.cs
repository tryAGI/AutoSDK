//HintName: G.Models.CreateRepositoryTagResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// CreateRepositoryTagResponse contains the created tag.
    /// </summary>
    public sealed partial class CreateRepositoryTagResponse
    {
        /// <summary>
        /// The created tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.RepositoryTag>? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}