//HintName: G.Models.OpenAIFinetuneJobMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Hyperparameters for the finetune job
    /// </summary>
    public sealed partial class OpenAIFinetuneJobMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAIFinetuneJobMethodTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAIFinetuneJobMethodType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supervised")]
        public global::G.OpenAIFinetuneJobMethodSupervised? Supervised { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpo")]
        public global::G.OpenAIFinetuneJobMethodDpo? Dpo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJobMethod" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="supervised"></param>
        /// <param name="dpo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIFinetuneJobMethod(
            global::G.OpenAIFinetuneJobMethodType type,
            global::G.OpenAIFinetuneJobMethodSupervised? supervised,
            global::G.OpenAIFinetuneJobMethodDpo? dpo)
        {
            this.Type = type;
            this.Supervised = supervised;
            this.Dpo = dpo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFinetuneJobMethod" /> class.
        /// </summary>
        public OpenAIFinetuneJobMethod()
        {
        }
    }
}