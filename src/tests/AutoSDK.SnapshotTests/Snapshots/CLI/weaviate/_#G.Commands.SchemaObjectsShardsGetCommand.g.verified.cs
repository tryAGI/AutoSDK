//HintName: G.Commands.SchemaObjectsShardsGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SchemaObjectsShardsGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string className,
            string? tenant,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.ShardStatusGetResponse> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ClassName { get; } = new(
            name: "className")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Tenant { get; } = new(
            name: "tenant")
        {
            Description = "",
        };
        public SchemaObjectsShardsGetCommand(G.IApi client) : base(
            name: "schema",
            description: @"Get the status of every shard in the cluster.")
        {
            _client = client;

            Arguments.Add(ClassName);
            Options.Add(Tenant);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var className = parseResult.GetRequiredValue(ClassName);
            var tenant = parseResult.GetRequiredValue(Tenant);

            Validate(
                parseResult: parseResult,
                className: className,
                tenant: tenant,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Schema.SchemaObjectsShardsGetAsync(
                className: className,
                tenant: tenant,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}