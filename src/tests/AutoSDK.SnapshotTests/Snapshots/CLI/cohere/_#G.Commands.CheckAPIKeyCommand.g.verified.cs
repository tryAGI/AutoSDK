//HintName: G.Commands.CheckAPIKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CheckAPIKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CheckAPIKeyResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };
        public CheckAPIKeyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "check",
            description: @"Checks that the api key in the Authorization header is valid and active")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(XClientName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CheckAPIKeyAsync(
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}