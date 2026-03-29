//HintName: G.Models.BooleanFeedbackDetailCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BooleanFeedbackDetailCreate
    {
        /// <summary>
        /// Label for true/1 value<br/>
        /// Example: Pass
        /// </summary>
        /// <example>Pass</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trueLabel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrueLabel { get; set; }

        /// <summary>
        /// Label for false/0 value<br/>
        /// Example: Fail
        /// </summary>
        /// <example>Fail</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("falseLabel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FalseLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFeedbackDetailCreate" /> class.
        /// </summary>
        /// <param name="trueLabel">
        /// Label for true/1 value<br/>
        /// Example: Pass
        /// </param>
        /// <param name="falseLabel">
        /// Label for false/0 value<br/>
        /// Example: Fail
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BooleanFeedbackDetailCreate(
            string trueLabel,
            string falseLabel)
        {
            this.TrueLabel = trueLabel ?? throw new global::System.ArgumentNullException(nameof(trueLabel));
            this.FalseLabel = falseLabel ?? throw new global::System.ArgumentNullException(nameof(falseLabel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFeedbackDetailCreate" /> class.
        /// </summary>
        public BooleanFeedbackDetailCreate()
        {
        }
    }
}