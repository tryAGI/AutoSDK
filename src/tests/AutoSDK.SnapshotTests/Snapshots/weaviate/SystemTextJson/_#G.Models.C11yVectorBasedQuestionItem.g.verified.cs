//HintName: G.Models.C11yVectorBasedQuestionItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class C11yVectorBasedQuestionItem
    {
        /// <summary>
        /// Vectorized classname.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classVectors")]
        public global::System.Collections.Generic.IList<float>? ClassVectors { get; set; }

        /// <summary>
        /// Vectorized properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classProps")]
        public global::System.Collections.Generic.IList<global::G.C11yVectorBasedQuestionItemClassProp>? ClassProps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}