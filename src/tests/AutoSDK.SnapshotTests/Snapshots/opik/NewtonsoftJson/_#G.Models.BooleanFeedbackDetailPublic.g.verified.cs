//HintName: G.Models.BooleanFeedbackDetailPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BooleanFeedbackDetailPublic
    {
        /// <summary>
        /// Label for true/1 value<br/>
        /// Example: Pass
        /// </summary>
        /// <example>Pass</example>
        [global::Newtonsoft.Json.JsonProperty("trueLabel", Required = global::Newtonsoft.Json.Required.Always)]
        public string TrueLabel { get; set; } = default!;

        /// <summary>
        /// Label for false/0 value<br/>
        /// Example: Fail
        /// </summary>
        /// <example>Fail</example>
        [global::Newtonsoft.Json.JsonProperty("falseLabel", Required = global::Newtonsoft.Json.Required.Always)]
        public string FalseLabel { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFeedbackDetailPublic" /> class.
        /// </summary>
        /// <param name="trueLabel">
        /// Label for true/1 value<br/>
        /// Example: Pass
        /// </param>
        /// <param name="falseLabel">
        /// Label for false/0 value<br/>
        /// Example: Fail
        /// </param>
        public BooleanFeedbackDetailPublic(
            string trueLabel,
            string falseLabel)
        {
            this.TrueLabel = trueLabel ?? throw new global::System.ArgumentNullException(nameof(trueLabel));
            this.FalseLabel = falseLabel ?? throw new global::System.ArgumentNullException(nameof(falseLabel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFeedbackDetailPublic" /> class.
        /// </summary>
        public BooleanFeedbackDetailPublic()
        {
        }
    }
}