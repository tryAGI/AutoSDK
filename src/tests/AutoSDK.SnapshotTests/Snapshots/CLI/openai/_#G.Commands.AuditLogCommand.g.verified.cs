//HintName: G.Commands.AuditLogCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AuditLogCommand : global::System.CommandLine.Command
    {
        public AuditLogCommand(
            ListAuditLogsCommand command0)
            : base(
                name: "auditlog")
        {
            Subcommands.Add(command0);
        }
    }
}