//HintName: G.Commands.PipelinePublicServiceDeleteNamespaceSecretCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceDeleteNamespaceSecretCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string secretId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> SecretId { get; } = new(
            name: "secretId")
        {
            Description = @"",
        };

        public PipelinePublicServiceDeleteNamespaceSecretCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Deletes a secret, accesing it by its resource name, which is defined by
the parent namespace and the ID of the secret.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(SecretId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var secretId = parseResult.GetRequiredValue(SecretId);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                secretId: secretId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceDeleteNamespaceSecretAsync(
                namespaceId: namespaceId,
                secretId: secretId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}