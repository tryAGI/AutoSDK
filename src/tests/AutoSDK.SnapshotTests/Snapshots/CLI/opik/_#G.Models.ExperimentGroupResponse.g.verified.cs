//HintName: G.Models.ExperimentGroupResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentGroupResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.Dictionary<string, global::G.GroupContent>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::G.GroupDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentGroupResponse" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentGroupResponse(
            global::System.Collections.Generic.Dictionary<string, global::G.GroupContent>? content,
            global::G.GroupDetails? details)
        {
            this.Content = content;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentGroupResponse" /> class.
        /// </summary>
        public ExperimentGroupResponse()
        {
        }
    }
}