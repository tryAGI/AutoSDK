//HintName: G.Models.FinetuneResponseTrainingTypeDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneResponseTrainingTypeDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FinetuneResponseTrainingTypeDiscriminatorTypeJsonConverter))]
        public global::G.FinetuneResponseTrainingTypeDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneResponseTrainingTypeDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FinetuneResponseTrainingTypeDiscriminator(
            global::G.FinetuneResponseTrainingTypeDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneResponseTrainingTypeDiscriminator" /> class.
        /// </summary>
        public FinetuneResponseTrainingTypeDiscriminator()
        {
        }
    }
}