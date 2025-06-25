//HintName: G.Commands.ClassificationsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClassificationsPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? id,
            string? @class,
            global::System.Collections.Generic.IList<string>? classifyProperties,
            global::System.Collections.Generic.IList<string>? basedOnProperties,
            global::G.ClassificationStatus? status,
            global::G.ClassificationMeta? meta,
            string? type,
            object? settings,
            string? error,
            global::G.ClassificationFilters? filters,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Classification response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Guid?> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Class { get; } = new(
            name: "@class")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ClassifyProperties { get; } = new(
            name: "classifyProperties")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> BasedOnProperties { get; } = new(
            name: "basedOnProperties")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ClassificationStatus?> Status { get; } = new(
            name: "status")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ClassificationMeta?> Meta { get; } = new(
            name: "meta")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Type { get; } = new(
            name: "type")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> Settings { get; } = new(
            name: "settings")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Error { get; } = new(
            name: "error")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ClassificationFilters?> Filters { get; } = new(
            name: "filters")
        {
            Description = "",
        };
        public ClassificationsPostCommand(G.IApi client) : base(
            name: "classifications",
            description: @"Trigger a classification based on the specified params. Classifications will run in the background, use GET /classifications/<id> to retrieve the status of your classification.")
        {
            _client = client;

            Options.Add(Id);
            Options.Add(Class);
            Options.Add(ClassifyProperties);
            Options.Add(BasedOnProperties);
            Options.Add(Status);
            Options.Add(Meta);
            Options.Add(Type);
            Options.Add(Settings);
            Options.Add(Error);
            Options.Add(Filters);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var @class = parseResult.GetRequiredValue(Class);
            var classifyProperties = parseResult.GetRequiredValue(ClassifyProperties);
            var basedOnProperties = parseResult.GetRequiredValue(BasedOnProperties);
            var status = parseResult.GetRequiredValue(Status);
            var meta = parseResult.GetRequiredValue(Meta);
            var type = parseResult.GetRequiredValue(Type);
            var settings = parseResult.GetRequiredValue(Settings);
            var error = parseResult.GetRequiredValue(Error);
            var filters = parseResult.GetRequiredValue(Filters);

            Validate(
                parseResult: parseResult,
                id: id,
                @class: @class,
                classifyProperties: classifyProperties,
                basedOnProperties: basedOnProperties,
                status: status,
                meta: meta,
                type: type,
                settings: settings,
                error: error,
                filters: filters,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Classifications.ClassificationsPostAsync(
                id: id,
                @class: @class,
                classifyProperties: classifyProperties,
                basedOnProperties: basedOnProperties,
                status: status,
                meta: meta,
                type: type,
                settings: settings,
                error: error,
                filters: filters,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}