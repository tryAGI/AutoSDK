//HintName: G.Commands.ApiStatuGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ApiStatuGroupCommand : global::System.CommandLine.Command
    {
        public ApiStatuGroupCommand(
            ApiStatusApiStatusGetCommand command0)
            : base(
                name: "apistatu")
        {
            Subcommands.Add(command0);
        }
    }
}