//HintName: G.Models.Cluster.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Cluster
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_elements")]
        public global::System.Collections.Generic.IList<string>? SampleElements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Cluster" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keywords"></param>
        /// <param name="description"></param>
        /// <param name="size"></param>
        /// <param name="sampleElements"></param>
        public Cluster(
            string? id,
            global::System.Collections.Generic.IList<string>? keywords,
            string? description,
            int? size,
            global::System.Collections.Generic.IList<string>? sampleElements)
        {
            this.Id = id;
            this.Keywords = keywords;
            this.Description = description;
            this.Size = size;
            this.SampleElements = sampleElements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cluster" /> class.
        /// </summary>
        public Cluster()
        {
        }
    }
}