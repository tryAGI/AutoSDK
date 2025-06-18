//HintName: G.Models.ContainerListResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerListResource
    {
        /// <summary>
        /// The type of object returned, must be 'list'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ContainerListResourceObject Object { get; set; }

        /// <summary>
        /// A list of containers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ContainerResource> Data { get; set; } = default!;

        /// <summary>
        /// The ID of the first container in the list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FirstId { get; set; } = default!;

        /// <summary>
        /// The ID of the last container in the list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastId { get; set; } = default!;

        /// <summary>
        /// Whether there are more containers available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerListResource" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of object returned, must be 'list'.
        /// </param>
        /// <param name="data">
        /// A list of containers.
        /// </param>
        /// <param name="firstId">
        /// The ID of the first container in the list.
        /// </param>
        /// <param name="lastId">
        /// The ID of the last container in the list.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more containers available.
        /// </param>
        public ContainerListResource(
            global::System.Collections.Generic.IList<global::G.ContainerResource> data,
            string firstId,
            string lastId,
            bool hasMore,
            global::G.ContainerListResourceObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.HasMore = hasMore;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerListResource" /> class.
        /// </summary>
        public ContainerListResource()
        {
        }
    }
}