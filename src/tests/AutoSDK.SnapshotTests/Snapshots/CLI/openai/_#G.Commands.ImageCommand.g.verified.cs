//HintName: G.Commands.ImageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ImageCommand : global::System.CommandLine.Command
    {
        public ImageCommand(
            CreateImageEditCommand command0,
            CreateImageCommand command1,
            CreateImageVariationCommand command2)
            : base(
                name: "image")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}