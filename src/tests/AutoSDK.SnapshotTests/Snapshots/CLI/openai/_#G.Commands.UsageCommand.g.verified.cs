//HintName: G.Commands.UsageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsageCommand : global::System.CommandLine.Command
    {
        public UsageCommand(
            UsageCostsCommand command0,
            UsageAudioSpeechesCommand command1,
            UsageAudioTranscriptionsCommand command2,
            UsageCodeInterpreterSessionsCommand command3,
            UsageCompletionsCommand command4,
            UsageEmbeddingsCommand command5,
            UsageImagesCommand command6,
            UsageModerationsCommand command7,
            UsageVectorStoresCommand command8)
            : base(
                name: "usage")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
        }
    }
}