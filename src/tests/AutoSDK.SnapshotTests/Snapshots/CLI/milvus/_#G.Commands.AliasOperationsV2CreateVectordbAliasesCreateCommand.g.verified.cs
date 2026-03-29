//HintName: G.Commands.AliasOperationsV2CreateVectordbAliasesCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AliasOperationsV2CreateVectordbAliasesCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? requestTimeout,
            string? authorization,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> RequestTimeout { get; } = new(
            name: "requestTimeout")
        {
            Description = @"The timeout duration for this operation in seconds. Setting this to None indicates that this operation timeouts when any response arrives or any error occurs.",
        };

        private global::System.CommandLine.Option<string?> Authorization { get; } = new(
            name: "authorization")
        {
            Description = @"The authentication token.",
        };


        public AliasOperationsV2CreateVectordbAliasesCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation creates an alias for an existing collection.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(RequestTimeout);
            Options.Add(Authorization);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var requestTimeout = parseResult.GetRequiredValue(RequestTimeout);
            var authorization = parseResult.GetRequiredValue(Authorization);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AliasOperationsV2.CreateVectordbAliasesCreateAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}