//HintName: G.Models.CreateTaskRequestVariant8.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateTaskRequestVariant8Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateTaskRequestVariant8Style Style { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_model_task_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalModelTaskId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_size")]
        public int? BlockSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant8" /> class.
        /// </summary>
        /// <param name="style"></param>
        /// <param name="originalModelTaskId"></param>
        /// <param name="type"></param>
        /// <param name="blockSize"></param>
        public CreateTaskRequestVariant8(
            global::G.CreateTaskRequestVariant8Style style,
            string originalModelTaskId,
            global::G.CreateTaskRequestVariant8Type type,
            int? blockSize)
        {
            this.Type = type;
            this.Style = style;
            this.OriginalModelTaskId = originalModelTaskId ?? throw new global::System.ArgumentNullException(nameof(originalModelTaskId));
            this.BlockSize = blockSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant8" /> class.
        /// </summary>
        public CreateTaskRequestVariant8()
        {
        }
    }
}