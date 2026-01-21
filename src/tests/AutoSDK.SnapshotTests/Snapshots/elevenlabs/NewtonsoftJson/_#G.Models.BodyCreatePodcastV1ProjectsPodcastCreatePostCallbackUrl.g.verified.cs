//HintName: G.Models.BodyCreatePodcastV1ProjectsPodcastCreatePostCallbackUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    ///     A url that will be called by our service when the Studio project is converted. Request will contain a json blob containing the status of the conversion<br/>
    ///     Messages:<br/>
    ///     1. When project was converted successfully:<br/>
    ///     {<br/>
    ///       type: "project_conversion_status",<br/>
    ///       event_timestamp: 1234567890,<br/>
    ///       data: {<br/>
    ///         request_id: "1234567890",<br/>
    ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
    ///         conversion_status: "success",<br/>
    ///         project_snapshot_id: "22m00Tcm4TlvDq8ikMAT",<br/>
    ///         error_details: None,<br/>
    ///       }<br/>
    ///     }<br/>
    ///     2. When project conversion failed:<br/>
    ///     {<br/>
    ///       type: "project_conversion_status",<br/>
    ///       event_timestamp: 1234567890,<br/>
    ///       data: {<br/>
    ///         request_id: "1234567890",<br/>
    ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
    ///         conversion_status: "error",<br/>
    ///         project_snapshot_id: None,<br/>
    ///         error_details: "Error details if conversion failed"<br/>
    ///       }<br/>
    ///     }<br/>
    ///     3. When chapter was converted successfully:<br/>
    ///     {<br/>
    ///       type: "chapter_conversion_status",<br/>
    ///       event_timestamp: 1234567890,<br/>
    ///       data: {<br/>
    ///         request_id: "1234567890",<br/>
    ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
    ///         chapter_id: "22m00Tcm4TlvDq8ikMAT",<br/>
    ///         conversion_status: "success",<br/>
    ///         chapter_snapshot_id: "23m00Tcm4TlvDq8ikMAV",<br/>
    ///         error_details: None,<br/>
    ///       }<br/>
    ///     }<br/>
    ///     4. When chapter conversion failed:<br/>
    ///     {<br/>
    ///       type: "chapter_conversion_status",<br/>
    ///       event_timestamp: 1234567890,<br/>
    ///       data: {<br/>
    ///         request_id: "1234567890",<br/>
    ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
    ///         chapter_id: "22m00Tcm4TlvDq8ikMAT",<br/>
    ///         conversion_status: "error",<br/>
    ///         chapter_snapshot_id: None,<br/>
    ///         error_details: "Error details if conversion failed"<br/>
    ///       }<br/>
    ///     }<br/>
    ///     
    /// </summary>
    public sealed partial class BodyCreatePodcastV1ProjectsPodcastCreatePostCallbackUrl
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}