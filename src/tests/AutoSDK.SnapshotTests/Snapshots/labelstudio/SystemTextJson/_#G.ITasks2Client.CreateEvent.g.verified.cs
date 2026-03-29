//HintName: G.ITasks2Client.CreateEvent.g.cs
#nullable enable

namespace G
{
    public partial interface ITasks2Client
    {
        /// <summary>
        /// Create task event<br/>
        ///     Create a new task event to track user interactions and system events during annotation.<br/>
        ///     This endpoint is designed to receive events from the frontend labeling interface to enable<br/>
        ///     accurate lead time calculation and detailed annotation analytics.<br/>
        ///     ## Event Types<br/>
        ///     **Core Annotation Events:**<br/>
        ///     - `annotation_loaded` - When annotation interface is loaded<br/>
        ///     - `annotation_created` - When annotation is submitted<br/>
        ///     - `annotation_updated` - When annotation is modified<br/>
        ///     - `annotation_reviewed` - When annotation is reviewed<br/>
        ///     **User Activity Events:**<br/>
        ///     - `visibility_change` - When page visibility changes (tab switch, minimize)<br/>
        ///     - `idle_detected` - When user goes idle<br/>
        ///     - `idle_resumed` - When user returns from idle<br/>
        ///     **Interaction Events:**<br/>
        ///     - `region_finished_drawing` - When annotation region is completed<br/>
        ///     - `region_deleted` - When annotation regions are removed<br/>
        ///     - `hotkey_pressed` - When keyboard shortcuts are used<br/>
        ///     **Media Events:**<br/>
        ///     - `video_playback_start/end` - Video playback control<br/>
        ///     - `audio_playback_start/end` - Audio playback control<br/>
        ///     - `video_scrub` - Video timeline scrubbing<br/>
        ///     ## Usage<br/>
        ///     Events are automatically associated with the task specified in the URL path.<br/>
        ///     The current user is automatically set as the actor. Project and organization<br/>
        ///     are derived from the task context.<br/>
        ///     ## Example Request<br/>
        ///     ```json<br/>
        ///     {<br/>
        ///         "event_key": "annotation_loaded",<br/>
        ///         "event_time": "2024-01-15T10:30:00Z",<br/>
        ///         "annotation": 123,<br/>
        ///         "meta": {<br/>
        ///             "annotation_count": 5,<br/>
        ///             "estimated_time": 300<br/>
        ///         }<br/>
        ///     }<br/>
        ///     ```<br/>
        ///     
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TaskEvent> CreateEventAsync(
            int id,

            global::G.TaskEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create task event<br/>
        ///     Create a new task event to track user interactions and system events during annotation.<br/>
        ///     This endpoint is designed to receive events from the frontend labeling interface to enable<br/>
        ///     accurate lead time calculation and detailed annotation analytics.<br/>
        ///     ## Event Types<br/>
        ///     **Core Annotation Events:**<br/>
        ///     - `annotation_loaded` - When annotation interface is loaded<br/>
        ///     - `annotation_created` - When annotation is submitted<br/>
        ///     - `annotation_updated` - When annotation is modified<br/>
        ///     - `annotation_reviewed` - When annotation is reviewed<br/>
        ///     **User Activity Events:**<br/>
        ///     - `visibility_change` - When page visibility changes (tab switch, minimize)<br/>
        ///     - `idle_detected` - When user goes idle<br/>
        ///     - `idle_resumed` - When user returns from idle<br/>
        ///     **Interaction Events:**<br/>
        ///     - `region_finished_drawing` - When annotation region is completed<br/>
        ///     - `region_deleted` - When annotation regions are removed<br/>
        ///     - `hotkey_pressed` - When keyboard shortcuts are used<br/>
        ///     **Media Events:**<br/>
        ///     - `video_playback_start/end` - Video playback control<br/>
        ///     - `audio_playback_start/end` - Audio playback control<br/>
        ///     - `video_scrub` - Video timeline scrubbing<br/>
        ///     ## Usage<br/>
        ///     Events are automatically associated with the task specified in the URL path.<br/>
        ///     The current user is automatically set as the actor. Project and organization<br/>
        ///     are derived from the task context.<br/>
        ///     ## Example Request<br/>
        ///     ```json<br/>
        ///     {<br/>
        ///         "event_key": "annotation_loaded",<br/>
        ///         "event_time": "2024-01-15T10:30:00Z",<br/>
        ///         "annotation": 123,<br/>
        ///         "meta": {<br/>
        ///             "annotation_count": 5,<br/>
        ///             "estimated_time": 300<br/>
        ///         }<br/>
        ///     }<br/>
        ///     ```<br/>
        ///     
        /// </summary>
        /// <param name="id"></param>
        /// <param name="annotation">
        /// Annotation ID associated with this event
        /// </param>
        /// <param name="annotationDraftId">
        /// Draft annotation ID associated with this event
        /// </param>
        /// <param name="eventKey">
        /// Event type identifier (e.g., "annotation_loaded", "region_finished_drawing")
        /// </param>
        /// <param name="eventTime">
        /// Timestamp when the event occurred (frontend time)
        /// </param>
        /// <param name="meta">
        /// Additional event metadata (region data, hotkey info, etc.)
        /// </param>
        /// <param name="review">
        /// Review ID associated with this event
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TaskEvent> CreateEventAsync(
            int id,
            string eventKey,
            global::System.DateTime eventTime,
            int? annotation = default,
            int? annotationDraftId = default,
            object? meta = default,
            int? review = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}