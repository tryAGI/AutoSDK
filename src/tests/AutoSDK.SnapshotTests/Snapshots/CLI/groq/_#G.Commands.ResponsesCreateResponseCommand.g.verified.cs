//HintName: G.Commands.ResponsesCreateResponseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ResponsesCreateResponseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::G.CreateResponseRequestModel?> model,
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ResponseInputItem>> input,
            string? instructions,
            int? maxOutputTokens,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<global::G.ResponseTool>? tools,
            global::G.ResponseToolChoiceOption? toolChoice,
            global::G.CreateResponseRequestText? text,
            global::G.CreateResponseRequestReasoning? reasoning,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            bool? parallelToolCalls,
            bool? store,
            bool? stream,
            string? user,
            global::G.CreateResponseRequestServiceTier? serviceTier,
            global::G.CreateResponseRequestTruncation? truncation,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateResponseResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.CreateResponseRequestModel?>> Model { get; } = new(
            name: "model")
        {
            Description = @"ID of the model to use. For details on which models are compatible with the Responses API, see available [models](https://console.groq.com/docs/models)",
        };

        private global::System.CommandLine.Argument<global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ResponseInputItem>>> Input { get; } = new(
            name: "input")
        {
            Description = @"Text input to the model, used to generate a response.",
        };

        private global::System.CommandLine.Option<string?> Instructions { get; } = new(
            name: "instructions")
        {
            Description = @"Inserts a system (or developer) message as the first item in the model's context.",
        };

        private global::System.CommandLine.Option<int?> MaxOutputTokens { get; } = new(
            name: "maxOutputTokens")
        {
            Description = @"An upper bound for the number of tokens that can be generated for a response, including visible output tokens and reasoning tokens.",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Controls randomness in the response generation. Range: 0 to 2. Lower values produce more deterministic outputs, higher values increase variety and creativity.",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"Nucleus sampling parameter that controls the cumulative probability cutoff. Range: 0 to 1. A value of 0.1 restricts sampling to tokens within the top 10% probability mass.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ResponseTool>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"List of tools available to the model. Currently supports function definitions only. Maximum of 128 functions.",
        };

        private global::System.CommandLine.Option<global::G.ResponseToolChoiceOption?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"Controls which (if any) tool is called by the model.
`none` means the model will not call any tool and instead generates a message.
`auto` means the model can pick between generating a message or calling one or more tools.
`required` means the model must call one or more tools.
Specifying a particular tool via `{""type"": ""function"", ""function"": {""name"": ""my_function""}}` forces the model to call that tool.

`none` is the default when no tools are present. `auto` is the default if tools are present.",
        };

        private global::System.CommandLine.Option<global::G.CreateResponseRequestText?> Text { get; } = new(
            name: "text")
        {
            Description = @"Response format configuration. Supports plain text or structured JSON output.",
        };

        private global::System.CommandLine.Option<global::G.CreateResponseRequestReasoning?> Reasoning { get; } = new(
            name: "reasoning")
        {
            Description = @"Configuration for reasoning capabilities when using [models that support reasoning](https://console.groq.com/docs/reasoning).",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Custom key-value pairs for storing additional information. Maximum of 16 pairs.",
        };

        private global::System.CommandLine.Option<bool?> ParallelToolCalls { get; } = new(
            name: "parallelToolCalls")
        {
            Description = @"Enable parallel execution of multiple tool calls.",
        };

        private global::System.CommandLine.Option<bool?> Store { get; } = new(
            name: "store")
        {
            Description = @"Response storage flag. Note: Currently only supports false or null values.",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"Enable streaming mode to receive response data as server-sent events.",
        };

        private global::System.CommandLine.Option<string?> User { get; } = new(
            name: "user")
        {
            Description = @"Optional identifier for tracking end-user requests. Useful for usage monitoring and compliance.",
        };

        private global::System.CommandLine.Option<global::G.CreateResponseRequestServiceTier?> ServiceTier { get; } = new(
            name: "serviceTier")
        {
            Description = @"Specifies the latency tier to use for processing the request.",
        };

        private global::System.CommandLine.Option<global::G.CreateResponseRequestTruncation?> Truncation { get; } = new(
            name: "truncation")
        {
            Description = @"Context truncation strategy. Supported values: `auto` or `disabled`.",
        };


        public ResponsesCreateResponseCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Input);
            Options.Add(Instructions);
            Options.Add(MaxOutputTokens);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(Tools);
            Options.Add(ToolChoice);
            Options.Add(Text);
            Options.Add(Reasoning);
            Options.Add(Metadata);
            Options.Add(ParallelToolCalls);
            Options.Add(Store);
            Options.Add(Stream);
            Options.Add(User);
            Options.Add(ServiceTier);
            Options.Add(Truncation);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var input = parseResult.GetRequiredValue(Input);
            var instructions = parseResult.GetRequiredValue(Instructions);
            var maxOutputTokens = parseResult.GetRequiredValue(MaxOutputTokens);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var topP = parseResult.GetRequiredValue(TopP);
            var tools = parseResult.GetRequiredValue(Tools);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);
            var text = parseResult.GetRequiredValue(Text);
            var reasoning = parseResult.GetRequiredValue(Reasoning);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var parallelToolCalls = parseResult.GetRequiredValue(ParallelToolCalls);
            var store = parseResult.GetRequiredValue(Store);
            var stream = parseResult.GetRequiredValue(Stream);
            var user = parseResult.GetRequiredValue(User);
            var serviceTier = parseResult.GetRequiredValue(ServiceTier);
            var truncation = parseResult.GetRequiredValue(Truncation);

            Validate(
                parseResult: parseResult,
                model: model,
                input: input,
                instructions: instructions,
                maxOutputTokens: maxOutputTokens,
                temperature: temperature,
                topP: topP,
                tools: tools,
                toolChoice: toolChoice,
                text: text,
                reasoning: reasoning,
                metadata: metadata,
                parallelToolCalls: parallelToolCalls,
                store: store,
                stream: stream,
                user: user,
                serviceTier: serviceTier,
                truncation: truncation,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Responses.CreateResponseAsync(
                model: model,
                input: input,
                instructions: instructions,
                maxOutputTokens: maxOutputTokens,
                temperature: temperature,
                topP: topP,
                tools: tools,
                toolChoice: toolChoice,
                text: text,
                reasoning: reasoning,
                metadata: metadata,
                parallelToolCalls: parallelToolCalls,
                store: store,
                stream: stream,
                user: user,
                serviceTier: serviceTier,
                truncation: truncation,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}