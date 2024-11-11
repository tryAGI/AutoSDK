//HintName: G.Models.PagesSourceHash.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PagesSourceHash
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch", Required = global::Newtonsoft.Json.Required.Always)]
        public string Branch { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesSourceHash" /> class.
        /// </summary>
        /// <param name="branch"></param>
        /// <param name="path"></param>
        public PagesSourceHash(
            string branch,
            string path)
        {
            this.Branch = branch ?? throw new global::System.ArgumentNullException(nameof(branch));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesSourceHash" /> class.
        /// </summary>
        public PagesSourceHash()
        {
        }
    }
}