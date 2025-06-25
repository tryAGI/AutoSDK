//HintName: G.Commands.GetObjectUploadURLCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetObjectUploadURLCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string objectName,
            int? urlExpireDays,
            global::System.DateTime? lastModifiedTime,
            int? objectExpireDays,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetObjectUploadURLResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> ObjectName { get; } = new(
            name: "objectName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> UrlExpireDays { get; } = new(
            name: "urlExpireDays")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> LastModifiedTime { get; } = new(
            name: "lastModifiedTime")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> ObjectExpireDays { get; } = new(
            name: "objectExpireDays")
        {
            Description = @"",
        };
        public GetObjectUploadURLCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns the upload URL of an object.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(ObjectName);
            Options.Add(UrlExpireDays);
            Options.Add(LastModifiedTime);
            Options.Add(ObjectExpireDays);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var objectName = parseResult.GetRequiredValue(ObjectName);
            var urlExpireDays = parseResult.GetRequiredValue(UrlExpireDays);
            var lastModifiedTime = parseResult.GetRequiredValue(LastModifiedTime);
            var objectExpireDays = parseResult.GetRequiredValue(ObjectExpireDays);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                objectName: objectName,
                urlExpireDays: urlExpireDays,
                lastModifiedTime: lastModifiedTime,
                objectExpireDays: objectExpireDays,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.GetObjectUploadURLAsync(
                namespaceId: namespaceId,
                objectName: objectName,
                urlExpireDays: urlExpireDays,
                lastModifiedTime: lastModifiedTime,
                objectExpireDays: objectExpireDays,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}