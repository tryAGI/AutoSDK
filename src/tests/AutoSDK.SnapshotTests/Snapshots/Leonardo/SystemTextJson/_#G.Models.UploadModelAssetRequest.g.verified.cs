//HintName: G.Models.UploadModelAssetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadModelAssetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelExtension")]
        public string? ModelExtension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadModelAssetRequest" /> class.
        /// </summary>
        /// <param name="modelExtension"></param>
        /// <param name="name"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UploadModelAssetRequest(
            string? modelExtension,
            string? name)
        {
            this.ModelExtension = modelExtension;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadModelAssetRequest" /> class.
        /// </summary>
        public UploadModelAssetRequest()
        {
        }
    }
}