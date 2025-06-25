//HintName: G.Commands.AgentsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            global::G.UltravoxV1CallTemplate? callTemplate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Agent response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1CallTemplate?> CallTemplate { get; } = new(
            name: "callTemplate")
        {
            Description = @"",
        };
        public AgentsCreateCommand(G.IApi client) : base(
            name: "agents",
            description: @"")
        {
            _client = client;

            Arguments.Add(Name);
            Options.Add(CallTemplate);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var callTemplate = parseResult.GetRequiredValue(CallTemplate);

            Validate(
                parseResult: parseResult,
                name: name,
                callTemplate: callTemplate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Agents.AgentsCreateAsync(
                name: name,
                callTemplate: callTemplate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}