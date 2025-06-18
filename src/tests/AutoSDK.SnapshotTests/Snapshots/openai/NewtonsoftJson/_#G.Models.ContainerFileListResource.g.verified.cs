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
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ContainerFileListResourceObject Object { get; set; }

        /// <summary>
        /// A list of container files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ContainerFileResource> Data { get; set; } = default!;

        /// <summary>
        /// The ID of the first file in the list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FirstId { get; set; } = default!;

        /// <summary>
        /// The ID of the last file in the list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastId { get; set; } = default!;

        /// <summary>
        /// Whether there are more files available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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