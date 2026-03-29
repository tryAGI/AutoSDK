//HintName: G.Commands.ChatCompletionsCreateChatCompletionsAsStreamCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChatCompletionsCreateChatCompletionsAsStreamCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? model,
            global::System.Collections.Generic.IList<global::G.Message>? messages,
            double? temperature,
            double? topP,
            int? n,
            global::G.StreamOptions? streamOptions,
            global::System.Collections.Generic.IList<string>? stop,
            int? maxTokens,
            int? maxCompletionTokens,
            double? presencePenalty,
            double? frequencyPenalty,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias,
            string? user,
            global::G.ResponseFormat? responseFormat,
            int? seed,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            object? toolChoice,
            bool? parallelToolCalls,
            bool? store,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? reasoningEffort,
            string? serviceTier,
            global::System.Collections.Generic.IList<global::G.Function>? functions,
            global::G.FunctionCall? functionCall,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::System.Collections.Generic.IAsyncEnumerable<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionResponse, global::G.ErrorMessage>>> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Message>?> Messages { get; } = new(
            name: "messages")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.StreamOptions?> StreamOptions { get; } = new(
            name: "streamOptions")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> MaxCompletionTokens { get; } = new(
            name: "maxCompletionTokens")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, int>?> LogitBias { get; } = new(
            name: "logitBias")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> User { get; } = new(
            name: "user")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Tool>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<object?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> ParallelToolCalls { get; } = new(
            name: "parallelToolCalls")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Store { get; } = new(
            name: "store")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ReasoningEffort { get; } = new(
            name: "reasoningEffort")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ServiceTier { get; } = new(
            name: "serviceTier")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Function>?> Functions { get; } = new(
            name: "functions")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.FunctionCall?> FunctionCall { get; } = new(
            name: "functionCall")
        {
            Description = @"",
        };


        public ChatCompletionsCreateChatCompletionsAsStreamCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create chat completions")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Model);
            Options.Add(Messages);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(N);
            Options.Add(StreamOptions);
            Options.Add(Stop);
            Options.Add(MaxTokens);
            Options.Add(MaxCompletionTokens);
            Options.Add(PresencePenalty);
            Options.Add(FrequencyPenalty);
            Options.Add(LogitBias);
            Options.Add(User);
            Options.Add(ResponseFormat);
            Options.Add(Seed);
            Options.Add(Tools);
            Options.Add(ToolChoice);
            Options.Add(ParallelToolCalls);
            Options.Add(Store);
            Options.Add(Metadata);
            Options.Add(ReasoningEffort);
            Options.Add(ServiceTier);
            Options.Add(Functions);
            Options.Add(FunctionCall);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var messages = parseResult.GetRequiredValue(Messages);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var topP = parseResult.GetRequiredValue(TopP);
            var n = parseResult.GetRequiredValue(N);
            var streamOptions = parseResult.GetRequiredValue(StreamOptions);
            var stop = parseResult.GetRequiredValue(Stop);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var maxCompletionTokens = parseResult.GetRequiredValue(MaxCompletionTokens);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var logitBias = parseResult.GetRequiredValue(LogitBias);
            var user = parseResult.GetRequiredValue(User);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var seed = parseResult.GetRequiredValue(Seed);
            var tools = parseResult.GetRequiredValue(Tools);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);
            var parallelToolCalls = parseResult.GetRequiredValue(ParallelToolCalls);
            var store = parseResult.GetRequiredValue(Store);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var reasoningEffort = parseResult.GetRequiredValue(ReasoningEffort);
            var serviceTier = parseResult.GetRequiredValue(ServiceTier);
            var functions = parseResult.GetRequiredValue(Functions);
            var functionCall = parseResult.GetRequiredValue(FunctionCall);

            Validate(
                parseResult: parseResult,
                model: model,
                messages: messages,
                temperature: temperature,
                topP: topP,
                n: n,
                streamOptions: streamOptions,
                stop: stop,
                maxTokens: maxTokens,
                maxCompletionTokens: maxCompletionTokens,
                presencePenalty: presencePenalty,
                frequencyPenalty: frequencyPenalty,
                logitBias: logitBias,
                user: user,
                responseFormat: responseFormat,
                seed: seed,
                tools: tools,
                toolChoice: toolChoice,
                parallelToolCalls: parallelToolCalls,
                store: store,
                metadata: metadata,
                reasoningEffort: reasoningEffort,
                serviceTier: serviceTier,
                functions: functions,
                functionCall: functionCall,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = _client.ChatCompletions.CreateChatCompletionsAsStreamAsync(
                model: model,
                messages: messages,
                temperature: temperature,
                topP: topP,
                n: n,
                streamOptions: streamOptions,
                stop: stop,
                maxTokens: maxTokens,
                maxCompletionTokens: maxCompletionTokens,
                presencePenalty: presencePenalty,
                frequencyPenalty: frequencyPenalty,
                logitBias: logitBias,
                user: user,
                responseFormat: responseFormat,
                seed: seed,
                tools: tools,
                toolChoice: toolChoice,
                parallelToolCalls: parallelToolCalls,
                store: store,
                metadata: metadata,
                reasoningEffort: reasoningEffort,
                serviceTier: serviceTier,
                functions: functions,
                functionCall: functionCall,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}