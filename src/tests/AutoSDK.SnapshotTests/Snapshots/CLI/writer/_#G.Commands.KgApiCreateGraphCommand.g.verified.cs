//HintName: G.Commands.KgApiCreateGraphCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class KgApiCreateGraphCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? name,
            string? description,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GraphResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"The name of the Knowledge Graph (max 255 characters). Omitting this field leaves the name unchanged.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"A description of the Knowledge Graph (max 255 characters). Omitting this field leaves the description unchanged.",
        };


        public KgApiCreateGraphCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a new Knowledge Graph.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Name);
            Options.Add(Description);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);

            Validate(
                parseResult: parseResult,
                name: name,
                description: description,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.KgApi.CreateGraphAsync(
                name: name,
                description: description,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}