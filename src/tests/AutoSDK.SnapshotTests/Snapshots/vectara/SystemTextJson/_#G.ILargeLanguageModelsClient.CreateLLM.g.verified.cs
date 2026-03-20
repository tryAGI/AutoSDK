//HintName: G.ILargeLanguageModelsClient.CreateLLM.g.cs
#nullable enable

namespace G
{
    public partial interface ILargeLanguageModelsClient
    {
        /// <summary>
        /// Create an LLM<br/>
        /// Integrate external Large Language Models (LLMs) into Vectara for Retrieval Augmented Generation (RAG) and chat. Connect OpenAI API-compatible models from providers like Anthropic, Azure, Google, or custom-hosted endpoints. Once created, reference your custom LLM by name in query generation parameters.<br/>
        /// - Connect external LLMs using OpenAI-compatible API format<br/>
        /// - Configure multiple LLM providers for different use cases<br/>
        /// - Override Vectara's built-in LLMs with your own models<br/>
        /// - Use custom models for RAG, chat, and document summarization<br/>
        /// **Example providers:**<br/>
        /// ### OpenAI<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** GPT-4o, GPT-5<br/>
        /// **Auth:** Bearer token<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-gpt5",<br/>
        ///   "model": "gpt-5",<br/>
        ///   "uri": "https://api.openai.com/v1/chat/completions",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "sk-..."<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### OpenAI Responses API<br/>
        /// **Type**: openai-responses<br/>
        /// **Models**: o1-preview, o1-mini, o3-mini (reasoning models)<br/>
        /// **Auth**: Bearer token<br/>
        /// **Note**: For reasoning models that don't support streaming<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-responses",<br/>
        ///   "name": "my-o1",<br/>
        ///   "model": "o1-preview",<br/>
        ///   "uri": "https://api.openai.com/v1/chat/completions",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "sk-..."<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Anthropic Claude<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** claude-4-opus, claude-4-5-haiku, claude-4-5-sonnet<br/>
        /// **Auth:** Bearer token with header<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-claude",<br/>
        ///   "model": "claude-sonnet-4-5-20250929",<br/>
        ///   "uri": "https://api.anthropic.com/v1/messages",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "sk-ant-..."<br/>
        ///   },<br/>
        ///   "headers": {<br/>
        ///     "anthropic-version": "2023-06-01"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Azure OpenAI<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** GPT-3.5, GPT-4 (Azure-deployed versions)<br/>
        /// **Auth:** Custom header (api-key)<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-azure-gpt4",<br/>
        ///   "model": "gpt-4",<br/>
        ///   "uri": "https://YOUR-RESOURCE.openai.azure.com/openai/deployments/YOUR-DEPLOYMENT/chat/completions?api-version=2024-02-15-preview",<br/>
        ///   "auth": {<br/>
        ///     "type": "header",<br/>
        ///     "header": "api-key",<br/>
        ///     "value": "your-azure-key"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Google Vertex AI (Gemini) — Service Account<br/>
        /// **Type:** `vertex-ai`<br/>
        /// **Models:** gemini-2.5-pro, gemini-2.5-flash<br/>
        /// **Auth:** Service account<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "vertex-ai",<br/>
        ///   "name": "my-gemini",<br/>
        ///   "model": "gemini-2.5-flash",<br/>
        ///   "uri": "https://us-central1-aiplatform.googleapis.com/v1/projects/YOUR-PROJECT/locations/us-central1",<br/>
        ///   "auth": {<br/>
        ///     "type": "service_account",<br/>
        ///     "key_json": "{...service account JSON...}"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Google AI Studio (Gemini) — API Key<br/>
        /// **Type:** `vertex-ai`<br/>
        /// **Models:** gemini-2.5-pro, gemini-2.5-flash<br/>
        /// **Auth:** API key<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "vertex-ai",<br/>
        ///   "name": "my-gemini",<br/>
        ///   "model": "gemini-2.5-flash",<br/>
        ///   "uri": "https://generativelanguage.googleapis.com/v1beta",<br/>
        ///   "auth": {<br/>
        ///     "type": "api_key",<br/>
        ///     "api_key": "your-google-api-key"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// The `uri` field is flexible — you can provide a base URI or a full URL copied from Google docs<br/>
        /// (including model path and `:generateContent` suffix). The system normalizes it automatically.<br/>
        /// ### Custom OpenAI-Compatible<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** Any self-hosted or custom LLM, such as OpenRouter.<br/>
        /// **Auth:** Bearer or custom header<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-custom-llm",<br/>
        ///   "model": "llama-3-70b",<br/>
        ///   "uri": "https://my-llm-endpoint.com/v1/chat/completions",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "custom-token"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Llm> CreateLLMAsync(

            global::G.CreateLLMRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an LLM<br/>
        /// Integrate external Large Language Models (LLMs) into Vectara for Retrieval Augmented Generation (RAG) and chat. Connect OpenAI API-compatible models from providers like Anthropic, Azure, Google, or custom-hosted endpoints. Once created, reference your custom LLM by name in query generation parameters.<br/>
        /// - Connect external LLMs using OpenAI-compatible API format<br/>
        /// - Configure multiple LLM providers for different use cases<br/>
        /// - Override Vectara's built-in LLMs with your own models<br/>
        /// - Use custom models for RAG, chat, and document summarization<br/>
        /// **Example providers:**<br/>
        /// ### OpenAI<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** GPT-4o, GPT-5<br/>
        /// **Auth:** Bearer token<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-gpt5",<br/>
        ///   "model": "gpt-5",<br/>
        ///   "uri": "https://api.openai.com/v1/chat/completions",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "sk-..."<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### OpenAI Responses API<br/>
        /// **Type**: openai-responses<br/>
        /// **Models**: o1-preview, o1-mini, o3-mini (reasoning models)<br/>
        /// **Auth**: Bearer token<br/>
        /// **Note**: For reasoning models that don't support streaming<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-responses",<br/>
        ///   "name": "my-o1",<br/>
        ///   "model": "o1-preview",<br/>
        ///   "uri": "https://api.openai.com/v1/chat/completions",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "sk-..."<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Anthropic Claude<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** claude-4-opus, claude-4-5-haiku, claude-4-5-sonnet<br/>
        /// **Auth:** Bearer token with header<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-claude",<br/>
        ///   "model": "claude-sonnet-4-5-20250929",<br/>
        ///   "uri": "https://api.anthropic.com/v1/messages",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "sk-ant-..."<br/>
        ///   },<br/>
        ///   "headers": {<br/>
        ///     "anthropic-version": "2023-06-01"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Azure OpenAI<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** GPT-3.5, GPT-4 (Azure-deployed versions)<br/>
        /// **Auth:** Custom header (api-key)<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-azure-gpt4",<br/>
        ///   "model": "gpt-4",<br/>
        ///   "uri": "https://YOUR-RESOURCE.openai.azure.com/openai/deployments/YOUR-DEPLOYMENT/chat/completions?api-version=2024-02-15-preview",<br/>
        ///   "auth": {<br/>
        ///     "type": "header",<br/>
        ///     "header": "api-key",<br/>
        ///     "value": "your-azure-key"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Google Vertex AI (Gemini) — Service Account<br/>
        /// **Type:** `vertex-ai`<br/>
        /// **Models:** gemini-2.5-pro, gemini-2.5-flash<br/>
        /// **Auth:** Service account<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "vertex-ai",<br/>
        ///   "name": "my-gemini",<br/>
        ///   "model": "gemini-2.5-flash",<br/>
        ///   "uri": "https://us-central1-aiplatform.googleapis.com/v1/projects/YOUR-PROJECT/locations/us-central1",<br/>
        ///   "auth": {<br/>
        ///     "type": "service_account",<br/>
        ///     "key_json": "{...service account JSON...}"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Google AI Studio (Gemini) — API Key<br/>
        /// **Type:** `vertex-ai`<br/>
        /// **Models:** gemini-2.5-pro, gemini-2.5-flash<br/>
        /// **Auth:** API key<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "vertex-ai",<br/>
        ///   "name": "my-gemini",<br/>
        ///   "model": "gemini-2.5-flash",<br/>
        ///   "uri": "https://generativelanguage.googleapis.com/v1beta",<br/>
        ///   "auth": {<br/>
        ///     "type": "api_key",<br/>
        ///     "api_key": "your-google-api-key"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// The `uri` field is flexible — you can provide a base URI or a full URL copied from Google docs<br/>
        /// (including model path and `:generateContent` suffix). The system normalizes it automatically.<br/>
        /// ### Custom OpenAI-Compatible<br/>
        /// **Type:** `openai-compatible`<br/>
        /// **Models:** Any self-hosted or custom LLM, such as OpenRouter.<br/>
        /// **Auth:** Bearer or custom header<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "openai-compatible",<br/>
        ///   "name": "my-custom-llm",<br/>
        ///   "model": "llama-3-70b",<br/>
        ///   "uri": "https://my-llm-endpoint.com/v1/chat/completions",<br/>
        ///   "auth": {<br/>
        ///     "type": "bearer",<br/>
        ///     "token": "custom-token"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Llm> CreateLLMAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}