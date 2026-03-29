//HintName: G.Models.QueuedSourceResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of resource (a source) and the newly created source id. Returned with [QueuedSourceResponse](#tocs_queuedsourceresponse).
    /// </summary>
    public sealed partial class QueuedSourceResponseData
    {
        /// <summary>
        /// The type of resource, in this case it is a source.<br/>
        /// Example: source
        /// </summary>
        /// <example>source</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The source id.<br/>
        /// Example: zzytey4v-32km-kq1z-aftr-3kcuqi0brad2
        /// </summary>
        /// <example>zzytey4v-32km-kq1z-aftr-3kcuqi0brad2</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueuedSourceResponseData" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of resource, in this case it is a source.<br/>
        /// Example: source
        /// </param>
        /// <param name="id">
        /// The source id.<br/>
        /// Example: zzytey4v-32km-kq1z-aftr-3kcuqi0brad2
        /// </param>
        public QueuedSourceResponseData(
            string type,
            string id)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueuedSourceResponseData" /> class.
        /// </summary>
        public QueuedSourceResponseData()
        {
        }
    }
}