//HintName: G.Models.LemurTaskParamsVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurTaskParamsVariant1
    {
        /// <summary>
        /// Your text to prompt the model to produce a desired output, including any context you want to pass into the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurTaskParamsVariant1" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Your text to prompt the model to produce a desired output, including any context you want to pass into the model.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LemurTaskParamsVariant1(
            string prompt)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurTaskParamsVariant1" /> class.
        /// </summary>
        public LemurTaskParamsVariant1()
        {
        }
    }
}