//HintName: G.Commands.GuardrailsCreateGuardrailsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GuardrailsCreateGuardrailsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.GuardrailWrite> guardrails,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.GuardrailWrite>> Guardrails { get; } = new(
            name: "guardrails")
        {
            Description = @"",
        };



        public GuardrailsCreateGuardrailsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Batch guardrails for traces")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Guardrails);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var guardrails = parseResult.GetRequiredValue(Guardrails);

            Validate(
                parseResult: parseResult,
                guardrails: guardrails,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Guardrails.CreateGuardrailsAsync(
                guardrails: guardrails,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}