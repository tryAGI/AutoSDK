//HintName: G.Commands.AssetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AssetCommand : global::System.CommandLine.Command
    {
        public AssetCommand(
            V1AssetUploadCommand command0)
            : base(
                name: "asset")
        {
            Subcommands.Add(command0);
        }
    }
}