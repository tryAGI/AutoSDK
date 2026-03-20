//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            CancelPredictionsCommand command0,
            CancelTrainingsCommand command1,
            CreateDeploymentsCommand command2,
            CreateModelsCommand command3,
            CreatePredictionsCommand command4,
            CreatePredictionsDeploymentsCommand command5,
            CreatePredictionsModelsCommand command6,
            CreateTrainingsCommand command7,
            DeleteDeploymentsCommand command8,
            DeleteModelsCommand command9,
            DeleteVersionsModelsCommand command10,
            GetAccountCommand command11,
            GetCollectionsCommand command12,
            GetDeploymentsCommand command13,
            GetModelsCommand command14,
            GetPredictionsCommand command15,
            GetSecretDefaultWebhooksCommand command16,
            GetTrainingsCommand command17,
            GetVersionsModelsCommand command18,
            ListCollectionsCommand command19,
            ListDeploymentsCommand command20,
            ListHardwareCommand command21,
            ListModelsCommand command22,
            ListPredictionsCommand command23,
            ListTrainingsCommand command24,
            ListVersionsModelsCommand command25,
            UpdateDeploymentsCommand command26)
            : base(
                name: "")
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
            Subcommands.Add(command10);
            Subcommands.Add(command11);
            Subcommands.Add(command12);
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
            Subcommands.Add(command16);
            Subcommands.Add(command17);
            Subcommands.Add(command18);
            Subcommands.Add(command19);
            Subcommands.Add(command20);
            Subcommands.Add(command21);
            Subcommands.Add(command22);
            Subcommands.Add(command23);
            Subcommands.Add(command24);
            Subcommands.Add(command25);
            Subcommands.Add(command26);
        }
    }
}