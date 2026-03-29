//HintName: G.Commands.OpenTelemetryIngestionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OpenTelemetryIngestionGroupCommand : global::System.CommandLine.Command
    {
        public OpenTelemetryIngestionGroupCommand(
            OpenTelemetryIngestionReceiveProtobufTracesCommand command0)
            : base(
                name: "opentelemetryingestion")
        {
            Subcommands.Add(command0);
        }
    }
}