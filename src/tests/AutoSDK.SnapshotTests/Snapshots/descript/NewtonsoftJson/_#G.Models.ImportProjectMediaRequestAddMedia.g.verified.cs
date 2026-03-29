//HintName: G.Models.ImportProjectMediaRequestAddMedia.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Map of media reference IDs (display names with optional folder paths) to media import items.<br/>
    /// Keys are the display names that will appear in the project (e.g., "Misc/intro.mp4" or "demo.mp4").<br/>
    /// Values define how to import each media item (URL import or multitrack sequence).<br/>
    /// Example: {"Misc/intro.mp4":{"url":"https://example.com/intro.mp4"},"demo.mp4":{"url":"https://example.com/demo.mp4"},"Multicam_Track":{"tracks":[{"media":"Recordings/camera1.mp4","offset":0},{"media":"Recordings/camera2.mp4","offset":50}]}}
    /// </summary>
    public sealed partial class ImportProjectMediaRequestAddMedia
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}