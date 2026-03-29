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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTaskRequestVariant4TypeJsonConverter))]
        public global::G.CreateTaskRequestVariant4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft_model_task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DraftModelTaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant4" /> class.
        /// </summary>
        /// <param name="draftModelTaskId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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