//HintName: G.Commands.OrgsGetCustomPropertyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsGetCustomPropertyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string customPropertyName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CustomProperty response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> CustomPropertyName { get; } = new(
            name: "customPropertyName")
        {
            Description = "",
        };

        public OrgsGetCustomPropertyCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Gets a custom property that is defined for an organization.
Organization members can read these properties.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(CustomPropertyName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var customPropertyName = parseResult.GetRequiredValue(CustomPropertyName);

            Validate(
                parseResult: parseResult,
                org: org,
                customPropertyName: customPropertyName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsGetCustomPropertyAsync(
                org: org,
                customPropertyName: customPropertyName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}