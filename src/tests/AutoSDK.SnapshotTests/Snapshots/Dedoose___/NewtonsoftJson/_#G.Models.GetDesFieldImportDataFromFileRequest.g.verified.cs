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
        [global::Newtonsoft.Json.JsonProperty("relativeFileURL", Required = global::Newtonsoft.Json.Required.Always)]
        public string RelativeFileURL { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDesFieldImportDataFromFileRequest" /> class.
        /// </summary>
        /// <param name="relativeFileURL"></param>
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