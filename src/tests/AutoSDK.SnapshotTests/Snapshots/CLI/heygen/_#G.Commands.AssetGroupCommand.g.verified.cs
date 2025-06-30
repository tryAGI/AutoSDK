//HintName: G.Commands.AssetGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AssetGroupCommand : global::System.CommandLine.Command
    {
        public AssetGroupCommand(
            V1AssetUploadCommand command0)
            : base(
                name: "asset")
        {
            Subcommands.Add(command0);
        }
    }
}