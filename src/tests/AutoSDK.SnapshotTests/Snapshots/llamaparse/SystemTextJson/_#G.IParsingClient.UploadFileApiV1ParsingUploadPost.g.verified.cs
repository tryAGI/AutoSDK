//HintName: G.IParsingClient.UploadFileApiV1ParsingUploadPost.g.cs
#nullable enable

namespace G
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParsingJob> UploadFileApiV1ParsingUploadPostAsync(

            global::G.BodyUploadFileApiV1ParsingUploadPost request,
            global::System.Guid? organizationId = default,
            global::System.Guid? projectId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="session"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="adaptiveLongTable">
        /// Default Value: false
        /// </param>
        /// <param name="annotateLinks">
        /// Default Value: false
        /// </param>
        /// <param name="autoMode">
        /// Default Value: false
        /// </param>
        /// <param name="autoModeTriggerOnImageInPage">
        /// Default Value: false
        /// </param>
        /// <param name="autoModeTriggerOnTableInPage">
        /// Default Value: false
        /// </param>
        /// <param name="autoModeTriggerOnTextInPage"></param>
        /// <param name="autoModeTriggerOnRegexpInPage"></param>
        /// <param name="autoModeConfigurationJson"></param>
        /// <param name="azureOpenaiApiVersion"></param>
        /// <param name="azureOpenaiDeploymentName"></param>
        /// <param name="azureOpenaiEndpoint"></param>
        /// <param name="azureOpenaiKey"></param>
        /// <param name="bboxBottom"></param>
        /// <param name="bboxLeft"></param>
        /// <param name="bboxRight"></param>
        /// <param name="bboxTop"></param>
        /// <param name="compactMarkdownTable">
        /// Default Value: false
        /// </param>
        /// <param name="disableOcr">
        /// Default Value: false
        /// </param>
        /// <param name="disableReconstruction">
        /// Default Value: false
        /// </param>
        /// <param name="disableImageExtraction">
        /// Default Value: false
        /// </param>
        /// <param name="doNotCache">
        /// Default Value: false
        /// </param>
        /// <param name="doNotUnrollColumns">
        /// Default Value: false
        /// </param>
        /// <param name="extractCharts">
        /// Default Value: false
        /// </param>
        /// <param name="guessXlsxSheetName">
        /// Default Value: false
        /// </param>
        /// <param name="highResOcr">
        /// Default Value: false
        /// </param>
        /// <param name="htmlMakeAllElementsVisible">
        /// Default Value: false
        /// </param>
        /// <param name="layoutAware">
        /// Default Value: false
        /// </param>
        /// <param name="specializedChartParsingAgentic">
        /// Default Value: false
        /// </param>
        /// <param name="specializedChartParsingPlus">
        /// Default Value: false
        /// </param>
        /// <param name="specializedChartParsingEfficient">
        /// Default Value: false
        /// </param>
        /// <param name="specializedImageParsing">
        /// Default Value: false
        /// </param>
        /// <param name="preciseBoundingBox">
        /// Default Value: false
        /// </param>
        /// <param name="lineLevelBoundingBox">
        /// Default Value: false
        /// </param>
        /// <param name="htmlRemoveFixedElements">
        /// Default Value: false
        /// </param>
        /// <param name="htmlRemoveNavigationElements">
        /// Default Value: false
        /// </param>
        /// <param name="httpProxy"></param>
        /// <param name="inputS3Path"></param>
        /// <param name="inputS3Region"></param>
        /// <param name="inputUrl"></param>
        /// <param name="invalidateCache">
        /// Default Value: false
        /// </param>
        /// <param name="language">
        /// Default Value: [en]
        /// </param>
        /// <param name="extractLayout">
        /// Default Value: false
        /// </param>
        /// <param name="maxPages"></param>
        /// <param name="mergeTablesAcrossPagesInMarkdown">
        /// Default Value: false
        /// </param>
        /// <param name="outlinedTableExtraction">
        /// Default Value: false
        /// </param>
        /// <param name="aggressiveTableExtraction">
        /// Default Value: false
        /// </param>
        /// <param name="outputPdfOfDocument">
        /// Default Value: false
        /// </param>
        /// <param name="outputS3PathPrefix"></param>
        /// <param name="outputS3Region"></param>
        /// <param name="pagePrefix"></param>
        /// <param name="pageSeparator"></param>
        /// <param name="pageSuffix"></param>
        /// <param name="preserveLayoutAlignmentAcrossPages">
        /// Default Value: false
        /// </param>
        /// <param name="preserveVerySmallText">
        /// Default Value: false
        /// </param>
        /// <param name="skipDiagonalText">
        /// Default Value: false
        /// </param>
        /// <param name="spreadsheetExtractSubTables">
        /// Default Value: true
        /// </param>
        /// <param name="spreadsheetForceFormulaComputation">
        /// Default Value: false
        /// </param>
        /// <param name="inlineImagesInMarkdown">
        /// Default Value: false
        /// </param>
        /// <param name="structuredOutput">
        /// Default Value: false
        /// </param>
        /// <param name="structuredOutputJsonSchema"></param>
        /// <param name="structuredOutputJsonSchemaName"></param>
        /// <param name="takeScreenshot">
        /// Default Value: false
        /// </param>
        /// <param name="targetPages"></param>
        /// <param name="vendorMultimodalApiKey"></param>
        /// <param name="vendorMultimodalModelName"></param>
        /// <param name="model"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookConfigurations"></param>
        /// <param name="preset"></param>
        /// <param name="parseMode"></param>
        /// <param name="pageErrorTolerance">
        /// Default Value: 0.05F
        /// </param>
        /// <param name="replaceFailedPageMode"></param>
        /// <param name="replaceFailedPageWithErrorMessagePrefix"></param>
        /// <param name="replaceFailedPageWithErrorMessageSuffix"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="systemPromptAppend"></param>
        /// <param name="userPrompt"></param>
        /// <param name="jobTimeoutInSeconds"></param>
        /// <param name="jobTimeoutExtraTimePerPageInSeconds"></param>
        /// <param name="strictModeImageExtraction">
        /// Default Value: false
        /// </param>
        /// <param name="strictModeImageOcr">
        /// Default Value: false
        /// </param>
        /// <param name="strictModeReconstruction">
        /// Default Value: false
        /// </param>
        /// <param name="strictModeBuggyFont">
        /// Default Value: false
        /// </param>
        /// <param name="saveImages">
        /// Default Value: true
        /// </param>
        /// <param name="ignoreDocumentElementsForLayoutDetection">
        /// Default Value: false
        /// </param>
        /// <param name="keepPageSeparatorWhenMergingTables">
        /// Default Value: false
        /// </param>
        /// <param name="outputTablesAsHtml">
        /// Default Value: false
        /// </param>
        /// <param name="markdownTableMultilineHeaderSeparator"></param>
        /// <param name="useVendorMultimodalModel">
        /// Default Value: false
        /// </param>
        /// <param name="boundingBox"></param>
        /// <param name="gpt4oMode">
        /// Default Value: false
        /// </param>
        /// <param name="gpt4oApiKey"></param>
        /// <param name="complementalFormattingInstruction"></param>
        /// <param name="contentGuidelineInstruction"></param>
        /// <param name="premiumMode">
        /// Default Value: false
        /// </param>
        /// <param name="isFormattingInstruction">
        /// Default Value: true
        /// </param>
        /// <param name="continuousMode">
        /// Default Value: false
        /// </param>
        /// <param name="parsingInstruction"></param>
        /// <param name="fastMode">
        /// Default Value: false
        /// </param>
        /// <param name="formattingInstruction"></param>
        /// <param name="hideHeaders">
        /// Default Value: false
        /// </param>
        /// <param name="hideFooters">
        /// Default Value: false
        /// </param>
        /// <param name="pageHeaderPrefix"></param>
        /// <param name="pageHeaderSuffix"></param>
        /// <param name="pageFooterPrefix"></param>
        /// <param name="pageFooterSuffix"></param>
        /// <param name="removeHiddenText">
        /// Default Value: false
        /// </param>
        /// <param name="presentationOutOfBoundsContent">
        /// Default Value: false
        /// </param>
        /// <param name="presentationSkipEmbeddedData">
        /// Default Value: false
        /// </param>
        /// <param name="extractPrintedPageNumber">
        /// Default Value: false
        /// </param>
        /// <param name="tier"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParsingJob> UploadFileApiV1ParsingUploadPostAsync(
            global::System.Guid? organizationId = default,
            global::System.Guid? projectId = default,
            string? session = default,
            byte[]? file = default,
            string? filename = default,
            bool? adaptiveLongTable = default,
            bool? annotateLinks = default,
            bool? autoMode = default,
            bool? autoModeTriggerOnImageInPage = default,
            bool? autoModeTriggerOnTableInPage = default,
            string? autoModeTriggerOnTextInPage = default,
            string? autoModeTriggerOnRegexpInPage = default,
            string? autoModeConfigurationJson = default,
            string? azureOpenaiApiVersion = default,
            string? azureOpenaiDeploymentName = default,
            string? azureOpenaiEndpoint = default,
            string? azureOpenaiKey = default,
            double? bboxBottom = default,
            double? bboxLeft = default,
            double? bboxRight = default,
            double? bboxTop = default,
            bool? compactMarkdownTable = default,
            bool? disableOcr = default,
            bool? disableReconstruction = default,
            bool? disableImageExtraction = default,
            bool? doNotCache = default,
            bool? doNotUnrollColumns = default,
            bool? extractCharts = default,
            bool? guessXlsxSheetName = default,
            bool? highResOcr = default,
            bool? htmlMakeAllElementsVisible = default,
            bool? layoutAware = default,
            bool? specializedChartParsingAgentic = default,
            bool? specializedChartParsingPlus = default,
            bool? specializedChartParsingEfficient = default,
            bool? specializedImageParsing = default,
            bool? preciseBoundingBox = default,
            bool? lineLevelBoundingBox = default,
            bool? htmlRemoveFixedElements = default,
            bool? htmlRemoveNavigationElements = default,
            string? httpProxy = default,
            string? inputS3Path = default,
            string? inputS3Region = default,
            string? inputUrl = default,
            bool? invalidateCache = default,
            global::System.Collections.Generic.IList<global::G.ParserLanguages>? language = default,
            bool? extractLayout = default,
            int? maxPages = default,
            bool? mergeTablesAcrossPagesInMarkdown = default,
            bool? outlinedTableExtraction = default,
            bool? aggressiveTableExtraction = default,
            bool? outputPdfOfDocument = default,
            string? outputS3PathPrefix = default,
            string? outputS3Region = default,
            string? pagePrefix = default,
            string? pageSeparator = default,
            string? pageSuffix = default,
            bool? preserveLayoutAlignmentAcrossPages = default,
            bool? preserveVerySmallText = default,
            bool? skipDiagonalText = default,
            bool? spreadsheetExtractSubTables = default,
            bool? spreadsheetForceFormulaComputation = default,
            bool? inlineImagesInMarkdown = default,
            bool? structuredOutput = default,
            string? structuredOutputJsonSchema = default,
            string? structuredOutputJsonSchemaName = default,
            bool? takeScreenshot = default,
            string? targetPages = default,
            string? vendorMultimodalApiKey = default,
            string? vendorMultimodalModelName = default,
            string? model = default,
            string? webhookUrl = default,
            string? webhookConfigurations = default,
            string? preset = default,
            global::G.ParsingMode? parseMode = default,
            double? pageErrorTolerance = default,
            global::G.FailPageMode? replaceFailedPageMode = default,
            string? replaceFailedPageWithErrorMessagePrefix = default,
            string? replaceFailedPageWithErrorMessageSuffix = default,
            string? systemPrompt = default,
            string? systemPromptAppend = default,
            string? userPrompt = default,
            double? jobTimeoutInSeconds = default,
            double? jobTimeoutExtraTimePerPageInSeconds = default,
            bool? strictModeImageExtraction = default,
            bool? strictModeImageOcr = default,
            bool? strictModeReconstruction = default,
            bool? strictModeBuggyFont = default,
            bool? saveImages = default,
            bool? ignoreDocumentElementsForLayoutDetection = default,
            bool? keepPageSeparatorWhenMergingTables = default,
            bool? outputTablesAsHtml = default,
            string? markdownTableMultilineHeaderSeparator = default,
            bool? useVendorMultimodalModel = default,
            string? boundingBox = default,
            bool? gpt4oMode = default,
            string? gpt4oApiKey = default,
            string? complementalFormattingInstruction = default,
            string? contentGuidelineInstruction = default,
            bool? premiumMode = default,
            bool? isFormattingInstruction = default,
            bool? continuousMode = default,
            string? parsingInstruction = default,
            bool? fastMode = default,
            string? formattingInstruction = default,
            bool? hideHeaders = default,
            bool? hideFooters = default,
            string? pageHeaderPrefix = default,
            string? pageHeaderSuffix = default,
            string? pageFooterPrefix = default,
            string? pageFooterSuffix = default,
            bool? removeHiddenText = default,
            bool? presentationOutOfBoundsContent = default,
            bool? presentationSkipEmbeddedData = default,
            bool? extractPrintedPageNumber = default,
            string? tier = default,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}