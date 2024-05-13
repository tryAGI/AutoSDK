//HintName: G.Models.AssistantStreamEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an event emitted when streaming a Run.
    /// Each event in a server-sent events stream has an `event` and `data` property:
    /// ```
    /// event: thread.created
    /// data: {"id": "thread_123", "object": "thread", ...}
    /// ```
    /// We emit events whenever a new object is created, transitions to a new state, or is being
    /// streamed in parts (deltas). For example, we emit `thread.run.created` when a new run
    /// is created, `thread.run.completed` when a run completes, and so on. When an Assistant chooses
    /// to create a message during a run, we emit a `thread.message.created event`, a
    /// `thread.message.in_progress` event, many `thread.message.delta` events, and finally a
    /// `thread.message.completed` event.
    /// We may add additional events over time, so we recommend handling unknown events gracefully
    /// in your code. See the [Assistants API quickstart](/docs/assistants/overview) to learn how to
    /// integrate the Assistants API with streaming.
    /// </summary>
    public sealed partial class AssistantStreamEvent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}