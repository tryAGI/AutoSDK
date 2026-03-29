//HintName: G.Models.LayoutAnalysisResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayoutAnalysisResponse
    {
        /// <summary>
        /// The API name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api")]
        public string? Api { get; set; }

        /// <summary>
        /// The model used for layout analysis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Layout elements detected in the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("elements")]
        public global::System.Collections.Generic.IList<global::G.LayoutElement>? Elements { get; set; }

        /// <summary>
        /// Page-level layout analysis results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages")]
        public global::System.Collections.Generic.IList<global::G.LayoutPage>? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.LayoutAnalysisUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutAnalysisResponse" /> class.
        /// </summary>
        /// <param name="api">
        /// The API name.
        /// </param>
        /// <param name="model">
        /// The model used for layout analysis.
        /// </param>
        /// <param name="elements">
        /// Layout elements detected in the document.
        /// </param>
        /// <param name="pages">
        /// Page-level layout analysis results.
        /// </param>
        /// <param name="usage"></param>
        public LayoutAnalysisResponse(
            string? api,
            string? model,
            global::System.Collections.Generic.IList<global::G.LayoutElement>? elements,
            global::System.Collections.Generic.IList<global::G.LayoutPage>? pages,
            global::G.LayoutAnalysisUsage? usage)
        {
            this.Api = api;
            this.Model = model;
            this.Elements = elements;
            this.Pages = pages;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutAnalysisResponse" /> class.
        /// </summary>
        public LayoutAnalysisResponse()
        {
        }
    }
}