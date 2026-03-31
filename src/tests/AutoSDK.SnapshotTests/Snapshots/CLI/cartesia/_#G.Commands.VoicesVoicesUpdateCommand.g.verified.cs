//HintName: G.Commands.VoicesVoicesUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoicesVoicesUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VoicesUpdateCartesiaVersion cartesiaVersion,
            string id,
            string name,
            string description,
            global::G.GenderPresentation? gender,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Voice response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.VoicesUpdateCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of the voice.",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"The name of the voice.",
        };

        private new global::System.CommandLine.Argument<string> Description { get; } = new(
            name: "description")
        {
            Description = @"The description of the voice.",
        };

        private global::System.CommandLine.Option<global::G.GenderPresentation?> Gender { get; } = new(
            name: "gender")
        {
            Description = @"",
        };


        public VoicesVoicesUpdateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "voices",
            description: @"Update the name, description, and gender of a voice. To set the gender back to the default, set the gender to `null`. If gender is not specified, the gender will not be updated.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(Id);
            Arguments.Add(Name);
            Arguments.Add(Description);
            Options.Add(Gender);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var gender = parseResult.GetRequiredValue(Gender);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                id: id,
                name: name,
                description: description,
                gender: gender,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.VoicesUpdateAsync(
                cartesiaVersion: cartesiaVersion,
                id: id,
                name: name,
                description: description,
                gender: gender,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}