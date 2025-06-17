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
        [global::Newtonsoft.Json.JsonProperty("number_of_pages", Required = global::Newtonsoft.Json.Required.Always)]
        public double NumberOfPages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentKnowledgebaseSizeResponseModel" /> class.
        /// </summary>
        /// <param name="numberOfPages"></param>
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