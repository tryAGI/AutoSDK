//HintName: G.Models.PostedConfigVersionDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedConfigVersionDescription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedConfigVersionDescription" /> class.
        /// </summary>
        /// <param name="versionDescription"></param>
        public PostedConfigVersionDescription(
            string? versionDescription)
        {
            this.VersionDescription = versionDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedConfigVersionDescription" /> class.
        /// </summary>
        public PostedConfigVersionDescription()
        {
        }
    }
}