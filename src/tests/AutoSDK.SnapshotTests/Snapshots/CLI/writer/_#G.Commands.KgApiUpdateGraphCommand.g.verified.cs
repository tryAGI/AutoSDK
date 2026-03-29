//HintName: G.Commands.KgApiUpdateGraphCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class KgApiUpdateGraphCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid graphId,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::G.UpdateGraphWebUrl>? urls,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GraphResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> GraphId { get; } = new(
            name: "graphId")
        {
            Description = @"The unique identifier of the Knowledge Graph.",
        };

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

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UpdateGraphWebUrl>?> Urls { get; } = new(
            name: "urls")
        {
            Description = @"An array of web connector URLs to update for this Knowledge Graph. You can only connect URLs to Knowledge Graphs with the type `web`. To clear the list of URLs, set this field to an empty array.",
        };


        public KgApiUpdateGraphCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update the name and description of a Knowledge Graph.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(GraphId);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(Urls);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var graphId = parseResult.GetRequiredValue(GraphId);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var urls = parseResult.GetRequiredValue(Urls);

            Validate(
                parseResult: parseResult,
                graphId: graphId,
                name: name,
                description: description,
                urls: urls,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.KgApi.UpdateGraphAsync(
                graphId: graphId,
                name: name,
                description: description,
                urls: urls,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}