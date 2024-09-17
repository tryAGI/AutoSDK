//HintName: G.Models.ProcessCatalogFilesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessCatalogFilesRequest
    {
        /// <summary>
        /// The file uid.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileUids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> FileUids { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}