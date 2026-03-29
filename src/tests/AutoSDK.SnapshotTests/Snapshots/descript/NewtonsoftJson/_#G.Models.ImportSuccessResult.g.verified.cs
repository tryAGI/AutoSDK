//HintName: G.Models.ImportSuccessResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result when media was imported (fully or partially)
    /// </summary>
    public sealed partial class ImportSuccessResult
    {
        /// <summary>
        /// - success: All media imported successfully<br/>
        /// - partial: Some media imported successfully, some failed<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImportSuccessResultStatus Status { get; set; } = default!;

        /// <summary>
        /// Status of each media item in the import.<br/>
        /// Keys are the media reference IDs from the request.<br/>
        /// Example: {"Misc/intro.mp4":{"status":"success","duration_seconds":10.5},"demo.mp4":{"status":"success","duration_seconds":125}}
        /// </summary>
        /// <example>{"Misc/intro.mp4":{"status":"success","duration_seconds":10.5},"demo.mp4":{"status":"success","duration_seconds":125}}</example>
        [global::Newtonsoft.Json.JsonProperty("media_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.ImportSuccessResultMediaStatus2> MediaStatus { get; set; } = default!;

        /// <summary>
        /// Total media seconds consumed by this import<br/>
        /// Example: 75
        /// </summary>
        /// <example>75</example>
        [global::Newtonsoft.Json.JsonProperty("media_seconds_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int MediaSecondsUsed { get; set; } = default!;

        /// <summary>
        /// Compositions created during import
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_compositions")]
        public global::System.Collections.Generic.IList<global::G.ImportSuccessResultCreatedComposition>? CreatedCompositions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportSuccessResult" /> class.
        /// </summary>
        /// <param name="status">
        /// - success: All media imported successfully<br/>
        /// - partial: Some media imported successfully, some failed<br/>
        /// Example: success
        /// </param>
        /// <param name="mediaStatus">
        /// Status of each media item in the import.<br/>
        /// Keys are the media reference IDs from the request.<br/>
        /// Example: {"Misc/intro.mp4":{"status":"success","duration_seconds":10.5},"demo.mp4":{"status":"success","duration_seconds":125}}
        /// </param>
        /// <param name="mediaSecondsUsed">
        /// Total media seconds consumed by this import<br/>
        /// Example: 75
        /// </param>
        /// <param name="createdCompositions">
        /// Compositions created during import
        /// </param>
        public ImportSuccessResult(
            global::G.ImportSuccessResultStatus status,
            global::System.Collections.Generic.Dictionary<string, global::G.ImportSuccessResultMediaStatus2> mediaStatus,
            int mediaSecondsUsed,
            global::System.Collections.Generic.IList<global::G.ImportSuccessResultCreatedComposition>? createdCompositions)
        {
            this.Status = status;
            this.MediaStatus = mediaStatus ?? throw new global::System.ArgumentNullException(nameof(mediaStatus));
            this.MediaSecondsUsed = mediaSecondsUsed;
            this.CreatedCompositions = createdCompositions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportSuccessResult" /> class.
        /// </summary>
        public ImportSuccessResult()
        {
        }
    }
}