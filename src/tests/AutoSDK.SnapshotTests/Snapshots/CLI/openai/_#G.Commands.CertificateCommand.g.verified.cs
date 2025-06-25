//HintName: G.Commands.CertificateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CertificateCommand : global::System.CommandLine.Command
    {
        public CertificateCommand(
            ListOrganizationCertificatesCommand command0,
            UploadCertificateCommand command1,
            ActivateOrganizationCertificatesCommand command2,
            DeactivateOrganizationCertificatesCommand command3,
            GetCertificateCommand command4,
            ModifyCertificateCommand command5,
            DeleteCertificateCommand command6,
            ListProjectCertificatesCommand command7,
            ActivateProjectCertificatesCommand command8,
            DeactivateProjectCertificatesCommand command9)
            : base(
                name: "certificate")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
        }
    }
}