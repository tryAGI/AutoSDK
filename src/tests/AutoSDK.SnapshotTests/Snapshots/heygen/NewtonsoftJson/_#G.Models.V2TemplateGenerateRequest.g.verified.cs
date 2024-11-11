//HintName: G.Models.V2TemplateGenerateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2TemplateGenerateRequest
    {
        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("caption")]
        public bool? Caption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dimension")]
        public global::G.V2TemplateGenerateRequestDimension? Dimension { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// Example: New Video
        /// </summary>
        /// <example>New Video</example>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables")]
        public global::G.V2TemplateGenerateRequestVariables? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TemplateGenerateRequest" /> class.
        /// </summary>
        /// <param name="caption">
        /// Example: false
        /// </param>
        /// <param name="dimension"></param>
        /// <param name="test">
        /// Example: false
        /// </param>
        /// <param name="title">
        /// Example: New Video
        /// </param>
        /// <param name="variables"></param>
        public V2TemplateGenerateRequest(
            bool? caption,
            global::G.V2TemplateGenerateRequestDimension? dimension,
            bool? test,
            string? title,
            global::G.V2TemplateGenerateRequestVariables? variables)
        {
            this.Caption = caption;
            this.Dimension = dimension;
            this.Test = test;
            this.Title = title;
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2TemplateGenerateRequest" /> class.
        /// </summary>
        public V2TemplateGenerateRequest()
        {
        }
    }
}