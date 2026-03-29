//HintName: G.Commands.AgentConfigsGetBlueprintByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentConfigsGetBlueprintByIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid blueprintId,
            global::System.Guid? maskId,
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

        private global::System.CommandLine.Option<global::System.Guid?> MaskId { get; } = new(
            name: "maskId")
        {
            Description = @"",
        };


        public AgentConfigsGetBlueprintByIdCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieves a specific blueprint by its ID")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BlueprintId);
            Options.Add(MaskId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var blueprintId = parseResult.GetRequiredValue(BlueprintId);
            var maskId = parseResult.GetRequiredValue(MaskId);

            Validate(
                parseResult: parseResult,
                blueprintId: blueprintId,
                maskId: maskId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AgentConfigs.GetBlueprintByIdAsync(
                blueprintId: blueprintId,
                maskId: maskId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}