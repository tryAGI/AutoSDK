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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ArtifactContent> Contents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int CurrentContentIndex { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contents"></param>
        /// <param name="currentContentIndex"></param>
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