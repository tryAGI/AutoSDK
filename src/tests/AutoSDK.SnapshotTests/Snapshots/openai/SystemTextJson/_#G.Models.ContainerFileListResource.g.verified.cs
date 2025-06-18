//HintName: G.Models.ContainerFileListResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerFileListResource
    {
        /// <summary>
        /// The type of object returned, must be 'list'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ContainerFileListResourceObjectJsonConverter))]
        public global::G.ContainerFileListResourceObject Object { get; set; }

        /// <summary>
        /// A list of container files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ContainerFileResource> Data { get; set; }

        /// <summary>
        /// The ID of the first file in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstId { get; set; }

        /// <summary>
        /// The ID of the last file in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastId { get; set; }

        /// <summary>
        /// Whether there are more files available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileListResource" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object returned, must be 'list'.
        /// </param>
        /// <param name="data">
        /// A list of container files.
        /// </param>
        /// <param name="firstId">
        /// The ID of the first file in the list.
        /// </param>
        /// <param name="lastId">
        /// The ID of the last file in the list.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more files available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerFileListResource(
            global::System.Collections.Generic.IList<global::G.ContainerFileResource> data,
            string firstId,
            string lastId,
            bool hasMore,
            global::G.ContainerFileListResourceObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.HasMore = hasMore;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileListResource" /> class.
        /// </summary>
        public ContainerFileListResource()
        {
        }
    }
}