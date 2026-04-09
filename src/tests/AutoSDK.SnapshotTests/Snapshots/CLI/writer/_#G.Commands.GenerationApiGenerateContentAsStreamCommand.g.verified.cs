//HintName: G.Commands.GenerationApiGenerateContentAsStreamCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerationApiGenerateContentAsStreamCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid applicationId,
            global::System.Collections.Generic.IList<global::G.GenerateApplicationInput> inputs,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::System.Collections.Generic.IAsyncEnumerable<global::G.GenerateApplicationResponseChunk> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ApplicationId { get; } = new(
            name: "applicationId")
        {
            Description = @"The unique identifier of a [no-code agent](/no-code/introduction) in AI Studio.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.GenerateApplicationInput>> Inputs { get; } = new(
            name: "inputs")
        {
            Description = @"",
        };



        public GenerationApiGenerateContentAsStreamCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "generate",
            description: @"Generate content from an existing no-code agent (formerly called no-code applications) with inputs.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ApplicationId);
            Arguments.Add(Inputs);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var applicationId = parseResult.GetRequiredValue(ApplicationId);
            var inputs = parseResult.GetRequiredValue(Inputs);

            Validate(
                parseResult: parseResult,
                applicationId: applicationId,
                inputs: inputs,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = _client.GenerationApi.GenerateContentAsStreamAsync(
                applicationId: applicationId,
                inputs: inputs,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}