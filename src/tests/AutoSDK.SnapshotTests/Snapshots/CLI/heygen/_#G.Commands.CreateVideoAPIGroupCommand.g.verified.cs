//HintName: G.Commands.CreateVideoApiGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVideoApiGroupCommand : global::System.CommandLine.Command
    {
        public CreateVideoApiGroupCommand(
            V2VideoGenerateCommand command0,
            V1VideoDeleteCommand command1)
            : base(
                name: "createvideoapi")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}