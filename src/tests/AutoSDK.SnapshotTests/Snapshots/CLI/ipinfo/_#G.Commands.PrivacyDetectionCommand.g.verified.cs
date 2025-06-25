//HintName: G.Commands.PrivacyDetectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PrivacyDetectionCommand : global::System.CommandLine.Command
    {
        public PrivacyDetectionCommand(
            GetPrivacyInformationByIpCommand command0)
            : base(
                name: "privacydetection")
        {
            Subcommands.Add(command0);
        }
    }
}