//HintName: G.Commands.CodesOfConductCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodesOfConductCommand : global::System.CommandLine.Command
    {
        public CodesOfConductCommand(
            CodesOfConductGetAllCodesOfConductCommand command0,
            CodesOfConductGetConductCodeCommand command1)
            : base(
                name: "codesofconduct")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}