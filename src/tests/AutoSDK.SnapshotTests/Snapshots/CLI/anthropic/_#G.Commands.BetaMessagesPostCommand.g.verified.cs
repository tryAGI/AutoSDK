//HintName: G.Commands.BetaMessagesPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BetaMessagesPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? anthropicBeta,
            string? anthropicVersion,
            global::G.Model model,
            global::System.Collections.Generic.IList<global::G.BetaInputMessage> messages,
            int maxTokens,
            global::G.BetaMetadata? metadata,
            global::System.Collections.Generic.IList<string>? stopSequences,
            bool? stream,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.BetaRequestTextBlock>>? system,
            double? temperature,
            global::G.BetaThinkingConfigParam? thinking,
            global::G.BetaToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.BetaTool, global::G.BetaComputerUseTool20241022, global::G.BetaBashTool20241022, global::G.BetaTextEditor20241022, global::G.BetaComputerUseTool20250124, global::G.BetaBashTool20250124, global::G.BetaTextEditor20250124>>? tools,
            int? topK,
            double? topP,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BetaMessage response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.Model> Model { get; } = new(
            name: "model")
        {
            Description = @"The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.BetaInputMessage>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"Input messages.

Our models are trained to operate on alternating `user` and `assistant` conversational turns. When creating a new `Message`, you specify the prior conversational turns with the `messages` parameter, and the model then generates the next `Message` in the conversation. Consecutive `user` or `assistant` turns in your request will be combined into a single turn.

Each input message must be an object with a `role` and `content`. You can specify a single `user`-role message, or you can include multiple `user` and `assistant` messages.

If the final message uses the `assistant` role, the response content will continue immediately from the content in that message. This can be used to constrain part of the model's response.

Example with a single `user` message:

```json
[{""role"": ""user"", ""content"": ""Hello, Claude""}]
```

Example with multiple conversational turns:

```json
[
  {""role"": ""user"", ""content"": ""Hello there.""},
  {""role"": ""assistant"", ""content"": ""Hi, I'm Claude. How can I help you?""},
  {""role"": ""user"", ""content"": ""Can you explain LLMs in plain English?""},
]
```

Example with a partially-filled response from Claude:

```json
[
  {""role"": ""user"", ""content"": ""What's the Greek name for Sun? (A) Sol (B) Helios (C) Sun""},
  {""role"": ""assistant"", ""content"": ""The best answer is (""},
]
```

Each input message `content` may be either a single `string` or an array of content blocks, where each block has a specific `type`. Using a `string` for `content` is shorthand for an array of one content block of type `""text""`. The following input messages are equivalent:

```json
{""role"": ""user"", ""content"": ""Hello, Claude""}
```

```json
{""role"": ""user"", ""content"": [{""type"": ""text"", ""text"": ""Hello, Claude""}]}
```

Starting with Claude 3 models, you can also send image content blocks:

```json
{""role"": ""user"", ""content"": [
  {
    ""type"": ""image"",
    ""source"": {
      ""type"": ""base64"",
      ""media_type"": ""image/jpeg"",
      ""data"": ""/9j/4AAQSkZJRg..."",
    }
  },
  {""type"": ""text"", ""text"": ""What is in this image?""}
]}
```

We currently support the `base64` source type for images, and the `image/jpeg`, `image/png`, `image/gif`, and `image/webp` media types.

See [examples](https://docs.anthropic.com/en/api/messages-examples#vision) for more input examples.

Note that if you want to include a [system prompt](https://docs.anthropic.com/en/docs/system-prompts), you can use the top-level `system` parameter — there is no `""system""` role for input messages in the Messages API.",
        };

        private global::System.CommandLine.Argument<int> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"The maximum number of tokens to generate before stopping.

Note that our models may stop _before_ reaching this maximum. This parameter only specifies the absolute maximum number of tokens to generate.

Different models have different maximum values for this parameter.  See [models](https://docs.anthropic.com/en/docs/models-overview) for details.",
        };

        private global::System.CommandLine.Option<string?> AnthropicBeta { get; } = new(
            name: "anthropicBeta")
        {
            Description = @"Optional header to specify the beta version(s) you want to use.

To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.",
        };

        private global::System.CommandLine.Option<string?> AnthropicVersion { get; } = new(
            name: "anthropicVersion")
        {
            Description = @"The version of the Anthropic API you want to use.

Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).",
        };

        private global::System.CommandLine.Option<global::G.BetaMetadata?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"An object describing metadata about the request.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> StopSequences { get; } = new(
            name: "stopSequences")
        {
            Description = @"Custom text sequences that will cause the model to stop generating.

Our models will normally stop when they have naturally completed their turn, which will result in a response `stop_reason` of `""end_turn""`.

If you want the model to stop generating when it encounters custom strings of text, you can use the `stop_sequences` parameter. If the model encounters one of the custom sequences, the response `stop_reason` value will be `""stop_sequence""` and the response `stop_sequence` value will contain the matched stop sequence.",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"Whether to incrementally stream the response using server-sent events.

See [streaming](https://docs.anthropic.com/en/api/messages-streaming) for details.",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.BetaRequestTextBlock>>?> System { get; } = new(
            name: "system")
        {
            Description = @"System prompt.

A system prompt is a way of providing context and instructions to Claude, such as specifying a particular goal or role. See our [guide to system prompts](https://docs.anthropic.com/en/docs/system-prompts).",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Amount of randomness injected into the response.

Defaults to `1.0`. Ranges from `0.0` to `1.0`. Use `temperature` closer to `0.0` for analytical / multiple choice, and closer to `1.0` for creative and generative tasks.

Note that even with `temperature` of `0.0`, the results will not be fully deterministic.",
        };

        private global::System.CommandLine.Option<global::G.BetaThinkingConfigParam?> Thinking { get; } = new(
            name: "thinking")
        {
            Description = @"Configuration for enabling Claude's extended thinking. 

When enabled, responses include `thinking` content blocks showing Claude's thinking process before the final answer. Requires a minimum budget of 1,024 tokens and counts towards your `max_tokens` limit.

See [extended thinking](https://docs.anthropic.com/en/docs/build-with-claude/extended-thinking) for details.",
        };

        private global::System.CommandLine.Option<global::G.BetaToolChoice?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"How the model should use the provided tools. The model can use a specific tool, any available tool, or decide by itself.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.OneOf<global::G.BetaTool, global::G.BetaComputerUseTool20241022, global::G.BetaBashTool20241022, global::G.BetaTextEditor20241022, global::G.BetaComputerUseTool20250124, global::G.BetaBashTool20250124, global::G.BetaTextEditor20250124>>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"Definitions of tools that the model may use.

If you include `tools` in your API request, the model may return `tool_use` content blocks that represent the model's use of those tools. You can then run those tools using the tool input generated by the model and then optionally return results back to the model using `tool_result` content blocks.

Each tool definition includes:

* `name`: Name of the tool.
* `description`: Optional, but strongly-recommended description of the tool.
* `input_schema`: [JSON schema](https://json-schema.org/draft/2020-12) for the tool `input` shape that the model will produce in `tool_use` output content blocks.

For example, if you defined `tools` as:

```json
[
  {
    ""name"": ""get_stock_price"",
    ""description"": ""Get the current stock price for a given ticker symbol."",
    ""input_schema"": {
      ""type"": ""object"",
      ""properties"": {
        ""ticker"": {
          ""type"": ""string"",
          ""description"": ""The stock ticker symbol, e.g. AAPL for Apple Inc.""
        }
      },
      ""required"": [""ticker""]
    }
  }
]
```

And then asked the model ""What's the S&P 500 at today?"", the model might produce `tool_use` content blocks in the response like this:

```json
[
  {
    ""type"": ""tool_use"",
    ""id"": ""toolu_01D7FLrfh4GYq7yT1ULFeyMV"",
    ""name"": ""get_stock_price"",
    ""input"": { ""ticker"": ""^GSPC"" }
  }
]
```

You might then run your `get_stock_price` tool with `{""ticker"": ""^GSPC""}` as an input, and return the following back to the model in a subsequent `user` message:

```json
[
  {
    ""type"": ""tool_result"",
    ""tool_use_id"": ""toolu_01D7FLrfh4GYq7yT1ULFeyMV"",
    ""content"": ""259.75 USD""
  }
]
```

Tools can be used for workflows that include running client-side tools and functions, or more generally whenever you want the model to produce a particular JSON structure of output.

See our [guide](https://docs.anthropic.com/en/docs/tool-use) for more details.",
        };

        private global::System.CommandLine.Option<int?> TopK { get; } = new(
            name: "topK")
        {
            Description = @"Only sample from the top K options for each subsequent token.

Used to remove ""long tail"" low probability responses. [Learn more technical details here](https://towardsdatascience.com/how-to-sample-from-language-models-682bceb97277).

Recommended for advanced use cases only. You usually only need to use `temperature`.",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"Use nucleus sampling.

In nucleus sampling, we compute the cumulative distribution over all the options for each subsequent token in decreasing probability order and cut it off once it reaches a particular probability specified by `top_p`. You should either alter `temperature` or `top_p`, but not both.

Recommended for advanced use cases only. You usually only need to use `temperature`.",
        };
        public BetaMessagesPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "beta",
            description: @"Send a structured list of input messages with text and/or image content, and the model will generate the next message in the conversation.

The Messages API can be used for either single queries or stateless multi-turn conversations.

Learn more about the Messages API in our [user guide](/en/docs/initial-setup)")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Messages);
            Arguments.Add(MaxTokens);
            Options.Add(AnthropicBeta);
            Options.Add(AnthropicVersion);
            Options.Add(Metadata);
            Options.Add(StopSequences);
            Options.Add(Stream);
            Options.Add(System);
            Options.Add(Temperature);
            Options.Add(Thinking);
            Options.Add(ToolChoice);
            Options.Add(Tools);
            Options.Add(TopK);
            Options.Add(TopP);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var anthropicBeta = parseResult.GetRequiredValue(AnthropicBeta);
            var anthropicVersion = parseResult.GetRequiredValue(AnthropicVersion);
            var model = parseResult.GetRequiredValue(Model);
            var messages = parseResult.GetRequiredValue(Messages);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var stopSequences = parseResult.GetRequiredValue(StopSequences);
            var stream = parseResult.GetRequiredValue(Stream);
            var system = parseResult.GetRequiredValue(System);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var thinking = parseResult.GetRequiredValue(Thinking);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);
            var tools = parseResult.GetRequiredValue(Tools);
            var topK = parseResult.GetRequiredValue(TopK);
            var topP = parseResult.GetRequiredValue(TopP);

            Validate(
                parseResult: parseResult,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                model: model,
                messages: messages,
                maxTokens: maxTokens,
                metadata: metadata,
                stopSequences: stopSequences,
                stream: stream,
                system: system,
                temperature: temperature,
                thinking: thinking,
                toolChoice: toolChoice,
                tools: tools,
                topK: topK,
                topP: topP,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Messages.BetaMessagesPostAsync(
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                model: model,
                messages: messages,
                maxTokens: maxTokens,
                metadata: metadata,
                stopSequences: stopSequences,
                stream: stream,
                system: system,
                temperature: temperature,
                thinking: thinking,
                toolChoice: toolChoice,
                tools: tools,
                topK: topK,
                topP: topP,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}