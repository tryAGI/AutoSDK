//HintName: G.Models.MemoLinkedObjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoLinkedObjects
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerpts")]
        public global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? Excerpts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptors")]
        public global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? Descriptors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoLinkedObjects" /> class.
        /// </summary>
        /// <param name="resources"></param>
        /// <param name="excerpts"></param>
        /// <param name="descriptors"></param>
        /// <param name="tags"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MemoLinkedObjects(
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? resources,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? excerpts,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? descriptors,
            global::System.Collections.Generic.IList<global::G.ObjectIdWithPos>? tags)
        {
            this.Resources = resources;
            this.Excerpts = excerpts;
            this.Descriptors = descriptors;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoLinkedObjects" /> class.
        /// </summary>
        public MemoLinkedObjects()
        {
        }
    }
}