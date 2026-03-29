//HintName: G.IModelsClient.GetModels.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Model search<br/>
        /// Unified endpoint for discovering model endpoints. Supports three usage modes:<br/>
        /// **1. List Mode** (no parameters):<br/>
        /// Paginated list of all available model endpoints with minimal metadata.<br/>
        /// **2. Find Mode** (`endpoint_id` parameter):<br/>
        /// Retrieve specific model endpoint(s) by ID. Supports single or multiple IDs.<br/>
        /// **3. Search Mode** (search parameters):<br/>
        /// Filter models by free-text query, category, or status.<br/>
        /// **Expansion:**<br/>
        /// Use `expand` to include additional data in each model object:<br/>
        /// - `openapi-3.0` — full OpenAPI 3.0 schema in the `openapi` field<br/>
        /// - `enterprise_status` — enterprise readiness status (`ready` or `pending`) in the `enterprise_status` field<br/>
        /// **Examples of `endpoint_id` values:**<br/>
        /// - `fal-ai/flux/dev`<br/>
        /// - `fal-ai/wan/v2.2-a14b/text-to-video`<br/>
        /// - `fal-ai/minimax/video-01/image-to-video`<br/>
        /// - `fal-ai/hunyuan3d-v21`<br/>
        /// See [fal.ai Model APIs](https://docs.fal.ai/model-apis) for more details.<br/>
        /// **Authentication:** Optional. Providing an API key grants higher rate limits.<br/>
        /// **Common Use Cases:**<br/>
        /// - Browse available models for integration<br/>
        /// - Retrieve metadata for specific endpoints<br/>
        /// - Search for models by category or keywords<br/>
        /// - Get OpenAPI schemas for code generation<br/>
        /// - Build model selection interfaces<br/>
        ///     
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="endpointId">
        /// Endpoint ID(s) to retrieve (e.g., 'fal-ai/flux/dev'). Can be a single value or multiple values (1-50 models). When combined with search params, narrows results to these IDs. Use array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev, fal-ai/flux-pro]
        /// </param>
        /// <param name="q">
        /// Free-text search query to filter models by name, description, or category<br/>
        /// Example: text to image
        /// </param>
        /// <param name="category">
        /// Filter by category (e.g., 'text-to-image', 'image-to-video', 'training')<br/>
        /// Example: text-to-image
        /// </param>
        /// <param name="status">
        /// Filter models by status - omit to include all statuses<br/>
        /// Example: active
        /// </param>
        /// <param name="expand">
        /// Fields to expand in the response. Supported values: 'openapi-3.0' (includes full OpenAPI 3.0 schema in 'openapi' field), 'enterprise_status' (includes enterprise readiness status)<br/>
        /// Example: [openapi-3.0, enterprise_status]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetModelsResponse> GetModelsAsync(
            int? limit = default,
            string? cursor = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            string? q = default,
            string? category = default,
            global::G.GetModelsStatus? status = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}