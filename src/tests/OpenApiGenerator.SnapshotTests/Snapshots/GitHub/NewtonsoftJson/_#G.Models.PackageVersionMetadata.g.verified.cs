//HintName: G.Models.PackageVersionMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PackageVersionMetadata
    {
        /// <summary>
        /// <br/>Example: docker
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("package_type", Required = global::Newtonsoft.Json.Required.Always)]
        public PackageVersionMetadataPackageType PackageType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container")]
        public PackageVersionMetadataContainer? Container { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docker")]
        public PackageVersionMetadataDocker? Docker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}