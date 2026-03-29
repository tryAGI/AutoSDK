//HintName: G.Models.TableCreateFromDigestsRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableCreateFromDigestsRes
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
        /// Initializes a new instance of the <see cref="TableCreateFromDigestsRes" /> class.
        /// </summary>
        /// <param name="digest"></param>
        public TableCreateFromDigestsRes(
            string digest)
        {
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableCreateFromDigestsRes" /> class.
        /// </summary>
        public TableCreateFromDigestsRes()
        {
        }
    }
}