//HintName: G.Models.ListenV1Extra.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extra key-value metadata to attach to the request.
    /// </summary>
    public sealed partial class ListenV1Extra
    {
        /// <summary>
        /// A label for this request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Processing priority.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1Extra" /> class.
        /// </summary>
        /// <param name="tag">
        /// A label for this request.
        /// </param>
        /// <param name="priority">
        /// Processing priority.
        /// </param>
        public ListenV1Extra(
            string? tag,
            int? priority)
        {
            this.Tag = tag;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1Extra" /> class.
        /// </summary>
        public ListenV1Extra()
        {
        }
    }
}