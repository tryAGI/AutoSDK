//HintName: G.Commands.AgentConfigsGetDeltaByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentConfigsGetDeltaByIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid blueprintId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AgentBlueprintPublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> BlueprintId { get; } = new(
            name: "blueprintId")
        {
            Description = @"",
        };



        public AgentConfigsGetDeltaByIdCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieves only the changes (delta) introduced in a specific blueprint")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BlueprintId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var blueprintId = parseResult.GetRequiredValue(BlueprintId);

            Validate(
                parseResult: parseResult,
                blueprintId: blueprintId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AgentConfigs.GetDeltaByIdAsync(
                blueprintId: blueprintId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}