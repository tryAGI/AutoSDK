//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AssistantCommand command0,
            AudioCommand command1,
            ChatCommand command2,
            CompletionCommand command3,
            EmbeddingCommand command4,
            EvalCommand command5,
            FineTuningCommand command6,
            GraderCommand command7,
            BatchCommand command8,
            FileCommand command9,
            UploadCommand command10,
            ImageCommand command11,
            ModelCommand command12,
            ModerationCommand command13,
            AuditLogCommand command14,
            CertificateCommand command15,
            UsageCommand command16,
            InviteCommand command17,
            ProjectCommand command18,
            UserCommand command19,
            RealtimeCommand command20,
            ResponseCommand command21,
            VectorStoreCommand command22)
            : base(
                description: "CLI tool")
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
            Subcommands.Add(command9);
            Subcommands.Add(command10);
            Subcommands.Add(command11);
            Subcommands.Add(command12);
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
            Subcommands.Add(command16);
            Subcommands.Add(command17);
            Subcommands.Add(command18);
            Subcommands.Add(command19);
            Subcommands.Add(command20);
            Subcommands.Add(command21);
            Subcommands.Add(command22);
        }
    }
}