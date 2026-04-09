//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Photoroom API takes an image as input, applies edits (background removal, AI backgrounds, shadows, relighting, text removal, flat lay, ghost mannequin, virtual model, and more), and returns the edited image.<br/>
    /// For tested parameter combinations for common use cases, see our tutorials before building your integration:<br/>
    /// - Second-hand marketplace listings: https://docs.photoroom.com/tutorials/how-to-improve-images-for-second-hand-item-marketplaces<br/>
    /// - E-commerce with brand consistency: https://docs.photoroom.com/tutorials/how-to-create-e-commerce-images-with-consistent-brand-guidelines<br/>
    /// - Food delivery apps: https://docs.photoroom.com/tutorials/how-to-create-food-delivery-images-with-consistent-brand-guidelines<br/>
    /// - Google Shopping compliance: https://docs.photoroom.com/tutorials/how-to-create-compliant-product-images-for-google-shopping<br/>
    /// - Sticker images: https://docs.photoroom.com/tutorials/how-to-create-sticker-images<br/>
    /// To use the API, you need an API key. Create one at https://app.photoroom.com/api-dashboard. The key must be passed in the x-api-key header on every request.<br/>
    /// Full documentation: https://docs.photoroom.com<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "";

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
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.RemoveBackgroundPostParamsFormatJsonConverter(),
                    new global::G.JsonConverters.RemoveBackgroundPostParamsFormatNullableJsonConverter(),
                    new global::G.JsonConverters.RemoveBackgroundPostParamsChannelsJsonConverter(),
                    new global::G.JsonConverters.RemoveBackgroundPostParamsChannelsNullableJsonConverter(),
                    new global::G.JsonConverters.RemoveBackgroundPostParamsSizeJsonConverter(),
                    new global::G.JsonConverters.RemoveBackgroundPostParamsSizeNullableJsonConverter(),
                    new global::G.JsonConverters.RemoveBackgroundPostParamsCropJsonConverter(),
                    new global::G.JsonConverters.RemoveBackgroundPostParamsCropNullableJsonConverter(),
                    new global::G.JsonConverters.RemoveBackgroundPostParamsDespillJsonConverter(),
                    new global::G.JsonConverters.RemoveBackgroundPostParamsDespillNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetBackgroundBlurModeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetBackgroundBlurModeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetBackgroundExpandPromptModeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetBackgroundExpandPromptModeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetBackgroundScalingJsonConverter(),
                    new global::G.JsonConverters.EditImageGetBackgroundScalingNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetBeautifyModeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetBeautifyModeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetExportFormatJsonConverter(),
                    new global::G.JsonConverters.EditImageGetExportFormatNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetFlatLaySizeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetFlatLaySizeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetGhostMannequinSizeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetGhostMannequinSizeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetHorizontalAlignmentJsonConverter(),
                    new global::G.JsonConverters.EditImageGetHorizontalAlignmentNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetImageFromPromptSizeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetImageFromPromptSizeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetKeepExistingAlphaChannelJsonConverter(),
                    new global::G.JsonConverters.EditImageGetKeepExistingAlphaChannelNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLayersVariant2ImageHorizontalAlignmentJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLayersVariant2ImageHorizontalAlignmentNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLayersVariant2ImageImageFromPromptSizeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLayersVariant2ImageImageFromPromptSizeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLayersVariant2ImageRemoveBackgroundJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLayersVariant2ImageRemoveBackgroundNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLayersVariant2ImageSegmentationModeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLayersVariant2ImageSegmentationModeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLayersVariant2ImageUseForAIBackgroundJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLayersVariant2ImageUseForAIBackgroundNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLayersVariant2ImageVerticalAlignmentJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLayersVariant2ImageVerticalAlignmentNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLightingModeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetLightingModeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetPreserveMetadataJsonConverter(),
                    new global::G.JsonConverters.EditImageGetPreserveMetadataNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetReferenceBoxJsonConverter(),
                    new global::G.JsonConverters.EditImageGetReferenceBoxNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetScalingJsonConverter(),
                    new global::G.JsonConverters.EditImageGetScalingNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetSegmentationModeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetSegmentationModeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetShadowModeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetShadowModeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetTextRemovalModeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetTextRemovalModeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetUpscaleModeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetUpscaleModeNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetVerticalAlignmentJsonConverter(),
                    new global::G.JsonConverters.EditImageGetVerticalAlignmentNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetVirtualModelModelVariant1PresetNameJsonConverter(),
                    new global::G.JsonConverters.EditImageGetVirtualModelModelVariant1PresetNameNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetVirtualModelPoseJsonConverter(),
                    new global::G.JsonConverters.EditImageGetVirtualModelPoseNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetVirtualModelQualityJsonConverter(),
                    new global::G.JsonConverters.EditImageGetVirtualModelQualityNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetVirtualModelSceneVariant1PresetNameJsonConverter(),
                    new global::G.JsonConverters.EditImageGetVirtualModelSceneVariant1PresetNameNullableJsonConverter(),
                    new global::G.JsonConverters.EditImageGetVirtualModelSizeJsonConverter(),
                    new global::G.JsonConverters.EditImageGetVirtualModelSizeNullableJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, string, global::G.EditImageGetBackgroundExpandPrompt2>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.EditImageGetLayersVariant1, global::G.EditImageGetLayersVariant2>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.EditImageGetVirtualModelModelVariant1, global::G.EditImageGetVirtualModelModelVariant2>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.EditImageGetVirtualModelSceneVariant1, global::G.EditImageGetVirtualModelSceneVariant2>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


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