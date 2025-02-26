//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.anthropic.com";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.APIErrorTypeJsonConverter(),
                    new global::G.JsonConverters.APIErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AuthenticationErrorTypeJsonConverter(),
                    new global::G.JsonConverters.AuthenticationErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.Base64ImageSourceTypeJsonConverter(),
                    new global::G.JsonConverters.Base64ImageSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.Base64ImageSourceMediaTypeJsonConverter(),
                    new global::G.JsonConverters.Base64ImageSourceMediaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.Base64PDFSourceTypeJsonConverter(),
                    new global::G.JsonConverters.Base64PDFSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.Base64PDFSourceMediaTypeJsonConverter(),
                    new global::G.JsonConverters.Base64PDFSourceMediaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaAPIErrorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaAPIErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaAuthenticationErrorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaAuthenticationErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaBase64ImageSourceTypeJsonConverter(),
                    new global::G.JsonConverters.BetaBase64ImageSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaBase64ImageSourceMediaTypeJsonConverter(),
                    new global::G.JsonConverters.BetaBase64ImageSourceMediaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaBase64PDFSourceTypeJsonConverter(),
                    new global::G.JsonConverters.BetaBase64PDFSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaBase64PDFSourceMediaTypeJsonConverter(),
                    new global::G.JsonConverters.BetaBase64PDFSourceMediaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaCacheControlEphemeralTypeJsonConverter(),
                    new global::G.JsonConverters.BetaCacheControlEphemeralTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaBashTool20241022CacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaBashTool20241022CacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaBashTool20241022TypeJsonConverter(),
                    new global::G.JsonConverters.BetaBashTool20241022TypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaBashTool20241022NameJsonConverter(),
                    new global::G.JsonConverters.BetaBashTool20241022NameNullableJsonConverter(),
                    new global::G.JsonConverters.BetaBillingErrorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaBillingErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaCanceledResultTypeJsonConverter(),
                    new global::G.JsonConverters.BetaCanceledResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaCitationsDeltaTypeJsonConverter(),
                    new global::G.JsonConverters.BetaCitationsDeltaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaResponseCharLocationCitationTypeJsonConverter(),
                    new global::G.JsonConverters.BetaResponseCharLocationCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaResponsePageLocationCitationTypeJsonConverter(),
                    new global::G.JsonConverters.BetaResponsePageLocationCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaResponseContentBlockLocationCitationTypeJsonConverter(),
                    new global::G.JsonConverters.BetaResponseContentBlockLocationCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaCitationsDeltaCitationDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaCitationsDeltaCitationDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaComputerUseTool20241022CacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaComputerUseTool20241022CacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaComputerUseTool20241022TypeJsonConverter(),
                    new global::G.JsonConverters.BetaComputerUseTool20241022TypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaComputerUseTool20241022NameJsonConverter(),
                    new global::G.JsonConverters.BetaComputerUseTool20241022NameNullableJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockDeltaEventTypeJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockDeltaEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaTextContentBlockDeltaTypeJsonConverter(),
                    new global::G.JsonConverters.BetaTextContentBlockDeltaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaInputJsonContentBlockDeltaTypeJsonConverter(),
                    new global::G.JsonConverters.BetaInputJsonContentBlockDeltaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockDeltaEventDeltaDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockDeltaEventDeltaDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockSourceTypeJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestTextBlockCacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestTextBlockCacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestCharLocationCitationTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestCharLocationCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestPageLocationCitationTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestPageLocationCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestContentBlockLocationCitationTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestContentBlockLocationCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestTextBlockCitationDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestTextBlockCitationDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestTextBlockTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestTextBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestImageBlockCacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestImageBlockCacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestImageBlockTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestImageBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockSourceContentVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockSourceContentVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockStartEventTypeJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockStartEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaResponseTextBlockTypeJsonConverter(),
                    new global::G.JsonConverters.BetaResponseTextBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaResponseTextBlockCitationDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaResponseTextBlockCitationDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaResponseToolUseBlockTypeJsonConverter(),
                    new global::G.JsonConverters.BetaResponseToolUseBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockStartEventContentBlockDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockStartEventContentBlockDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockStopEventTypeJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockStopEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaToolChoiceAutoTypeJsonConverter(),
                    new global::G.JsonConverters.BetaToolChoiceAutoTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaToolChoiceAnyTypeJsonConverter(),
                    new global::G.JsonConverters.BetaToolChoiceAnyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaToolChoiceToolTypeJsonConverter(),
                    new global::G.JsonConverters.BetaToolChoiceToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaToolChoiceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaToolChoiceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaToolTypeJsonConverter(),
                    new global::G.JsonConverters.BetaToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaInputSchemaTypeJsonConverter(),
                    new global::G.JsonConverters.BetaInputSchemaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaToolCacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaToolCacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaTextEditor20241022CacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaTextEditor20241022CacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaTextEditor20241022TypeJsonConverter(),
                    new global::G.JsonConverters.BetaTextEditor20241022TypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaTextEditor20241022NameJsonConverter(),
                    new global::G.JsonConverters.BetaTextEditor20241022NameNullableJsonConverter(),
                    new global::G.JsonConverters.BetaCountMessageTokensParamsToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaCountMessageTokensParamsToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaInputMessageRoleJsonConverter(),
                    new global::G.JsonConverters.BetaInputMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestToolUseBlockCacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestToolUseBlockCacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestToolUseBlockTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestToolUseBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestToolResultBlockCacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestToolResultBlockCacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestToolResultBlockTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestToolResultBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestDocumentBlockCacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestDocumentBlockCacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestDocumentBlockTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestDocumentBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaPlainTextSourceTypeJsonConverter(),
                    new global::G.JsonConverters.BetaPlainTextSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaPlainTextSourceMediaTypeJsonConverter(),
                    new global::G.JsonConverters.BetaPlainTextSourceMediaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRequestDocumentBlockSourceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRequestDocumentBlockSourceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaInputContentBlockDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaInputContentBlockDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ModelVariant2JsonConverter(),
                    new global::G.JsonConverters.ModelVariant2NullableJsonConverter(),
                    new global::G.JsonConverters.ModelVariant3JsonConverter(),
                    new global::G.JsonConverters.ModelVariant3NullableJsonConverter(),
                    new global::G.JsonConverters.ModelVariant4JsonConverter(),
                    new global::G.JsonConverters.ModelVariant4NullableJsonConverter(),
                    new global::G.JsonConverters.ModelVariant5JsonConverter(),
                    new global::G.JsonConverters.ModelVariant5NullableJsonConverter(),
                    new global::G.JsonConverters.ModelVariant6JsonConverter(),
                    new global::G.JsonConverters.ModelVariant6NullableJsonConverter(),
                    new global::G.JsonConverters.ModelVariant7JsonConverter(),
                    new global::G.JsonConverters.ModelVariant7NullableJsonConverter(),
                    new global::G.JsonConverters.ModelVariant8JsonConverter(),
                    new global::G.JsonConverters.ModelVariant8NullableJsonConverter(),
                    new global::G.JsonConverters.ModelVariant9JsonConverter(),
                    new global::G.JsonConverters.ModelVariant9NullableJsonConverter(),
                    new global::G.JsonConverters.ModelVariant10JsonConverter(),
                    new global::G.JsonConverters.ModelVariant10NullableJsonConverter(),
                    new global::G.JsonConverters.ModelVariant11JsonConverter(),
                    new global::G.JsonConverters.ModelVariant11NullableJsonConverter(),
                    new global::G.JsonConverters.ModelVariant12JsonConverter(),
                    new global::G.JsonConverters.ModelVariant12NullableJsonConverter(),
                    new global::G.JsonConverters.BetaCreateMessageParamsToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaCreateMessageParamsToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaDeleteMessageBatchResponseTypeJsonConverter(),
                    new global::G.JsonConverters.BetaDeleteMessageBatchResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaErrorResponseTypeJsonConverter(),
                    new global::G.JsonConverters.BetaErrorResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaInvalidRequestErrorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaInvalidRequestErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaPermissionErrorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaPermissionErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaNotFoundErrorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaNotFoundErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaRateLimitErrorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaRateLimitErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaGatewayTimeoutErrorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaGatewayTimeoutErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaOverloadedErrorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaOverloadedErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaErrorResponseErrorDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaErrorResponseErrorDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaErroredResultTypeJsonConverter(),
                    new global::G.JsonConverters.BetaErroredResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaExpiredResultTypeJsonConverter(),
                    new global::G.JsonConverters.BetaExpiredResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaMessageBatchTypeJsonConverter(),
                    new global::G.JsonConverters.BetaMessageBatchTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaMessageBatchProcessingStatusJsonConverter(),
                    new global::G.JsonConverters.BetaMessageBatchProcessingStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BetaModelInfoTypeJsonConverter(),
                    new global::G.JsonConverters.BetaModelInfoTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaMessageTypeJsonConverter(),
                    new global::G.JsonConverters.BetaMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaMessageRoleJsonConverter(),
                    new global::G.JsonConverters.BetaMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaMessageStopReasonJsonConverter(),
                    new global::G.JsonConverters.BetaMessageStopReasonNullableJsonConverter(),
                    new global::G.JsonConverters.BetaSucceededResultTypeJsonConverter(),
                    new global::G.JsonConverters.BetaSucceededResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaMessageBatchIndividualResponseResultDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaMessageBatchIndividualResponseResultDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaMessageDeltaStopReasonJsonConverter(),
                    new global::G.JsonConverters.BetaMessageDeltaStopReasonNullableJsonConverter(),
                    new global::G.JsonConverters.BetaMessageDeltaEventTypeJsonConverter(),
                    new global::G.JsonConverters.BetaMessageDeltaEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaMessageStartEventTypeJsonConverter(),
                    new global::G.JsonConverters.BetaMessageStartEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaMessageStopEventTypeJsonConverter(),
                    new global::G.JsonConverters.BetaMessageStopEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BetaMessageStreamEventDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BetaMessageStreamEventDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BillingErrorTypeJsonConverter(),
                    new global::G.JsonConverters.BillingErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CacheControlEphemeralTypeJsonConverter(),
                    new global::G.JsonConverters.CacheControlEphemeralTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CanceledResultTypeJsonConverter(),
                    new global::G.JsonConverters.CanceledResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CitationsDeltaTypeJsonConverter(),
                    new global::G.JsonConverters.CitationsDeltaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseCharLocationCitationTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseCharLocationCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponsePageLocationCitationTypeJsonConverter(),
                    new global::G.JsonConverters.ResponsePageLocationCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseContentBlockLocationCitationTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseContentBlockLocationCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CitationsDeltaCitationDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CitationsDeltaCitationDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CompletionResponseTypeJsonConverter(),
                    new global::G.JsonConverters.CompletionResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ContentBlockDeltaEventTypeJsonConverter(),
                    new global::G.JsonConverters.ContentBlockDeltaEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TextContentBlockDeltaTypeJsonConverter(),
                    new global::G.JsonConverters.TextContentBlockDeltaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.InputJsonContentBlockDeltaTypeJsonConverter(),
                    new global::G.JsonConverters.InputJsonContentBlockDeltaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ContentBlockDeltaEventDeltaDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ContentBlockDeltaEventDeltaDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ContentBlockSourceTypeJsonConverter(),
                    new global::G.JsonConverters.ContentBlockSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestTextBlockCacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.RequestTextBlockCacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestCharLocationCitationTypeJsonConverter(),
                    new global::G.JsonConverters.RequestCharLocationCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestPageLocationCitationTypeJsonConverter(),
                    new global::G.JsonConverters.RequestPageLocationCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestContentBlockLocationCitationTypeJsonConverter(),
                    new global::G.JsonConverters.RequestContentBlockLocationCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestTextBlockCitationDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.RequestTextBlockCitationDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestTextBlockTypeJsonConverter(),
                    new global::G.JsonConverters.RequestTextBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestImageBlockCacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.RequestImageBlockCacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestImageBlockTypeJsonConverter(),
                    new global::G.JsonConverters.RequestImageBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ContentBlockSourceContentVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ContentBlockSourceContentVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ContentBlockStartEventTypeJsonConverter(),
                    new global::G.JsonConverters.ContentBlockStartEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseTextBlockTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseTextBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseTextBlockCitationDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseTextBlockCitationDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseToolUseBlockTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseToolUseBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ContentBlockStartEventContentBlockDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ContentBlockStartEventContentBlockDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ContentBlockStopEventTypeJsonConverter(),
                    new global::G.JsonConverters.ContentBlockStopEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceAutoTypeJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceAutoTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceAnyTypeJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceAnyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceToolTypeJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.InputSchemaTypeJsonConverter(),
                    new global::G.JsonConverters.InputSchemaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolCacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ToolCacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.InputMessageRoleJsonConverter(),
                    new global::G.JsonConverters.InputMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.RequestToolUseBlockCacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.RequestToolUseBlockCacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestToolUseBlockTypeJsonConverter(),
                    new global::G.JsonConverters.RequestToolUseBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestToolResultBlockCacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.RequestToolResultBlockCacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestToolResultBlockTypeJsonConverter(),
                    new global::G.JsonConverters.RequestToolResultBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestToolResultBlockContentVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.RequestToolResultBlockContentVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestDocumentBlockCacheControlDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.RequestDocumentBlockCacheControlDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestDocumentBlockTypeJsonConverter(),
                    new global::G.JsonConverters.RequestDocumentBlockTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PlainTextSourceTypeJsonConverter(),
                    new global::G.JsonConverters.PlainTextSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PlainTextSourceMediaTypeJsonConverter(),
                    new global::G.JsonConverters.PlainTextSourceMediaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RequestDocumentBlockSourceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.RequestDocumentBlockSourceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.InputContentBlockDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.InputContentBlockDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteMessageBatchResponseTypeJsonConverter(),
                    new global::G.JsonConverters.DeleteMessageBatchResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ErrorResponseTypeJsonConverter(),
                    new global::G.JsonConverters.ErrorResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.InvalidRequestErrorTypeJsonConverter(),
                    new global::G.JsonConverters.InvalidRequestErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PermissionErrorTypeJsonConverter(),
                    new global::G.JsonConverters.PermissionErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.NotFoundErrorTypeJsonConverter(),
                    new global::G.JsonConverters.NotFoundErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RateLimitErrorTypeJsonConverter(),
                    new global::G.JsonConverters.RateLimitErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GatewayTimeoutErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GatewayTimeoutErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OverloadedErrorTypeJsonConverter(),
                    new global::G.JsonConverters.OverloadedErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ErrorResponseErrorDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ErrorResponseErrorDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ErroredResultTypeJsonConverter(),
                    new global::G.JsonConverters.ErroredResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ExpiredResultTypeJsonConverter(),
                    new global::G.JsonConverters.ExpiredResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageBatchTypeJsonConverter(),
                    new global::G.JsonConverters.MessageBatchTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageBatchProcessingStatusJsonConverter(),
                    new global::G.JsonConverters.MessageBatchProcessingStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ModelInfoTypeJsonConverter(),
                    new global::G.JsonConverters.ModelInfoTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageTypeJsonConverter(),
                    new global::G.JsonConverters.MessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageRoleJsonConverter(),
                    new global::G.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ContentBlockDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ContentBlockDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageStopReasonJsonConverter(),
                    new global::G.JsonConverters.MessageStopReasonNullableJsonConverter(),
                    new global::G.JsonConverters.SucceededResultTypeJsonConverter(),
                    new global::G.JsonConverters.SucceededResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageBatchIndividualResponseResultDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MessageBatchIndividualResponseResultDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaStopReasonJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaStopReasonNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaEventTypeJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageStartEventTypeJsonConverter(),
                    new global::G.JsonConverters.MessageStartEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageStopEventTypeJsonConverter(),
                    new global::G.JsonConverters.MessageStopEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AnthropicBetaEnumJsonConverter(),
                    new global::G.JsonConverters.AnthropicBetaEnumNullableJsonConverter(),
                    new global::G.JsonConverters.CitationJsonConverter(),
                    new global::G.JsonConverters.DeltaJsonConverter(),
                    new global::G.JsonConverters.ContentVariant2ItemJsonConverter(),
                    new global::G.JsonConverters.CitationsItemJsonConverter(),
                    new global::G.JsonConverters.ContentBlockJsonConverter(),
                    new global::G.JsonConverters.CitationsItem2JsonConverter(),
                    new global::G.JsonConverters.BetaToolChoiceJsonConverter(),
                    new global::G.JsonConverters.ToolsItemJsonConverter(),
                    new global::G.JsonConverters.BetaInputContentBlockJsonConverter(),
                    new global::G.JsonConverters.ContentVariant2Item2JsonConverter(),
                    new global::G.JsonConverters.SourceJsonConverter(),
                    new global::G.JsonConverters.ModelJsonConverter(),
                    new global::G.JsonConverters.ToolsItem2JsonConverter(),
                    new global::G.JsonConverters.ErrorJsonConverter(),
                    new global::G.JsonConverters.BetaContentBlockJsonConverter(),
                    new global::G.JsonConverters.ResultJsonConverter(),
                    new global::G.JsonConverters.BetaMessageStreamEventJsonConverter(),
                    new global::G.JsonConverters.Citation2JsonConverter(),
                    new global::G.JsonConverters.Delta2JsonConverter(),
                    new global::G.JsonConverters.ContentVariant2Item3JsonConverter(),
                    new global::G.JsonConverters.CitationsItem3JsonConverter(),
                    new global::G.JsonConverters.ContentBlock2JsonConverter(),
                    new global::G.JsonConverters.CitationsItem4JsonConverter(),
                    new global::G.JsonConverters.ToolChoiceJsonConverter(),
                    new global::G.JsonConverters.InputContentBlockJsonConverter(),
                    new global::G.JsonConverters.ContentVariant2Item4JsonConverter(),
                    new global::G.JsonConverters.Source2JsonConverter(),
                    new global::G.JsonConverters.Error2JsonConverter(),
                    new global::G.JsonConverters.ContentBlock3JsonConverter(),
                    new global::G.JsonConverters.Result2JsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventJsonConverter(),
                    new global::G.JsonConverters.AnthropicBetaJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.BetaInputContentBlock>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item2>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.BetaRequestTextBlock>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.BetaRequestTextBlock>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item3>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.InputContentBlock>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item4>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.RequestTextBlock>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.RequestTextBlock>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.RequestTextBlock>>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public MessagesClient Messages => new MessagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextCompletionsClient TextCompletions => new TextCompletionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MessageBatchesClient MessageBatches => new MessageBatchesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}