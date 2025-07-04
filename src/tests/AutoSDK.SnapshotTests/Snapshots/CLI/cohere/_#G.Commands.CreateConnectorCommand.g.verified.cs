﻿//HintName: G.Commands.CreateConnectorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConnectorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            bool? active,
            bool? continueOnFailure,
            string? description,
            global::System.Collections.Generic.IList<string>? excludes,
            string name,
            global::G.CreateConnectorOAuth? oauth,
            global::G.CreateConnectorServiceAuth? serviceAuth,
            string url,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateConnectorResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"A human-readable name for the connector.",
        };

        private global::System.CommandLine.Argument<string> Url { get; } = new(
            name: "url")
        {
            Description = @"The URL of the connector that will be used to search for documents.",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };

        private global::System.CommandLine.Option<bool?> Active { get; } = new(
            name: "active")
        {
            Description = @"Whether the connector is active or not.",
        };

        private global::System.CommandLine.Option<bool?> ContinueOnFailure { get; } = new(
            name: "continueOnFailure")
        {
            Description = @"Whether a chat request should continue or not if the request to this connector fails.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"A description of the connector.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Excludes { get; } = new(
            name: "excludes")
        {
            Description = @"A list of fields to exclude from the prompt (fields remain in the document).",
        };

        private global::System.CommandLine.Option<global::G.CreateConnectorOAuth?> Oauth { get; } = new(
            name: "oauth")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.CreateConnectorServiceAuth?> ServiceAuth { get; } = new(
            name: "serviceAuth")
        {
            Description = @"",
        };
        public CreateConnectorCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates a new connector. The connector is tested during registration and will cancel registration when the test is unsuccessful. See ['Creating and Deploying a Connector'](https://docs.cohere.com/v1/docs/creating-and-deploying-a-connector) for more information.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Arguments.Add(Url);
            Options.Add(XClientName);
            Options.Add(Active);
            Options.Add(ContinueOnFailure);
            Options.Add(Description);
            Options.Add(Excludes);
            Options.Add(Oauth);
            Options.Add(ServiceAuth);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var active = parseResult.GetRequiredValue(Active);
            var continueOnFailure = parseResult.GetRequiredValue(ContinueOnFailure);
            var description = parseResult.GetRequiredValue(Description);
            var excludes = parseResult.GetRequiredValue(Excludes);
            var name = parseResult.GetRequiredValue(Name);
            var oauth = parseResult.GetRequiredValue(Oauth);
            var serviceAuth = parseResult.GetRequiredValue(ServiceAuth);
            var url = parseResult.GetRequiredValue(Url);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                active: active,
                continueOnFailure: continueOnFailure,
                description: description,
                excludes: excludes,
                name: name,
                oauth: oauth,
                serviceAuth: serviceAuth,
                url: url,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Connectors.CreateConnectorAsync(
                xClientName: xClientName,
                active: active,
                continueOnFailure: continueOnFailure,
                description: description,
                excludes: excludes,
                name: name,
                oauth: oauth,
                serviceAuth: serviceAuth,
                url: url,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}