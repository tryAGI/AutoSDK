//HintName: G.IDocumentAIClient.LayoutAnalysis.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentAIClient
    {
        /// <summary>
        /// Layout analysis<br/>
        /// Analyzes the layout structure of documents.<br/>
        /// Detects and classifies layout elements such as paragraphs, tables, figures,<br/>
        /// headings, lists, captions, headers, footers, equations, and charts.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LayoutAnalysisResponse> LayoutAnalysisAsync(

            global::G.LayoutAnalysisRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Layout analysis<br/>
        /// Analyzes the layout structure of documents.<br/>
        /// Detects and classifies layout elements such as paragraphs, tables, figures,<br/>
        /// headings, lists, captions, headers, footers, equations, and charts.
        /// </summary>
        /// <param name="document">
        /// The document file to analyze (PDF, PNG, JPG, JPEG, BMP, TIFF).
        /// </param>
        /// <param name="documentname">
        /// The document file to analyze (PDF, PNG, JPG, JPEG, BMP, TIFF).
        /// </param>
        /// <param name="model">
        /// The model to use for layout analysis.<br/>
        /// Default: layout-analysis<br/>
        /// Default Value: layout-analysis
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LayoutAnalysisResponse> LayoutAnalysisAsync(
            byte[] document,
            string documentname,
            string? model = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}