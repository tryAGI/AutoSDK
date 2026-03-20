//HintName: G.IGenerationPresetsClient.ListGenerationPresets.g.cs
#nullable enable

namespace G
{
    public partial interface IGenerationPresetsClient
    {

        /// <summary>
        /// List generation presets<br/>
        /// Organizations often struggle to fine-tune query responses and maintain consistency across different use cases. Vectara creates and maintains predefined generation presets for our users which provides a flexible and powerful way to utilize generation parameters. Each preset includes a complete Velocity template for the prompt along with other generation parameters. Presets are typically associated with a single LLM.<br/>
        /// The List Generation Presets API lets you view the generation presets used for [query](/docs/rest-api/queries) requests. Generation presets group several properties that configure generation for a request. These presets provide more flexibility in how generation parameters are configured, enabling more fine-tuned control over query responses.<br/>
        /// This includes the `prompt_template`, the Large Language Model (LLM), and other generation settings like `max_tokens` and `temperature`. Users specify a generation preset in their query or chat requests using the `generation_preset_name` field.<br/>
        /// ## Generation presets object<br/>
        /// The `generation_presets` object contains the `name`, `description`, `llm_name`, `prompt_template`, and other fields make up the preset.<br/>
        /// If your account has access to a preset, then `enabled` is set to `true`. A preset can also be set as a `default`.\n\n### Example generation presets response\n\n```json\n{\n  \"generation_presets\": [\n    {\n      \"name\": \"vectara-summary-ext-24-05-med-omni\",\n      \"description\": \"Generate summary with controllable citations, Uses GPT-4o with 2,048 max tokens\",\n      \"llm_name\": \"gpt-4o\",\n      \"prompt_template\": \"[\\n    {\\\"role\\\": \\\"system\\\", \\\"content\\\": \\\"Follow these detailed step-by-step\",\n      \"max_used_search_results\": 25,\n      \"max_tokens\": 2048,\n      \"temperature\": 0,\n      \"frequency_penalty\": 0,\n      \"presence_penalty\": 0,\n      \"enabled\": true,\n      \"default\": false\n    },\n    // More presets appear here\n}\n```\n"
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="llmName">
        /// Example: mockingbird-2.0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListGenerationPresetsResponse> ListGenerationPresetsAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? llmName = default,
            int? limit = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}