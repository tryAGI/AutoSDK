//HintName: G.Commands.StyleRulesDeleteCustomInstructionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StyleRulesDeleteCustomInstructionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string styleId,
            string instructionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> StyleId { get; } = new(
            name: "styleId")
        {
            Description = @"The unique ID of the style rule list",
        };

        private global::System.CommandLine.Argument<string> InstructionId { get; } = new(
            name: "instructionId")
        {
            Description = @"The unique ID of the custom instruction",
        };



        public StyleRulesDeleteCustomInstructionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StyleId);
            Arguments.Add(InstructionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var styleId = parseResult.GetRequiredValue(StyleId);
            var instructionId = parseResult.GetRequiredValue(InstructionId);

            Validate(
                parseResult: parseResult,
                styleId: styleId,
                instructionId: instructionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.StyleRules.DeleteCustomInstructionAsync(
                styleId: styleId,
                instructionId: instructionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}