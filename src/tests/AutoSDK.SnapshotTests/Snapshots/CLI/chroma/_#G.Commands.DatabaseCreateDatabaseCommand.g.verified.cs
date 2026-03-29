//HintName: G.Commands.DatabaseCreateDatabaseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatabaseCreateDatabaseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tenant,
            string name,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateDatabaseResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Tenant { get; } = new(
            name: "tenant")
        {
            Description = @"Tenant UUID",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };



        public DatabaseCreateDatabaseCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates a new database for a tenant.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Tenant);
            Arguments.Add(Name);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var tenant = parseResult.GetRequiredValue(Tenant);
            var name = parseResult.GetRequiredValue(Name);

            Validate(
                parseResult: parseResult,
                tenant: tenant,
                name: name,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Database.CreateDatabaseAsync(
                tenant: tenant,
                name: name,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}