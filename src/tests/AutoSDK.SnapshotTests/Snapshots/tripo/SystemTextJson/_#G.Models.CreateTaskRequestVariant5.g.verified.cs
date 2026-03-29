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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTaskRequestVariant5TypeJsonConverter))]
        public global::G.CreateTaskRequestVariant5Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_model_task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalModelTaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant5" /> class.
        /// </summary>
        /// <param name="originalModelTaskId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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