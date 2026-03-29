//HintName: G.Commands.LlmProviderKeyUpdateLlmProviderApiKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LlmProviderKeyUpdateLlmProviderApiKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
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

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
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
            Description = @"Provider name - can be set to migrate legacy custom LLM or Bedrock providers to the new multi-provider format. Once set, it cannot be changed. Should only be set for custom LLM and Bedrock providers.",
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


        public LlmProviderKeyUpdateLlmProviderApiKeyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update LLM Provider's ApiKey")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
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
            var id = parseResult.GetRequiredValue(Id);
            var apiKey = parseResult.GetRequiredValue(ApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var providerName = parseResult.GetRequiredValue(ProviderName);
            var headers = parseResult.GetRequiredValue(Headers);
            var configuration = parseResult.GetRequiredValue(Configuration);
            var baseUrl = parseResult.GetRequiredValue(BaseUrl);

            Validate(
                parseResult: parseResult,
                id: id,
                apiKey: apiKey,
                name: name,
                providerName: providerName,
                headers: headers,
                configuration: configuration,
                baseUrl: baseUrl,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.LlmProviderKey.UpdateLlmProviderApiKeyAsync(
                id: id,
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