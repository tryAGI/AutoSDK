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
        [global::System.Text.Json.Serialization.JsonPropertyName("package_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        public PackageVersionMetadataContainer? Container { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docker")]
        public PackageVersionMetadataDocker? Docker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}