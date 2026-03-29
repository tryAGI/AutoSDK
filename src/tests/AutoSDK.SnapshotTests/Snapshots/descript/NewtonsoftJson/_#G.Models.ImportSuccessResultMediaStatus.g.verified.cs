//HintName: G.Models.ImportSuccessResultMediaStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of each media item in the import.<br/>
    /// Keys are the media reference IDs from the request.<br/>
    /// Example: {"Misc/intro.mp4":{"status":"success","duration_seconds":10.5},"demo.mp4":{"status":"success","duration_seconds":125}}
    /// </summary>
    public sealed partial class ImportSuccessResultMediaStatus
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}