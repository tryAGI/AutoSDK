//HintName: G.Models.CreateDubbingProjectApiResponseSuccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDubbingProjectApiResponseSuccess
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdImportedAsset", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImportedAssetId CreatedImportedAsset { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingProjectApiResponseSuccess" /> class.
        /// </summary>
        /// <param name="createdImportedAsset"></param>
        public CreateDubbingProjectApiResponseSuccess(
            global::G.ImportedAssetId createdImportedAsset)
        {
            this.CreatedImportedAsset = createdImportedAsset ?? throw new global::System.ArgumentNullException(nameof(createdImportedAsset));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingProjectApiResponseSuccess" /> class.
        /// </summary>
        public CreateDubbingProjectApiResponseSuccess()
        {
        }
    }
}