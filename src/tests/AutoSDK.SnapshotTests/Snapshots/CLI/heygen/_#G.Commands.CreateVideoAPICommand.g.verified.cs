//HintName: G.Commands.CreateVideoAPICommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVideoAPICommand : global::System.CommandLine.Command
    {
        public CreateVideoAPICommand(
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