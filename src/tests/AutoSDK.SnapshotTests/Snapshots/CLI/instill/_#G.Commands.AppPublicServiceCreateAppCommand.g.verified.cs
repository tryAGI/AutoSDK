//HintName: G.Commands.AppPublicServiceCreateAppCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceCreateAppCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string id,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateAppResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"The app's owner(namespaces).",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"The app id.
the app id should be lowercase without any space or special character besides the hyphen,
it can not start with number or hyphen, and should be less than 32 characters.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"The app description.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"The app tags.",
        };
        public AppPublicServiceCreateAppCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "app",
            description: @"Creates an app.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(Id);
            Options.Add(Description);
            Options.Add(Tags);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var id = parseResult.GetRequiredValue(Id);
            var description = parseResult.GetRequiredValue(Description);
            var tags = parseResult.GetRequiredValue(Tags);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                id: id,
                description: description,
                tags: tags,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.App.AppPublicServiceCreateAppAsync(
                namespaceId: namespaceId,
                id: id,
                description: description,
                tags: tags,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}