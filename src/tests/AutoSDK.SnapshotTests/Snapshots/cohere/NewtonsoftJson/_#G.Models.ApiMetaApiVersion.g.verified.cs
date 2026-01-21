//HintName: G.Models.ApiMetaApiVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiMetaApiVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_deprecated")]
        public bool? IsDeprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_experimental")]
        public bool? IsExperimental { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMetaApiVersion" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="isDeprecated"></param>
        /// <param name="isExperimental"></param>
        public ApiMetaApiVersion(
            string version,
            bool? isDeprecated,
            bool? isExperimental)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.IsDeprecated = isDeprecated;
            this.IsExperimental = isExperimental;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMetaApiVersion" /> class.
        /// </summary>
        public ApiMetaApiVersion()
        {
        }
    }
}