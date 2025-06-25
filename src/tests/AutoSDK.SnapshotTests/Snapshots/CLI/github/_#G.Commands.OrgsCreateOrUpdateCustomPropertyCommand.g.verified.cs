//HintName: G.Commands.OrgsCreateOrUpdateCustomPropertyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsCreateOrUpdateCustomPropertyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string customPropertyName,
            global::G.OrgsCreateOrUpdateCustomPropertyRequestValueType valueType,
            bool? required,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? defaultValue,
            string? description,
            global::System.Collections.Generic.IList<string>? allowedValues,
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

        private global::System.CommandLine.Argument<global::G.OrgsCreateOrUpdateCustomPropertyRequestValueType> ValueType { get; } = new(
            name: "valueType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Required { get; } = new(
            name: "required")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OneOf<string, global::System.Collections.Generic.IList<string>>?> DefaultValue { get; } = new(
            name: "defaultValue")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> AllowedValues { get; } = new(
            name: "allowedValues")
        {
            Description = "",
        };
        public OrgsCreateOrUpdateCustomPropertyCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Creates a new or updates an existing custom property that is defined for an organization.

To use this endpoint, the authenticated user must be one of:
- An administrator for the organization.
- A user, or a user on a team, with the fine-grained permission of `custom_properties_org_definitions_manager` in the organization.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(CustomPropertyName);
            Arguments.Add(ValueType);
            Options.Add(Required);
            Options.Add(DefaultValue);
            Options.Add(Description);
            Options.Add(AllowedValues);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var customPropertyName = parseResult.GetRequiredValue(CustomPropertyName);
            var valueType = parseResult.GetRequiredValue(ValueType);
            var required = parseResult.GetRequiredValue(Required);
            var defaultValue = parseResult.GetRequiredValue(DefaultValue);
            var description = parseResult.GetRequiredValue(Description);
            var allowedValues = parseResult.GetRequiredValue(AllowedValues);

            Validate(
                parseResult: parseResult,
                org: org,
                customPropertyName: customPropertyName,
                valueType: valueType,
                required: required,
                defaultValue: defaultValue,
                description: description,
                allowedValues: allowedValues,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsCreateOrUpdateCustomPropertyAsync(
                org: org,
                customPropertyName: customPropertyName,
                valueType: valueType,
                required: required,
                defaultValue: defaultValue,
                description: description,
                allowedValues: allowedValues,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}