//HintName: G.Models.HangupNode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HangupNode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.HangupNodeType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// This is whether or not the node is the start of the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isStart")]
        public bool? IsStart { get; set; }

        /// <summary>
        /// This is for metadata you want to store on the task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HangupNode" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="isStart">
        /// This is whether or not the node is the start of the workflow.
        /// </param>
        /// <param name="metadata">
        /// This is for metadata you want to store on the task.
        /// </param>
        public HangupNode(
            string name,
            global::G.HangupNodeType type,
            bool? isStart,
            object? metadata)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsStart = isStart;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HangupNode" /> class.
        /// </summary>
        public HangupNode()
        {
        }
    }
}