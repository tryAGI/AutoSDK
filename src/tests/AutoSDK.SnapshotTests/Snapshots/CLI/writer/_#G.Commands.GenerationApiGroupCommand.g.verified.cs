//HintName: G.Commands.GenerationApiGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerationApiGroupCommand : global::System.CommandLine.Command
    {
        public GenerationApiGroupCommand(
            GenerationApiChatCommand command0,
            GenerationApiChatAsStreamCommand command1,
            GenerationApiCompletionsCommand command2,
            GenerationApiCompletionsAsStreamCommand command3,
            GenerationApiGenerateContentCommand command4,
            GenerationApiGenerateContentAsStreamCommand command5,
            GenerationApiGetApplicationsCommand command6,
            GenerationApiGetApplicationsByApplicationIdCommand command7,
            GenerationApiModelsCommand command8)
            : base(
                name: "generationapi")
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