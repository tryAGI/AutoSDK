//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            TextToSpeechCommand command0,
            SpeechToSpeechCommand command1,
            SpeechToTextCommand command2,
            ForcedAlignmentCommand command3,
            ModelCommand command4,
            VoiceCommand command5,
            SampleCommand command6,
            SpeechHistoryCommand command7,
            StudioCommand command8,
            SoundGenerationCommand command9,
            AudioIsolationCommand command10,
            TextToDialogueCommand command11,
            VoiceGenerationCommand command12,
            TextToVoiceCommand command13,
            UserCommand command14,
            ProjectCommand command15,
            DubbingCommand command16,
            ResourceCommand command17,
            SegmentCommand command18,
            EnterpriseCommand command19,
            AudioNativeCommand command20,
            UsageCommand command21,
            PronunciationDictionaryCommand command22,
            WorkspaceCommand command23,
            ConversationalAICommand command24,
            PvcVoiceCommand command25)
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
            Subcommands.Add(command23);
            Subcommands.Add(command24);
            Subcommands.Add(command25);
        }
    }
}