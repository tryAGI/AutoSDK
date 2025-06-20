﻿//HintName: G.Models.GetAgentKnowledgebaseSizeResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentKnowledgebaseSizeResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumberOfPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentKnowledgebaseSizeResponseModel" /> class.
        /// </summary>
        /// <param name="numberOfPages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentKnowledgebaseSizeResponseModel(
            double numberOfPages)
        {
            this.NumberOfPages = numberOfPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentKnowledgebaseSizeResponseModel" /> class.
        /// </summary>
        public GetAgentKnowledgebaseSizeResponseModel()
        {
        }
    }
}