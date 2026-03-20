//HintName: G.Commands.CreateVideoApiGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVideoApiGroupCommand : global::System.CommandLine.Command
    {
        public CreateVideoApiGroupCommand(
            CreateVideoApiV1VideoDeleteCommand command0,
            CreateVideoApiV2VideoGenerateCommand command1)
            : base(
                name: "createvideoapi")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}