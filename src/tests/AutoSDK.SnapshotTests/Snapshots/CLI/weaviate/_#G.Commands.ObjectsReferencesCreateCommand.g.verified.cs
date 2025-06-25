//HintName: G.Commands.ObjectsReferencesCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ObjectsReferencesCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string propertyName,
            string? tenant,
            string? @class,
            object? schema,
            string? beacon,
            string? href,
            global::G.ReferenceMetaClassification? classification,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> PropertyName { get; } = new(
            name: "propertyName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Tenant { get; } = new(
            name: "tenant")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Class { get; } = new(
            name: "@class")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> Schema { get; } = new(
            name: "schema")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Beacon { get; } = new(
            name: "beacon")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Href { get; } = new(
            name: "href")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReferenceMetaClassification?> Classification { get; } = new(
            name: "classification")
        {
            Description = "",
        };
        public ObjectsReferencesCreateCommand(G.IApi client) : base(
            name: "objects",
            description: @"Add a cross-reference.")
        {
            _client = client;

            Arguments.Add(Id);
            Arguments.Add(PropertyName);
            Options.Add(Tenant);
            Options.Add(Class);
            Options.Add(Schema);
            Options.Add(Beacon);
            Options.Add(Href);
            Options.Add(Classification);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var propertyName = parseResult.GetRequiredValue(PropertyName);
            var tenant = parseResult.GetRequiredValue(Tenant);
            var @class = parseResult.GetRequiredValue(Class);
            var schema = parseResult.GetRequiredValue(Schema);
            var beacon = parseResult.GetRequiredValue(Beacon);
            var href = parseResult.GetRequiredValue(Href);
            var classification = parseResult.GetRequiredValue(Classification);

            Validate(
                parseResult: parseResult,
                id: id,
                propertyName: propertyName,
                tenant: tenant,
                @class: @class,
                schema: schema,
                beacon: beacon,
                href: href,
                classification: classification,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Objects.ObjectsReferencesCreateAsync(
                id: id,
                propertyName: propertyName,
                tenant: tenant,
                @class: @class,
                schema: schema,
                beacon: beacon,
                href: href,
                classification: classification,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}