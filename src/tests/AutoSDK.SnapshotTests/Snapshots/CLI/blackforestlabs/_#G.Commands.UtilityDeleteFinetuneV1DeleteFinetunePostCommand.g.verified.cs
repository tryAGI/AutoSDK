//HintName: G.Commands.UtilityDeleteFinetuneV1DeleteFinetunePostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UtilityDeleteFinetuneV1DeleteFinetunePostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string finetuneId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DeleteFinetuneResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FinetuneId { get; } = new(
            name: "finetuneId")
        {
            Description = @"ID of the fine-tuned model you want to delete.",
        };



        public UtilityDeleteFinetuneV1DeleteFinetunePostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete a finetune_id that was created by the user")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(FinetuneId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var finetuneId = parseResult.GetRequiredValue(FinetuneId);

            Validate(
                parseResult: parseResult,
                finetuneId: finetuneId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Utility.DeleteFinetuneV1DeleteFinetunePostAsync(
                finetuneId: finetuneId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}