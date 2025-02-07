//HintName: G.Models.PackageVersionMetadataDocker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PackageVersionMetadataDocker
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public global::System.Collections.Generic.IList<string>? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersionMetadataDocker" /> class.
        /// </summary>
        /// <param name="tag"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PackageVersionMetadataDocker(
            global::System.Collections.Generic.IList<string>? tag)
        {
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersionMetadataDocker" /> class.
        /// </summary>
        public PackageVersionMetadataDocker()
        {
        }
    }
}