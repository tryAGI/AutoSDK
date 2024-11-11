//HintName: G.Models.LemurActionItemsParamsVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurActionItemsParamsVariant2
    {
        /// <summary>
        /// How you want the action items to be returned. This can be any text.<br/>
        /// Defaults to "Bullet Points".<br/>
        /// Default Value: Bullet Points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_format")]
        public string? AnswerFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurActionItemsParamsVariant2" /> class.
        /// </summary>
        /// <param name="answerFormat">
        /// How you want the action items to be returned. This can be any text.<br/>
        /// Defaults to "Bullet Points".<br/>
        /// Default Value: Bullet Points
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LemurActionItemsParamsVariant2(
            string? answerFormat)
        {
            this.AnswerFormat = answerFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurActionItemsParamsVariant2" /> class.
        /// </summary>
        public LemurActionItemsParamsVariant2()
        {
        }
    }
}