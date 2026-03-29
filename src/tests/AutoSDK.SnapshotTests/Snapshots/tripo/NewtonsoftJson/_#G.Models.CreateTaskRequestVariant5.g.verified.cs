//HintName: G.Models.CreateTaskRequestVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateTaskRequestVariant5Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_model_task_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalModelTaskId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant5" /> class.
        /// </summary>
        /// <param name="originalModelTaskId"></param>
        /// <param name="type"></param>
        public CreateTaskRequestVariant5(
            string originalModelTaskId,
            global::G.CreateTaskRequestVariant5Type type)
        {
            this.Type = type;
            this.OriginalModelTaskId = originalModelTaskId ?? throw new global::System.ArgumentNullException(nameof(originalModelTaskId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant5" /> class.
        /// </summary>
        public CreateTaskRequestVariant5()
        {
        }
    }
}