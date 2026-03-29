//HintName: G.Commands.LlmProviderKeyStoreLlmProviderApiKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LlmProviderKeyStoreLlmProviderApiKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProviderApiKeyWriteProvider provider,
            string? apiKey,
            string? name,
            string? providerName,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, string>? configuration,
            string? baseUrl,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.ProviderApiKeyWriteProvider> Provider { get; } = new(
            name: "provider")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ApiKey { get; } = new(
            name: "apiKey")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProviderName { get; } = new(
            name: "providerName")
        {
            Description = @"Provider name - required for custom LLM and Bedrock providers to uniquely identify them (e.g., 'ollama', 'vllm', 'Bedrock us-east-1'). Must not be blank for custom and Bedrock providers. Should not be set for standard providers (OpenAI, Anthropic, etc.). This requirement is conditional and validation is enforced programmatically.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Headers { get; } = new(
            name: "headers")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Configuration { get; } = new(
            name: "configuration")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> BaseUrl { get; } = new(
            name: "baseUrl")
        {
            Description = @"",
        };


        public LlmProviderKeyStoreLlmProviderApiKeyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "store",
            description: @"Store LLM Provider's ApiKey")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Provider);
            Options.Add(ApiKey);
            Options.Add(Name);
            Options.Add(ProviderName);
            Options.Add(Headers);
            Options.Add(Configuration);
            Options.Add(BaseUrl);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var provider = parseResult.GetRequiredValue(Provider);
            var apiKey = parseResult.GetRequiredValue(ApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var providerName = parseResult.GetRequiredValue(ProviderName);
            var headers = parseResult.GetRequiredValue(Headers);
            var configuration = parseResult.GetRequiredValue(Configuration);
            var baseUrl = parseResult.GetRequiredValue(BaseUrl);

            Validate(
                parseResult: parseResult,
                provider: provider,
                apiKey: apiKey,
                name: name,
                providerName: providerName,
                headers: headers,
                configuration: configuration,
                baseUrl: baseUrl,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.LlmProviderKey.StoreLlmProviderApiKeyAsync(
                provider: provider,
                apiKey: apiKey,
                name: name,
                providerName: providerName,
                headers: headers,
                configuration: configuration,
                baseUrl: baseUrl,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}