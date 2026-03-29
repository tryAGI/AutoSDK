//HintName: G.Commands.VisionCreateVisionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VisionCreateVisionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VisionRequestModel model,
            string prompt,
            global::System.Collections.Generic.IList<global::G.VisionRequestFileVariable> variables,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.VisionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"The prompt to use for the image analysis. The prompt must include the name of each image variable, surrounded by double curly braces (`{{}}`). For example, `Describe the difference between the image {{image_1}} and the image {{image_2}}`.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.VisionRequestFileVariable>> Variables { get; } = new(
            name: "variables")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.VisionRequestModel> Model { get; } = new(
            name: "model")
        {
            Description = @"The model to use for image analysis.",
        };


        public VisionCreateVisionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Submit images and documents with a prompt to generate an analysis. Supports JPG, PNG, PDF, and TXT files up to 7MB each.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Prompt);
            Arguments.Add(Variables);
            Options.Add(Model);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var variables = parseResult.GetRequiredValue(Variables);

            Validate(
                parseResult: parseResult,
                model: model,
                prompt: prompt,
                variables: variables,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Vision.CreateVisionAsync(
                model: model,
                prompt: prompt,
                variables: variables,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}