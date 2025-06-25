//HintName: G.Commands.SchemaObjectsGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SchemaObjectsGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string className,
            bool? consistency,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Class response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ClassName { get; } = new(
            name: "className")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Consistency { get; } = new(
            name: "consistency")
        {
            Description = "",
        };
        public SchemaObjectsGetCommand(G.IApi client) : base(
            name: "schema",
            description: @"")
        {
            _client = client;

            Arguments.Add(ClassName);
            Options.Add(Consistency);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var className = parseResult.GetRequiredValue(ClassName);
            var consistency = parseResult.GetRequiredValue(Consistency);

            Validate(
                parseResult: parseResult,
                className: className,
                consistency: consistency,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Schema.SchemaObjectsGetAsync(
                className: className,
                consistency: consistency,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}