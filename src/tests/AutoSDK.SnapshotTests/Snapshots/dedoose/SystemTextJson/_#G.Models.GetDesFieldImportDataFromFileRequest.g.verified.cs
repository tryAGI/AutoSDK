//HintName: G.Models.GetDesFieldImportDataFromFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDesFieldImportDataFromFileRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relativeFileURL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RelativeFileURL { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDesFieldImportDataFromFileRequest" /> class.
        /// </summary>
        /// <param name="relativeFileURL"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDesFieldImportDataFromFileRequest(
            string relativeFileURL)
        {
            this.RelativeFileURL = relativeFileURL ?? throw new global::System.ArgumentNullException(nameof(relativeFileURL));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDesFieldImportDataFromFileRequest" /> class.
        /// </summary>
        public GetDesFieldImportDataFromFileRequest()
        {
        }
    }
}