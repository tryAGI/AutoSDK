//HintName: G.Models.SampleEntity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SampleEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TaskId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio", Required = global::Newtonsoft.Json.Required.Always)]
        public string Audio { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleEntity" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        /// <param name="taskId"></param>
        /// <param name="audio"></param>
        public SampleEntity(
            string title,
            string text,
            string taskId,
            string audio)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleEntity" /> class.
        /// </summary>
        public SampleEntity()
        {
        }
    }
}