//HintName: G.Commands.SchemaDumpCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SchemaDumpCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            bool? consistency,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Schema response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<bool?> Consistency { get; } = new(
            name: "consistency")
        {
            Description = "",
        };
        public SchemaDumpCommand(G.IApi client) : base(
            name: "schema",
            description: @"Fetch an array of all collection definitions from the schema.")
        {
            _client = client;

            Options.Add(Consistency);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var consistency = parseResult.GetRequiredValue(Consistency);

            Validate(
                parseResult: parseResult,
                consistency: consistency,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Schema.SchemaDumpAsync(
                consistency: consistency,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}