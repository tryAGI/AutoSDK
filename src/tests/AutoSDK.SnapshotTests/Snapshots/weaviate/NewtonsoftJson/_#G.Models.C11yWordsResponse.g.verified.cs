﻿//HintName: G.Models.C11yWordsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of available words and contexts.
    /// </summary>
    public sealed partial class C11yWordsResponse
    {
        /// <summary>
        /// Weighted results for all words
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("concatenatedWord")]
        public global::G.C11yWordsResponseConcatenatedWord? ConcatenatedWord { get; set; }

        /// <summary>
        /// Weighted results for per individual word
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("individualWords")]
        public global::System.Collections.Generic.IList<global::G.C11yWordsResponseIndividualWord>? IndividualWords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yWordsResponse" /> class.
        /// </summary>
        /// <param name="concatenatedWord">
        /// Weighted results for all words
        /// </param>
        /// <param name="individualWords">
        /// Weighted results for per individual word
        /// </param>
        public C11yWordsResponse(
            global::G.C11yWordsResponseConcatenatedWord? concatenatedWord,
            global::System.Collections.Generic.IList<global::G.C11yWordsResponseIndividualWord>? individualWords)
        {
            this.ConcatenatedWord = concatenatedWord;
            this.IndividualWords = individualWords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yWordsResponse" /> class.
        /// </summary>
        public C11yWordsResponse()
        {
        }
    }
}