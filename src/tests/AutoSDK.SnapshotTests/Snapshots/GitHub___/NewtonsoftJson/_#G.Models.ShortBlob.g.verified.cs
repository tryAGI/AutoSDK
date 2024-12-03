//HintName: G.Models.ShortBlob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Short Blob
    /// </summary>
    public sealed partial class ShortBlob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortBlob" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="sha"></param>
        public ShortBlob(
            string url,
            string sha)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortBlob" /> class.
        /// </summary>
        public ShortBlob()
        {
        }
    }
}