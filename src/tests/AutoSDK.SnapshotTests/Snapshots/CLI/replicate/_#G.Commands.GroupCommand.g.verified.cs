//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            GetAccountCommand command0,
            ListCollectionsCommand command1,
            GetCollectionsCommand command2,
            ListDeploymentsCommand command3,
            CreateDeploymentsCommand command4,
            DeleteDeploymentsCommand command5,
            GetDeploymentsCommand command6,
            UpdateDeploymentsCommand command7,
            CreatePredictionsDeploymentsCommand command8,
            ListHardwareCommand command9,
            ListModelsCommand command10,
            CreateModelsCommand command11,
            DeleteModelsCommand command12,
            GetModelsCommand command13,
            CreatePredictionsModelsCommand command14,
            ListVersionsModelsCommand command15,
            DeleteVersionsModelsCommand command16,
            GetVersionsModelsCommand command17,
            CreateTrainingsCommand command18,
            ListPredictionsCommand command19,
            CreatePredictionsCommand command20,
            GetPredictionsCommand command21,
            CancelPredictionsCommand command22,
            ListTrainingsCommand command23,
            GetTrainingsCommand command24,
            CancelTrainingsCommand command25,
            GetSecretDefaultWebhooksCommand command26)
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