//HintName: G.Models.CreateLoraApiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLoraApiRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LoraName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SourceModel Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoraApiRequest" /> class.
        /// </summary>
        /// <param name="baseModel"></param>
        /// <param name="loraName"></param>
        /// <param name="source"></param>
        /// <param name="private"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLoraApiRequest(
            string baseModel,
            string loraName,
            global::G.SourceModel source,
            bool @private,
            string? description)
        {
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.LoraName = loraName ?? throw new global::System.ArgumentNullException(nameof(loraName));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Private = @private;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoraApiRequest" /> class.
        /// </summary>
        public CreateLoraApiRequest()
        {
        }
    }
}