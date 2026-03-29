//HintName: G.Models.DatasetVersionRetrieveRequestPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetVersionRetrieveRequestPublic
    {
        /// <summary>
        /// Version name in format 'vN' (e.g., 'v1', 'v373')<br/>
        /// Example: v1
        /// </summary>
        /// <example>v1</example>
        [global::Newtonsoft.Json.JsonProperty("version_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionRetrieveRequestPublic" /> class.
        /// </summary>
        /// <param name="versionName">
        /// Version name in format 'vN' (e.g., 'v1', 'v373')<br/>
        /// Example: v1
        /// </param>
        public DatasetVersionRetrieveRequestPublic(
            string versionName)
        {
            this.VersionName = versionName ?? throw new global::System.ArgumentNullException(nameof(versionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionRetrieveRequestPublic" /> class.
        /// </summary>
        public DatasetVersionRetrieveRequestPublic()
        {
        }
    }
}