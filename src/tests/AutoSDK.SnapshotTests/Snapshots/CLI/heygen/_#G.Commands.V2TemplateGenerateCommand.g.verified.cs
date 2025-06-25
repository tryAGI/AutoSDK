//HintName: G.Commands.V2TemplateGenerateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class V2TemplateGenerateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            bool? caption,
            global::G.V2TemplateGenerateRequestDimension? dimension,
            bool? test,
            string? title,
            global::G.V2TemplateGenerateRequestVariables? variables,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<bool?> Caption { get; } = new(
            name: "caption")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.V2TemplateGenerateRequestDimension?> Dimension { get; } = new(
            name: "dimension")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Test { get; } = new(
            name: "test")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.V2TemplateGenerateRequestVariables?> Variables { get; } = new(
            name: "variables")
        {
            Description = @"",
        };
        public V2TemplateGenerateCommand(G.IApi client) : base(
            name: "v2template",
            description: @"Generated Video: [https://app.heygen.com/videos/7cba9d29d6db46b88471221fdbc4fb75](https://app.heygen.com/videos/7cba9d29d6db46b88471221fdbc4fb75)

<img src=""https://resource.heygen.ai/video/gifs/7cba9d29d6db46b88471221fdbc4fb75.gif"" alt="""">")
        {
            _client = client;

            Options.Add(Caption);
            Options.Add(Dimension);
            Options.Add(Test);
            Options.Add(Title);
            Options.Add(Variables);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var caption = parseResult.GetRequiredValue(Caption);
            var dimension = parseResult.GetRequiredValue(Dimension);
            var test = parseResult.GetRequiredValue(Test);
            var title = parseResult.GetRequiredValue(Title);
            var variables = parseResult.GetRequiredValue(Variables);

            Validate(
                parseResult: parseResult,
                caption: caption,
                dimension: dimension,
                test: test,
                title: title,
                variables: variables,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.TemplateAPI.V2TemplateGenerateAsync(
                caption: caption,
                dimension: dimension,
                test: test,
                title: title,
                variables: variables,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}