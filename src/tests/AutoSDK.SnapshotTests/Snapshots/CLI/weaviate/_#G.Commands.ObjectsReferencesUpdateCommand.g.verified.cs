//HintName: G.Commands.ObjectsReferencesUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ObjectsReferencesUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string propertyName,
            string? tenant,
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
        public ObjectsReferencesUpdateCommand(G.IApi client) : base(
            name: "objects",
            description: @"Replace all references in cross-reference property of an object.")
        {
            _client = client;

            Arguments.Add(Id);
            Arguments.Add(PropertyName);
            Options.Add(Tenant);

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

            Validate(
                parseResult: parseResult,
                id: id,
                propertyName: propertyName,
                tenant: tenant,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Objects.ObjectsReferencesUpdateAsync(
                id: id,
                propertyName: propertyName,
                tenant: tenant,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}