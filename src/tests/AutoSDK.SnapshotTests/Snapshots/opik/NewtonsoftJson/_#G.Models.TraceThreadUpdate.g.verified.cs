//HintName: G.Models.TraceThreadUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceThreadUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags_to_add")]
        public global::System.Collections.Generic.IList<string>? TagsToAdd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags_to_remove")]
        public global::System.Collections.Generic.IList<string>? TagsToRemove { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadUpdate" /> class.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="tagsToAdd"></param>
        /// <param name="tagsToRemove"></param>
        public TraceThreadUpdate(
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? tagsToAdd,
            global::System.Collections.Generic.IList<string>? tagsToRemove)
        {
            this.Tags = tags;
            this.TagsToAdd = tagsToAdd;
            this.TagsToRemove = tagsToRemove;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadUpdate" /> class.
        /// </summary>
        public TraceThreadUpdate()
        {
        }
    }
}