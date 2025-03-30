//HintName: G.Models.Artifact.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Artifact
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ArtifactContent> Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CurrentContentIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contents"></param>
        /// <param name="currentContentIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Artifact(
            string id,
            global::System.Collections.Generic.IList<global::G.ArtifactContent> contents,
            int currentContentIndex)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Contents = contents ?? throw new global::System.ArgumentNullException(nameof(contents));
            this.CurrentContentIndex = currentContentIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        public Artifact()
        {
        }
    }
}