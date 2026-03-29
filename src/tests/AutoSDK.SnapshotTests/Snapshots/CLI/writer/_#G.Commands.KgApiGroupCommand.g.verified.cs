//HintName: G.Commands.KgApiGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class KgApiGroupCommand : global::System.CommandLine.Command
    {
        public KgApiGroupCommand(
            KgApiAddFileToGraphCommand command0,
            KgApiCreateGraphCommand command1,
            KgApiDeleteGraphCommand command2,
            KgApiFindGraphWithFileStatusCommand command3,
            KgApiFindGraphsWithFileStatusCommand command4,
            KgApiQuestionCommand command5,
            KgApiQuestionAsStreamCommand command6,
            KgApiRemoveFileFromGraphCommand command7,
            KgApiUpdateGraphCommand command8)
            : base(
                name: "kgapi")
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