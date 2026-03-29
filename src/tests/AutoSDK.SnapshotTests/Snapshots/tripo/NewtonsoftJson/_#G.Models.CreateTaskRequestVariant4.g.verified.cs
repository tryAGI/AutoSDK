//HintName: G.Models.CreateTaskRequestVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateTaskRequestVariant4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("draft_model_task_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DraftModelTaskId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant4" /> class.
        /// </summary>
        /// <param name="draftModelTaskId"></param>
        /// <param name="type"></param>
        public CreateTaskRequestVariant4(
            string draftModelTaskId,
            global::G.CreateTaskRequestVariant4Type type)
        {
            this.Type = type;
            this.DraftModelTaskId = draftModelTaskId ?? throw new global::System.ArgumentNullException(nameof(draftModelTaskId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant4" /> class.
        /// </summary>
        public CreateTaskRequestVariant4()
        {
        }
    }
}