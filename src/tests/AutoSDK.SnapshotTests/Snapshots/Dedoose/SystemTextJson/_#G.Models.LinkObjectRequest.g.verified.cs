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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MemoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ObjectIdWithPos Resourse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerpt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ObjectIdWithPos Excerpt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ObjectIdWithPos Descriptor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ObjectIdWithPos Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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