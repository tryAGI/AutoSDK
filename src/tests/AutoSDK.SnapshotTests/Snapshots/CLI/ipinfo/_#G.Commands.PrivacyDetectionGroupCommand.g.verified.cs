//HintName: G.Commands.PrivacyDetectionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PrivacyDetectionGroupCommand : global::System.CommandLine.Command
    {
        public PrivacyDetectionGroupCommand(
            GetPrivacyInformationByIpCommand command0)
            : base(
                name: "privacydetection")
        {
            Subcommands.Add(command0);
        }
    }
}