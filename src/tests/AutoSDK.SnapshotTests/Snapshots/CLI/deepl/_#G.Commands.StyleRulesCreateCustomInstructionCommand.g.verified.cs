//HintName: G.Commands.StyleRulesCreateCustomInstructionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StyleRulesCreateCustomInstructionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string styleId,
            string label,
            string prompt,
            string? sourceLanguage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CustomInstruction response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> StyleId { get; } = new(
            name: "styleId")
        {
            Description = @"The unique ID of the style rule list",
        };

        private global::System.CommandLine.Argument<string> Label { get; } = new(
            name: "label")
        {
            Description = @"Name associated with the custom instruction",
        };

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"Prompt of the custom instruction",
        };

        private global::System.CommandLine.Option<string?> SourceLanguage { get; } = new(
            name: "sourceLanguage")
        {
            Description = @"Optional source language of the custom instruction",
        };


        public StyleRulesCreateCustomInstructionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StyleId);
            Arguments.Add(Label);
            Arguments.Add(Prompt);
            Options.Add(SourceLanguage);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var styleId = parseResult.GetRequiredValue(StyleId);
            var label = parseResult.GetRequiredValue(Label);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var sourceLanguage = parseResult.GetRequiredValue(SourceLanguage);

            Validate(
                parseResult: parseResult,
                styleId: styleId,
                label: label,
                prompt: prompt,
                sourceLanguage: sourceLanguage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.StyleRules.CreateCustomInstructionAsync(
                styleId: styleId,
                label: label,
                prompt: prompt,
                sourceLanguage: sourceLanguage,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}