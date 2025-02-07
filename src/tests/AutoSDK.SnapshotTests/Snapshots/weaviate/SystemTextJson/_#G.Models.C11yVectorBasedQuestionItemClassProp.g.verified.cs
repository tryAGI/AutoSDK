//HintName: G.Models.C11yVectorBasedQuestionItemClassProp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class C11yVectorBasedQuestionItemClassProp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propsVectors")]
        public global::System.Collections.Generic.IList<float>? PropsVectors { get; set; }

        /// <summary>
        /// String with valuename.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yVectorBasedQuestionItemClassProp" /> class.
        /// </summary>
        /// <param name="propsVectors"></param>
        /// <param name="value">
        /// String with valuename.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public C11yVectorBasedQuestionItemClassProp(
            global::System.Collections.Generic.IList<float>? propsVectors,
            string? value)
        {
            this.PropsVectors = propsVectors;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yVectorBasedQuestionItemClassProp" /> class.
        /// </summary>
        public C11yVectorBasedQuestionItemClassProp()
        {
        }
    }
}