//HintName: G.Models.ReturnEllmModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnEllmModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_short_responses")]
        public bool? AllowShortResponses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnEllmModel" /> class.
        /// </summary>
        /// <param name="allowShortResponses"></param>
        public ReturnEllmModel(
            bool? allowShortResponses)
        {
            this.AllowShortResponses = allowShortResponses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnEllmModel" /> class.
        /// </summary>
        public ReturnEllmModel()
        {
        }
    }
}