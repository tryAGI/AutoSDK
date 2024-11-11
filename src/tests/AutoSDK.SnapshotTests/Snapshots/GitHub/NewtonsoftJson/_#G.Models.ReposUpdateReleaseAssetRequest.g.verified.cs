//HintName: G.Models.ReposUpdateReleaseAssetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateReleaseAssetRequest
    {
        /// <summary>
        /// The file name of the asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// An alternate short description of the asset. Used in place of the filename.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Example: "uploaded"
        /// </summary>
        /// <example>"uploaded"</example>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateReleaseAssetRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The file name of the asset.
        /// </param>
        /// <param name="label">
        /// An alternate short description of the asset. Used in place of the filename.
        /// </param>
        /// <param name="state">
        /// Example: "uploaded"
        /// </param>
        public ReposUpdateReleaseAssetRequest(
            string? name,
            string? label,
            string? state)
        {
            this.Name = name;
            this.Label = label;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateReleaseAssetRequest" /> class.
        /// </summary>
        public ReposUpdateReleaseAssetRequest()
        {
        }
    }
}