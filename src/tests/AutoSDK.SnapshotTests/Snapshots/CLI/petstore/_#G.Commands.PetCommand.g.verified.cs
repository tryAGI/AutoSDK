//HintName: G.Commands.PetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PetCommand : global::System.CommandLine.Command
    {
        public PetCommand(
            ListPetsCommand command0,
            CreatePetsCommand command1,
            ShowPetByIdCommand command2)
            : base(
                name: "pet")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}