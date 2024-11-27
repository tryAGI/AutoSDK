//HintName: G.Models.LinkObjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkObjectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid MemoId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourse", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ObjectIdWithPos Resourse { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excerpt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ObjectIdWithPos Excerpt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptor", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ObjectIdWithPos Descriptor { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ObjectIdWithPos Tag { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkObjectRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="resourse"></param>
        /// <param name="excerpt"></param>
        /// <param name="descriptor"></param>
        /// <param name="tag"></param>
        public LinkObjectRequest(
            global::System.Guid projectId,
            global::System.Guid memoId,
            global::G.ObjectIdWithPos resourse,
            global::G.ObjectIdWithPos excerpt,
            global::G.ObjectIdWithPos descriptor,
            global::G.ObjectIdWithPos tag)
        {
            this.ProjectId = projectId;
            this.MemoId = memoId;
            this.Resourse = resourse ?? throw new global::System.ArgumentNullException(nameof(resourse));
            this.Excerpt = excerpt ?? throw new global::System.ArgumentNullException(nameof(excerpt));
            this.Descriptor = descriptor ?? throw new global::System.ArgumentNullException(nameof(descriptor));
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkObjectRequest" /> class.
        /// </summary>
        public LinkObjectRequest()
        {
        }
    }
}