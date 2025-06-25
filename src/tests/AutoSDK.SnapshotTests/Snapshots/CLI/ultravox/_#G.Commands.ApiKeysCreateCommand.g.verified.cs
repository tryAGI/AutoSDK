//HintName: G.Commands.ApiKeysCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ApiKeysCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            global::System.DateTime? expiryDate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.APIKeyCreate response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"A free-form name for the API key. Need not be unique. 50 characters max.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> ExpiryDate { get; } = new(
            name: "expiryDate")
        {
            Description = @"Once API key expires, clients cannot use it anymore.",
        };
        public ApiKeysCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "api",
            description: @"Creates a new API key.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Options.Add(ExpiryDate);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var expiryDate = parseResult.GetRequiredValue(ExpiryDate);

            Validate(
                parseResult: parseResult,
                name: name,
                expiryDate: expiryDate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ApiKeys.ApiKeysCreateAsync(
                name: name,
                expiryDate: expiryDate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}