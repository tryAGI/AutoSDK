//HintName: G.Commands.OrgsConvertMemberToOutsideCollaboratorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsConvertMemberToOutsideCollaboratorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string username,
            bool? async,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OrgsConvertMemberToOutsideCollaboratorResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Async { get; } = new(
            name: "async")
        {
            Description = "",
        };
        public OrgsConvertMemberToOutsideCollaboratorCommand(G.IApi client) : base(
            name: "orgs",
            description: @"When an organization member is converted to an outside collaborator, they'll only have access to the repositories that their current team membership allows. The user will no longer be a member of the organization. For more information, see ""[Converting an organization member to an outside collaborator](https://docs.github.com/articles/converting-an-organization-member-to-an-outside-collaborator/)"". Converting an organization member to an outside collaborator may be restricted by enterprise administrators. For more information, see ""[Enforcing repository management policies in your enterprise](https://docs.github.com/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories).""")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Username);
            Options.Add(Async);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var username = parseResult.GetRequiredValue(Username);
            var async = parseResult.GetRequiredValue(Async);

            Validate(
                parseResult: parseResult,
                org: org,
                username: username,
                async: async,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsConvertMemberToOutsideCollaboratorAsync(
                org: org,
                username: username,
                async: async,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}