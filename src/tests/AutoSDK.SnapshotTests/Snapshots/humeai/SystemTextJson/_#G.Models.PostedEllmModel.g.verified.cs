//HintName: G.Models.PostedEllmModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedEllmModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_short_responses")]
        public bool? AllowShortResponses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedEllmModel" /> class.
        /// </summary>
        /// <param name="allowShortResponses"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostedEllmModel(
            bool? allowShortResponses)
        {
            this.AllowShortResponses = allowShortResponses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedEllmModel" /> class.
        /// </summary>
        public PostedEllmModel()
        {
        }
    }
}