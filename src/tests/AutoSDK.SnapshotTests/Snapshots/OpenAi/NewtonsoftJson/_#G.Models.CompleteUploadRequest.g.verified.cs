//HintName: G.Models.CompleteUploadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompleteUploadRequest
    {
        /// <summary>
        /// The ordered list of Part IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("part_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> PartIds { get; set; } = default!;

        /// <summary>
        /// The optional md5 checksum for the file contents to verify if the bytes uploaded matches what you expect.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("md5")]
        public string? Md5 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}