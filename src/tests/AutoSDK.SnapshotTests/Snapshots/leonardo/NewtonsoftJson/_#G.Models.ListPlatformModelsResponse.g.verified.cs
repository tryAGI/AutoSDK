﻿//HintName: G.Models.ListPlatformModelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListPlatformModelsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_models")]
        public global::System.Collections.Generic.IList<global::G.ListPlatformModelsResponseCustomModel>? CustomModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPlatformModelsResponse" /> class.
        /// </summary>
        /// <param name="customModels"></param>
        public ListPlatformModelsResponse(
            global::System.Collections.Generic.IList<global::G.ListPlatformModelsResponseCustomModel>? customModels)
        {
            this.CustomModels = customModels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPlatformModelsResponse" /> class.
        /// </summary>
        public ListPlatformModelsResponse()
        {
        }
    }
}