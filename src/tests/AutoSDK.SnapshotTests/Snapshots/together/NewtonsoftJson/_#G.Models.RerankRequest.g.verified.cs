//HintName: G.Models.RerankRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankRequest
    {
        /// <summary>
        /// The model to be used for the rerank request.<br/>
        /// Default Value: Salesforce/Llama-Rank-V1<br/>
        /// Example: Salesforce/Llama-Rank-V1
        /// </summary>
        /// <default>"Salesforce/Llama-Rank-V1"</default>
        /// <example>Salesforce/Llama-Rank-V1</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The search query to be used for ranking.<br/>
        /// Default Value: What animals can I find near Peru?<br/>
        /// Example: What animals can I find near Peru?
        /// </summary>
        /// <default>"What animals can I find near Peru?"</default>
        /// <example>What animals can I find near Peru?</example>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// List of documents, which can be either strings or objects.<br/>
        /// Default Value: [{"title":"Llama","text":"The llama is a domesticated South American camelid, widely used as a meat and pack animal by Andean cultures since the pre-Columbian era."}, {"title":"Panda","text":"The giant panda (Ailuropoda melanoleuca), also known as the panda bear or simply panda, is a bear species endemic to China."}, {"title":"Guanaco","text":"The guanaco is a camelid native to South America, closely related to the llama. Guanacos are one of two wild South American camelids; the other species is the vicu\u00F1a, which lives at higher elevations."}, {"title":"Wild Bactrian camel","text":"The wild Bactrian camel (Camelus ferus) is an endangered species of camel endemic to Northwest China and southwestern Mongolia."}]<br/>
        /// Example: [{"title":"Llama","text":"The llama is a domesticated South American camelid, widely used as a meat and pack animal by Andean cultures since the pre-Columbian era."}, {"title":"Panda","text":"The giant panda (Ailuropoda melanoleuca), also known as the panda bear or simply panda, is a bear species endemic to China."}, {"title":"Guanaco","text":"The guanaco is a camelid native to South America, closely related to the llama. Guanacos are one of two wild South American camelids; the other species is the vicu\u00F1a, which lives at higher elevations."}, {"title":"Wild Bactrian camel","text":"The wild Bactrian camel (Camelus ferus) is an endangered species of camel endemic to Northwest China and southwestern Mongolia."}]
        /// </summary>
        /// <example>[{"title":"Llama","text":"The llama is a domesticated South American camelid, widely used as a meat and pack animal by Andean cultures since the pre-Columbian era."}, {"title":"Panda","text":"The giant panda (Ailuropoda melanoleuca), also known as the panda bear or simply panda, is a bear species endemic to China."}, {"title":"Guanaco","text":"The guanaco is a camelid native to South America, closely related to the llama. Guanacos are one of two wild South American camelids; the other species is the vicu\u00F1a, which lives at higher elevations."}, {"title":"Wild Bactrian camel","text":"The wild Bactrian camel (Camelus ferus) is an endangered species of camel endemic to Northwest China and southwestern Mongolia."}]</example>
        [global::Newtonsoft.Json.JsonProperty("documents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>> Documents { get; set; } = default!;

        /// <summary>
        /// The number of top results to return.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// Whether to return supplied documents with the response.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// List of keys in the JSON Object document to rank by. Defaults to use all supplied keys for ranking.<br/>
        /// Example: [title, text]
        /// </summary>
        /// <example>[title, text]</example>
        [global::Newtonsoft.Json.JsonProperty("rank_fields")]
        public global::System.Collections.Generic.IList<string>? RankFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to be used for the rerank request.<br/>
        /// Default Value: Salesforce/Llama-Rank-V1<br/>
        /// Example: Salesforce/Llama-Rank-V1
        /// </param>
        /// <param name="query">
        /// The search query to be used for ranking.<br/>
        /// Default Value: What animals can I find near Peru?<br/>
        /// Example: What animals can I find near Peru?
        /// </param>
        /// <param name="documents">
        /// List of documents, which can be either strings or objects.<br/>
        /// Default Value: [{"title":"Llama","text":"The llama is a domesticated South American camelid, widely used as a meat and pack animal by Andean cultures since the pre-Columbian era."}, {"title":"Panda","text":"The giant panda (Ailuropoda melanoleuca), also known as the panda bear or simply panda, is a bear species endemic to China."}, {"title":"Guanaco","text":"The guanaco is a camelid native to South America, closely related to the llama. Guanacos are one of two wild South American camelids; the other species is the vicu\u00F1a, which lives at higher elevations."}, {"title":"Wild Bactrian camel","text":"The wild Bactrian camel (Camelus ferus) is an endangered species of camel endemic to Northwest China and southwestern Mongolia."}]<br/>
        /// Example: [{"title":"Llama","text":"The llama is a domesticated South American camelid, widely used as a meat and pack animal by Andean cultures since the pre-Columbian era."}, {"title":"Panda","text":"The giant panda (Ailuropoda melanoleuca), also known as the panda bear or simply panda, is a bear species endemic to China."}, {"title":"Guanaco","text":"The guanaco is a camelid native to South America, closely related to the llama. Guanacos are one of two wild South American camelids; the other species is the vicu\u00F1a, which lives at higher elevations."}, {"title":"Wild Bactrian camel","text":"The wild Bactrian camel (Camelus ferus) is an endangered species of camel endemic to Northwest China and southwestern Mongolia."}]
        /// </param>
        /// <param name="topN">
        /// The number of top results to return.<br/>
        /// Example: 2
        /// </param>
        /// <param name="returnDocuments">
        /// Whether to return supplied documents with the response.<br/>
        /// Example: true
        /// </param>
        /// <param name="rankFields">
        /// List of keys in the JSON Object document to rank by. Defaults to use all supplied keys for ranking.<br/>
        /// Example: [title, text]
        /// </param>
        public RerankRequest(
            string model,
            string query,
            global::G.OneOf<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>> documents,
            int? topN,
            bool? returnDocuments,
            global::System.Collections.Generic.IList<string>? rankFields)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Documents = documents;
            this.TopN = topN;
            this.ReturnDocuments = returnDocuments;
            this.RankFields = rankFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        public RerankRequest()
        {
        }
    }
}