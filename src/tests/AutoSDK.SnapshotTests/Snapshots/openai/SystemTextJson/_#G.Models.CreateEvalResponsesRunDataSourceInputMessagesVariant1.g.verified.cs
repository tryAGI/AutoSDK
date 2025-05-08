//HintName: G.Models.CreateEvalResponsesRunDataSourceInputMessagesVariant1.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalResponsesRunDataSourceInputMessagesVariant1
    {
        /// <summary>
        /// The type of input messages. Always `template`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateEvalResponsesRunDataSourceInputMessagesVariant1TypeJsonConverter))]
        public global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant1Type Type { get; set; }

        /// <summary>
        /// A list of chat messages forming the prompt or context. May include variable references to the "item" namespace, ie {{item.name}}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem, global::G.EvalItem>> Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSourceInputMessagesVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of input messages. Always `template`.
        /// </param>
        /// <param name="template">
        /// A list of chat messages forming the prompt or context. May include variable references to the "item" namespace, ie {{item.name}}.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalResponsesRunDataSourceInputMessagesVariant1(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem, global::G.EvalItem>> template,
            global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant1Type type)
        {
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSourceInputMessagesVariant1" /> class.
        /// </summary>
        public CreateEvalResponsesRunDataSourceInputMessagesVariant1()
        {
        }
    }
}