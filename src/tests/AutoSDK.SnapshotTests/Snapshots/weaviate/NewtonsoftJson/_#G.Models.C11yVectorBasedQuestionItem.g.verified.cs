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
        [global::Newtonsoft.Json.JsonProperty("classVectors")]
        public global::System.Collections.Generic.IList<float>? ClassVectors { get; set; }

        /// <summary>
        /// Vectorized properties.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classProps")]
        public global::System.Collections.Generic.IList<global::G.C11yVectorBasedQuestionItemClassProp>? ClassProps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yVectorBasedQuestionItem" /> class.
        /// </summary>
        /// <param name="classVectors">
        /// Vectorized classname.
        /// </param>
        /// <param name="classProps">
        /// Vectorized properties.
        /// </param>
        public C11yVectorBasedQuestionItem(
            global::System.Collections.Generic.IList<float>? classVectors,
            global::System.Collections.Generic.IList<global::G.C11yVectorBasedQuestionItemClassProp>? classProps)
        {
            this.ClassVectors = classVectors;
            this.ClassProps = classProps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yVectorBasedQuestionItem" /> class.
        /// </summary>
        public C11yVectorBasedQuestionItem()
        {
        }
    }
}