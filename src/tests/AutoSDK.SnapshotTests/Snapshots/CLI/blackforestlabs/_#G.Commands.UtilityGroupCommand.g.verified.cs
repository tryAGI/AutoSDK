//HintName: G.Commands.UtilityGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UtilityGroupCommand : global::System.CommandLine.Command
    {
        public UtilityGroupCommand(
            UtilityDeleteFinetuneV1DeleteFinetunePostCommand command0,
            UtilityFinetuneDetailsV1FinetuneDetailsGetCommand command1,
            UtilityGetResultV1GetResultGetCommand command2,
            UtilityMyFinetunesV1MyFinetunesGetCommand command3)
            : base(
                name: "utility")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}