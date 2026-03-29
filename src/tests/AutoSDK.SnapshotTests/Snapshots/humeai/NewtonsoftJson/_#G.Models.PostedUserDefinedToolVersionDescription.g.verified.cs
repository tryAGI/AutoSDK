//HintName: G.Models.PostedUserDefinedToolVersionDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedUserDefinedToolVersionDescription
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
        /// Initializes a new instance of the <see cref="PostedUserDefinedToolVersionDescription" /> class.
        /// </summary>
        /// <param name="versionDescription"></param>
        public PostedUserDefinedToolVersionDescription(
            string? versionDescription)
        {
            this.VersionDescription = versionDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedUserDefinedToolVersionDescription" /> class.
        /// </summary>
        public PostedUserDefinedToolVersionDescription()
        {
        }
    }
}