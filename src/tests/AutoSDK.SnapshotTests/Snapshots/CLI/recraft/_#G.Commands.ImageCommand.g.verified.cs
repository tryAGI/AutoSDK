//HintName: G.Commands.ImageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ImageCommand : global::System.CommandLine.Command
    {
        public ImageCommand(
            ClarityUpscaleCommand command0,
            GenerateImageCommand command1,
            GenerativeUpscaleCommand command2,
            RemoveBackgroundCommand command3,
            VectorizeImageCommand command4)
            : base(
                name: "image")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}