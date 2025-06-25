//HintName: G.Commands.TenantsDeleteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TenantsDeleteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string className,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ClassName { get; } = new(
            name: "className")
        {
            Description = "",
        };

        public TenantsDeleteCommand(G.IApi client) : base(
            name: "tenants",
            description: @"Delete tenants from a collection")
        {
            _client = client;

            Arguments.Add(ClassName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var className = parseResult.GetRequiredValue(ClassName);

            Validate(
                parseResult: parseResult,
                className: className,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Schema.TenantsDeleteAsync(
                className: className,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}