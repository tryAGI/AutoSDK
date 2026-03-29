//HintName: G.Commands.RoleOperationsV2CreateVectordbRolesGrantPrivilegeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RoleOperationsV2CreateVectordbRolesGrantPrivilegeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? requestTimeout,
            string? authorization,
            string roleName,
            string objectType,
            string objectName,
            string privilege,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> RoleName { get; } = new(
            name: "roleName")
        {
            Description = @"The name of the role.",
        };

        private global::System.CommandLine.Argument<string> ObjectType { get; } = new(
            name: "objectType")
        {
            Description = @"The type of the object to which the privilege belongs.",
        };

        private global::System.CommandLine.Argument<string> ObjectName { get; } = new(
            name: "objectName")
        {
            Description = @"The name of the object to which the role is granted the specified privilege.",
        };

        private global::System.CommandLine.Argument<string> Privilege { get; } = new(
            name: "privilege")
        {
            Description = @"The privilege that is granted to the role.",
        };

        private global::System.CommandLine.Option<int?> RequestTimeout { get; } = new(
            name: "requestTimeout")
        {
            Description = @"The timeout duration for this operation.
Setting this to None indicates that this operation timeouts when any response arrives or any error occurs.",
        };

        private global::System.CommandLine.Option<string?> Authorization { get; } = new(
            name: "authorization")
        {
            Description = @"The authentication token.",
        };


        public RoleOperationsV2CreateVectordbRolesGrantPrivilegeCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation grants a privilege to the current role.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(RoleName);
            Arguments.Add(ObjectType);
            Arguments.Add(ObjectName);
            Arguments.Add(Privilege);
            Options.Add(RequestTimeout);
            Options.Add(Authorization);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var requestTimeout = parseResult.GetRequiredValue(RequestTimeout);
            var authorization = parseResult.GetRequiredValue(Authorization);
            var roleName = parseResult.GetRequiredValue(RoleName);
            var objectType = parseResult.GetRequiredValue(ObjectType);
            var objectName = parseResult.GetRequiredValue(ObjectName);
            var privilege = parseResult.GetRequiredValue(Privilege);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                roleName: roleName,
                objectType: objectType,
                objectName: objectName,
                privilege: privilege,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.RoleOperationsV2.CreateVectordbRolesGrantPrivilegeAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                roleName: roleName,
                objectType: objectType,
                objectName: objectName,
                privilege: privilege,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}