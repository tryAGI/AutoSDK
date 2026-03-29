//HintName: G.Commands.RoleOperationsV2CreateVectordbRolesListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RoleOperationsV2CreateVectordbRolesListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? requestTimeout,
            string authorization,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Authorization { get; } = new(
            name: "authorization")
        {
            Description = @"The authentication token.",
        };

        private global::System.CommandLine.Option<int?> RequestTimeout { get; } = new(
            name: "requestTimeout")
        {
            Description = @"The timeout duration for this operation.
Setting this to None indicates that this operation timeouts when any response arrives or any error occurs.",
        };


        public RoleOperationsV2CreateVectordbRolesListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation lists the information about all existing roles.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Authorization);
            Options.Add(RequestTimeout);

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
            await _client.RoleOperationsV2.CreateVectordbRolesListAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}