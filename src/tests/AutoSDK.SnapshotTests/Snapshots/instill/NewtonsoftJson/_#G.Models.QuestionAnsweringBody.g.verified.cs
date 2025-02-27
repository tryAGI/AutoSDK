﻿//HintName: G.Models.QuestionAnsweringBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuestionAnsweringBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("question")]
        public string? Question { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionAnsweringBody" /> class.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="topK"></param>
        public QuestionAnsweringBody(
            string? question,
            int? topK)
        {
            this.Question = question;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionAnsweringBody" /> class.
        /// </summary>
        public QuestionAnsweringBody()
        {
        }
    }
}