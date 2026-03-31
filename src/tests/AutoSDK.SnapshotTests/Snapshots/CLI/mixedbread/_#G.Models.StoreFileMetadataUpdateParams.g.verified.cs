//HintName: G.Models.StoreFileMetadataUpdateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for updating metadata on an existing store file.
    /// </summary>
    public sealed partial class StoreFileMetadataUpdateParams
    {
        /// <summary>
        /// Updated metadata for the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFileMetadataUpdateParams" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Updated metadata for the file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreFileMetadataUpdateParams(
            object? metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFileMetadataUpdateParams" /> class.
        /// </summary>
        public StoreFileMetadataUpdateParams()
        {
        }
    }
}