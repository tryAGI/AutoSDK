//HintName: G.Models.AddLocalesToDubbingProjectResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddLocalesToDubbingProjectResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubbedErrors")]
        public global::System.Collections.Generic.IList<global::G.DubbedVideosApiError>? DubbedErrors { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDubbedAssets")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.DubbedAssetInProgress, global::G.DubbedAssetComplete, global::G.DubbedAssetError>> CreatedDubbedAssets { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddLocalesToDubbingProjectResponse" /> class.
        /// </summary>
        /// <param name="dubbedErrors"></param>
        /// <param name="createdDubbedAssets">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddLocalesToDubbingProjectResponse(
            global::System.Collections.Generic.IList<global::G.DubbedVideosApiError>? dubbedErrors,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.DubbedAssetInProgress, global::G.DubbedAssetComplete, global::G.DubbedAssetError>> createdDubbedAssets = default!)
        {
            this.DubbedErrors = dubbedErrors;
            this.CreatedDubbedAssets = createdDubbedAssets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddLocalesToDubbingProjectResponse" /> class.
        /// </summary>
        public AddLocalesToDubbingProjectResponse()
        {
        }
    }
}