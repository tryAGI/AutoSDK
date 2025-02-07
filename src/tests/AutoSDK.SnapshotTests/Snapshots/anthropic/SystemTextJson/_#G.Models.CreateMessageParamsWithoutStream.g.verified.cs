//HintName: G.Models.CreateMessageParamsWithoutStream.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMessageParamsWithoutStream
    {
        /// <summary>
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Model Model { get; set; }

        /// <summary>
        /// Input messages.<br/>
        /// Our models are trained to operate on alternating `user` and `assistant` conversational turns. When creating a new `Message`, you specify the prior conversational turns with the `messages` parameter, and the model then generates the next `Message` in the conversation. Consecutive `user` or `assistant` turns in your request will be combined into a single turn.<br/>
        /// Each input message must be an object with a `role` and `content`. You can specify a single `user`-role message, or you can include multiple `user` and `assistant` messages.<br/>
        /// If the final message uses the `assistant` role, the response content will continue immediately from the content in that message. This can be used to constrain part of the model's response.<br/>
        /// Example with a single `user` message:<br/>
        /// ```json<br/>
        /// [{"role": "user", "content": "Hello, Claude"}]<br/>
        /// ```<br/>
        /// Example with multiple conversational turns:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {"role": "user", "content": "Hello there."},<br/>
        ///   {"role": "assistant", "content": "Hi, I'm Claude. How can I help you?"},<br/>
        ///   {"role": "user", "content": "Can you explain LLMs in plain English?"},<br/>
        /// ]<br/>
        /// ```<br/>
        /// Example with a partially-filled response from Claude:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {"role": "user", "content": "What's the Greek name for Sun? (A) Sol (B) Helios (C) Sun"},<br/>
        ///   {"role": "assistant", "content": "The best answer is ("},<br/>
        /// ]<br/>
        /// ```<br/>
        /// Each input message `content` may be either a single `string` or an array of content blocks, where each block has a specific `type`. Using a `string` for `content` is shorthand for an array of one content block of type `"text"`. The following input messages are equivalent:<br/>
        /// ```json<br/>
        /// {"role": "user", "content": "Hello, Claude"}<br/>
        /// ```<br/>
        /// ```json<br/>
        /// {"role": "user", "content": [{"type": "text", "text": "Hello, Claude"}]}<br/>
        /// ```<br/>
        /// Starting with Claude 3 models, you can also send image content blocks:<br/>
        /// ```json<br/>
        /// {"role": "user", "content": [<br/>
        ///   {<br/>
        ///     "type": "image",<br/>
        ///     "source": {<br/>
        ///       "type": "base64",<br/>
        ///       "media_type": "image/jpeg",<br/>
        ///       "data": "/9j/4AAQSkZJRg...",<br/>
        ///     }<br/>
        ///   },<br/>
        ///   {"type": "text", "text": "What is in this image?"}<br/>
        /// ]}<br/>
        /// ```<br/>
        /// We currently support the `base64` source type for images, and the `image/jpeg`, `image/png`, `image/gif`, and `image/webp` media types.<br/>
        /// See [examples](https://docs.anthropic.com/en/api/messages-examples#vision) for more input examples.<br/>
        /// Note that if you want to include a [system prompt](https://docs.anthropic.com/en/docs/system-prompts), you can use the top-level `system` parameter — there is no `"system"` role for input messages in the Messages API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.InputMessage> Messages { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate before stopping.<br/>
        /// Note that our models may stop _before_ reaching this maximum. This parameter only specifies the absolute maximum number of tokens to generate.<br/>
        /// Different models have different maximum values for this parameter.  See [models](https://docs.anthropic.com/en/docs/models-overview) for details.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTokens { get; set; }

        /// <summary>
        /// An object describing metadata about the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.Metadata? Metadata { get; set; }

        /// <summary>
        /// Custom text sequences that will cause the model to stop generating.<br/>
        /// Our models will normally stop when they have naturally completed their turn, which will result in a response `stop_reason` of `"end_turn"`.<br/>
        /// If you want the model to stop generating when it encounters custom strings of text, you can use the `stop_sequences` parameter. If the model encounters one of the custom sequences, the response `stop_reason` value will be `"stop_sequence"` and the response `stop_sequence` value will contain the matched stop sequence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// System prompt.<br/>
        /// A system prompt is a way of providing context and instructions to Claude, such as specifying a particular goal or role. See our [guide to system prompts](https://docs.anthropic.com/en/docs/system-prompts).<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.RequestTextBlock>>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.RequestTextBlock>>? System { get; set; }

        /// <summary>
        /// Amount of randomness injected into the response.<br/>
        /// Defaults to `1.0`. Ranges from `0.0` to `1.0`. Use `temperature` closer to `0.0` for analytical / multiple choice, and closer to `1.0` for creative and generative tasks.<br/>
        /// Note that even with `temperature` of `0.0`, the results will not be fully deterministic.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// How the model should use the provided tools. The model can use a specific tool, any available tool, or decide by itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolChoiceJsonConverter))]
        public global::G.ToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Definitions of tools that the model may use.<br/>
        /// If you include `tools` in your API request, the model may return `tool_use` content blocks that represent the model's use of those tools. You can then run those tools using the tool input generated by the model and then optionally return results back to the model using `tool_result` content blocks.<br/>
        /// Each tool definition includes:<br/>
        /// * `name`: Name of the tool.<br/>
        /// * `description`: Optional, but strongly-recommended description of the tool.<br/>
        /// * `input_schema`: [JSON schema](https://json-schema.org/) for the tool `input` shape that the model will produce in `tool_use` output content blocks.<br/>
        /// For example, if you defined `tools` as:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "name": "get_stock_price",<br/>
        ///     "description": "Get the current stock price for a given ticker symbol.",<br/>
        ///     "input_schema": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "ticker": {<br/>
        ///           "type": "string",<br/>
        ///           "description": "The stock ticker symbol, e.g. AAPL for Apple Inc."<br/>
        ///         }<br/>
        ///       },<br/>
        ///       "required": ["ticker"]<br/>
        ///     }<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// And then asked the model "What's the S&amp;P 500 at today?", the model might produce `tool_use` content blocks in the response like this:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "type": "tool_use",<br/>
        ///     "id": "toolu_01D7FLrfh4GYq7yT1ULFeyMV",<br/>
        ///     "name": "get_stock_price",<br/>
        ///     "input": { "ticker": "^GSPC" }<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// You might then run your `get_stock_price` tool with `{"ticker": "^GSPC"}` as an input, and return the following back to the model in a subsequent `user` message:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "type": "tool_result",<br/>
        ///     "tool_use_id": "toolu_01D7FLrfh4GYq7yT1ULFeyMV",<br/>
        ///     "content": "259.75 USD"<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// Tools can be used for workflows that include running client-side tools and functions, or more generally whenever you want the model to produce a particular JSON structure of output.<br/>
        /// See our [guide](https://docs.anthropic.com/en/docs/tool-use) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// Only sample from the top K options for each subsequent token.<br/>
        /// Used to remove "long tail" low probability responses. [Learn more technical details here](https://towardsdatascience.com/how-to-sample-from-language-models-682bceb97277).<br/>
        /// Recommended for advanced use cases only. You usually only need to use `temperature`.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Use nucleus sampling.<br/>
        /// In nucleus sampling, we compute the cumulative distribution over all the options for each subsequent token in decreasing probability order and cut it off once it reaches a particular probability specified by `top_p`. You should either alter `temperature` or `top_p`, but not both.<br/>
        /// Recommended for advanced use cases only. You usually only need to use `temperature`.<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageParamsWithoutStream" /> class.
        /// </summary>
        /// <param name="model">
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </param>
        /// <param name="messages">
        /// Input messages.<br/>
        /// Our models are trained to operate on alternating `user` and `assistant` conversational turns. When creating a new `Message`, you specify the prior conversational turns with the `messages` parameter, and the model then generates the next `Message` in the conversation. Consecutive `user` or `assistant` turns in your request will be combined into a single turn.<br/>
        /// Each input message must be an object with a `role` and `content`. You can specify a single `user`-role message, or you can include multiple `user` and `assistant` messages.<br/>
        /// If the final message uses the `assistant` role, the response content will continue immediately from the content in that message. This can be used to constrain part of the model's response.<br/>
        /// Example with a single `user` message:<br/>
        /// ```json<br/>
        /// [{"role": "user", "content": "Hello, Claude"}]<br/>
        /// ```<br/>
        /// Example with multiple conversational turns:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {"role": "user", "content": "Hello there."},<br/>
        ///   {"role": "assistant", "content": "Hi, I'm Claude. How can I help you?"},<br/>
        ///   {"role": "user", "content": "Can you explain LLMs in plain English?"},<br/>
        /// ]<br/>
        /// ```<br/>
        /// Example with a partially-filled response from Claude:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {"role": "user", "content": "What's the Greek name for Sun? (A) Sol (B) Helios (C) Sun"},<br/>
        ///   {"role": "assistant", "content": "The best answer is ("},<br/>
        /// ]<br/>
        /// ```<br/>
        /// Each input message `content` may be either a single `string` or an array of content blocks, where each block has a specific `type`. Using a `string` for `content` is shorthand for an array of one content block of type `"text"`. The following input messages are equivalent:<br/>
        /// ```json<br/>
        /// {"role": "user", "content": "Hello, Claude"}<br/>
        /// ```<br/>
        /// ```json<br/>
        /// {"role": "user", "content": [{"type": "text", "text": "Hello, Claude"}]}<br/>
        /// ```<br/>
        /// Starting with Claude 3 models, you can also send image content blocks:<br/>
        /// ```json<br/>
        /// {"role": "user", "content": [<br/>
        ///   {<br/>
        ///     "type": "image",<br/>
        ///     "source": {<br/>
        ///       "type": "base64",<br/>
        ///       "media_type": "image/jpeg",<br/>
        ///       "data": "/9j/4AAQSkZJRg...",<br/>
        ///     }<br/>
        ///   },<br/>
        ///   {"type": "text", "text": "What is in this image?"}<br/>
        /// ]}<br/>
        /// ```<br/>
        /// We currently support the `base64` source type for images, and the `image/jpeg`, `image/png`, `image/gif`, and `image/webp` media types.<br/>
        /// See [examples](https://docs.anthropic.com/en/api/messages-examples#vision) for more input examples.<br/>
        /// Note that if you want to include a [system prompt](https://docs.anthropic.com/en/docs/system-prompts), you can use the top-level `system` parameter — there is no `"system"` role for input messages in the Messages API.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate before stopping.<br/>
        /// Note that our models may stop _before_ reaching this maximum. This parameter only specifies the absolute maximum number of tokens to generate.<br/>
        /// Different models have different maximum values for this parameter.  See [models](https://docs.anthropic.com/en/docs/models-overview) for details.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="metadata">
        /// An object describing metadata about the request.
        /// </param>
        /// <param name="stopSequences">
        /// Custom text sequences that will cause the model to stop generating.<br/>
        /// Our models will normally stop when they have naturally completed their turn, which will result in a response `stop_reason` of `"end_turn"`.<br/>
        /// If you want the model to stop generating when it encounters custom strings of text, you can use the `stop_sequences` parameter. If the model encounters one of the custom sequences, the response `stop_reason` value will be `"stop_sequence"` and the response `stop_sequence` value will contain the matched stop sequence.
        /// </param>
        /// <param name="system">
        /// System prompt.<br/>
        /// A system prompt is a way of providing context and instructions to Claude, such as specifying a particular goal or role. See our [guide to system prompts](https://docs.anthropic.com/en/docs/system-prompts).<br/>
        /// Example: []
        /// </param>
        /// <param name="temperature">
        /// Amount of randomness injected into the response.<br/>
        /// Defaults to `1.0`. Ranges from `0.0` to `1.0`. Use `temperature` closer to `0.0` for analytical / multiple choice, and closer to `1.0` for creative and generative tasks.<br/>
        /// Note that even with `temperature` of `0.0`, the results will not be fully deterministic.<br/>
        /// Example: 1
        /// </param>
        /// <param name="toolChoice">
        /// How the model should use the provided tools. The model can use a specific tool, any available tool, or decide by itself.
        /// </param>
        /// <param name="tools">
        /// Definitions of tools that the model may use.<br/>
        /// If you include `tools` in your API request, the model may return `tool_use` content blocks that represent the model's use of those tools. You can then run those tools using the tool input generated by the model and then optionally return results back to the model using `tool_result` content blocks.<br/>
        /// Each tool definition includes:<br/>
        /// * `name`: Name of the tool.<br/>
        /// * `description`: Optional, but strongly-recommended description of the tool.<br/>
        /// * `input_schema`: [JSON schema](https://json-schema.org/) for the tool `input` shape that the model will produce in `tool_use` output content blocks.<br/>
        /// For example, if you defined `tools` as:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "name": "get_stock_price",<br/>
        ///     "description": "Get the current stock price for a given ticker symbol.",<br/>
        ///     "input_schema": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "ticker": {<br/>
        ///           "type": "string",<br/>
        ///           "description": "The stock ticker symbol, e.g. AAPL for Apple Inc."<br/>
        ///         }<br/>
        ///       },<br/>
        ///       "required": ["ticker"]<br/>
        ///     }<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// And then asked the model "What's the S&amp;P 500 at today?", the model might produce `tool_use` content blocks in the response like this:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "type": "tool_use",<br/>
        ///     "id": "toolu_01D7FLrfh4GYq7yT1ULFeyMV",<br/>
        ///     "name": "get_stock_price",<br/>
        ///     "input": { "ticker": "^GSPC" }<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// You might then run your `get_stock_price` tool with `{"ticker": "^GSPC"}` as an input, and return the following back to the model in a subsequent `user` message:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "type": "tool_result",<br/>
        ///     "tool_use_id": "toolu_01D7FLrfh4GYq7yT1ULFeyMV",<br/>
        ///     "content": "259.75 USD"<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// Tools can be used for workflows that include running client-side tools and functions, or more generally whenever you want the model to produce a particular JSON structure of output.<br/>
        /// See our [guide](https://docs.anthropic.com/en/docs/tool-use) for more details.
        /// </param>
        /// <param name="topK">
        /// Only sample from the top K options for each subsequent token.<br/>
        /// Used to remove "long tail" low probability responses. [Learn more technical details here](https://towardsdatascience.com/how-to-sample-from-language-models-682bceb97277).<br/>
        /// Recommended for advanced use cases only. You usually only need to use `temperature`.<br/>
        /// Example: 5
        /// </param>
        /// <param name="topP">
        /// Use nucleus sampling.<br/>
        /// In nucleus sampling, we compute the cumulative distribution over all the options for each subsequent token in decreasing probability order and cut it off once it reaches a particular probability specified by `top_p`. You should either alter `temperature` or `top_p`, but not both.<br/>
        /// Recommended for advanced use cases only. You usually only need to use `temperature`.<br/>
        /// Example: 0.7
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMessageParamsWithoutStream(
            global::G.Model model,
            global::System.Collections.Generic.IList<global::G.InputMessage> messages,
            int maxTokens,
            global::G.Metadata? metadata,
            global::System.Collections.Generic.IList<string>? stopSequences,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.RequestTextBlock>>? system,
            double? temperature,
            global::G.ToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            int? topK,
            double? topP)
        {
            this.Model = model;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.MaxTokens = maxTokens;
            this.Metadata = metadata;
            this.StopSequences = stopSequences;
            this.System = system;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TopK = topK;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageParamsWithoutStream" /> class.
        /// </summary>
        public CreateMessageParamsWithoutStream()
        {
        }
    }
}