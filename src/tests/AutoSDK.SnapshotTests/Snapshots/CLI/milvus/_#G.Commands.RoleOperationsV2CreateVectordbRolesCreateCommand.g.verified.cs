//HintName: G.Commands.RoleOperationsV2CreateVectordbRolesCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RoleOperationsV2CreateVectordbRolesCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? requestTimeout,
            string? authorization,
            string roleName1,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> RoleName1 { get; } = new(
            name: "roleName1")
        {
            Description = @"The name of the role.",
        };

        private global::System.CommandLine.Option<int?> RequestTimeout { get; } = new(
            name: "requestTimeout")
        {
            Description = @"The timeout duration for this operation.
Setting this to None indicates that this operation timeouts when any response arrives or any error occurs.",
        };

        private global::System.CommandLine.Option<string?> Authorization { get; } = new(
            name: "authorization")
        {
            Description = @"Then authentication token.",
        };


        public RoleOperationsV2CreateVectordbRolesCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation creates the current role.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(RoleName1);
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
            var roleName1 = parseResult.GetRequiredValue(RoleName1);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                roleName1: roleName1,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.RoleOperationsV2.CreateVectordbRolesCreateAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                roleName1: roleName1,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}