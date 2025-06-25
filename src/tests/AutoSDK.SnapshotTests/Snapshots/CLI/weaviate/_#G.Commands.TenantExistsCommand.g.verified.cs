//HintName: G.Commands.TenantExistsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TenantExistsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string className,
            string tenantName,
            bool? consistency,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ClassName { get; } = new(
            name: "className")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> TenantName { get; } = new(
            name: "tenantName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Consistency { get; } = new(
            name: "consistency")
        {
            Description = "",
        };
        public TenantExistsCommand(G.IApi client) : base(
            name: "tenant",
            description: @"Check if a tenant exists for a specific class")
        {
            _client = client;

            Arguments.Add(ClassName);
            Arguments.Add(TenantName);
            Options.Add(Consistency);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var className = parseResult.GetRequiredValue(ClassName);
            var tenantName = parseResult.GetRequiredValue(TenantName);
            var consistency = parseResult.GetRequiredValue(Consistency);

            Validate(
                parseResult: parseResult,
                className: className,
                tenantName: tenantName,
                consistency: consistency,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Schema.TenantExistsAsync(
                className: className,
                tenantName: tenantName,
                consistency: consistency,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}