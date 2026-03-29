//HintName: G.Models.FileCreateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileCreateRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Digest { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCreateRes" /> class.
        /// </summary>
        /// <param name="digest"></param>
        public FileCreateRes(
            string digest)
        {
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCreateRes" /> class.
        /// </summary>
        public FileCreateRes()
        {
        }
    }
}