//HintName: G.Commands.TreesCreateTreeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TreesCreateTreeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? id,
            string? name,
            global::System.Collections.Generic.IList<global::G.TreeNode>? children,
            global::G.TreeNode? parent,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TreeNode response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.TreeNode>?> Children { get; } = new(
            name: "children")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.TreeNode?> Parent { get; } = new(
            name: "parent")
        {
            Description = @"",
        };


        public TreesCreateTreeCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Id);
            Options.Add(Name);
            Options.Add(Children);
            Options.Add(Parent);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var children = parseResult.GetRequiredValue(Children);
            var parent = parseResult.GetRequiredValue(Parent);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                children: children,
                parent: parent,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Trees.CreateTreeAsync(
                id: id,
                name: name,
                children: children,
                parent: parent,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}