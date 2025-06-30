//HintName: G.Commands.CreateVideoAPIGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVideoAPIGroupCommand : global::System.CommandLine.Command
    {
        public CreateVideoAPIGroupCommand(
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