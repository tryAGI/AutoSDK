//HintName: G.Commands.UsersUpdateAuthenticatedCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersUpdateAuthenticatedCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? name,
            string? email,
            string? blog,
            string? twitterUsername,
            string? company,
            string? location,
            bool? hireable,
            string? bio,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PrivateUser response,
            global::System.Threading.CancellationToken cancellationToken);


        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Email { get; } = new(
            name: "email")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Blog { get; } = new(
            name: "blog")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> TwitterUsername { get; } = new(
            name: "twitterUsername")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Company { get; } = new(
            name: "company")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Location { get; } = new(
            name: "location")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Hireable { get; } = new(
            name: "hireable")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Bio { get; } = new(
            name: "bio")
        {
            Description = "",
        };
        public UsersUpdateAuthenticatedCommand(G.IApi client) : base(
            name: "users",
            description: @"**Note:** If your email is set to private and you send an `email` parameter as part of this request to update your profile, your privacy settings are still enforced: the email address will not be displayed on your public profile or via the API.")
        {
            _client = client;

            Options.Add(Name);
            Options.Add(Email);
            Options.Add(Blog);
            Options.Add(TwitterUsername);
            Options.Add(Company);
            Options.Add(Location);
            Options.Add(Hireable);
            Options.Add(Bio);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var email = parseResult.GetRequiredValue(Email);
            var blog = parseResult.GetRequiredValue(Blog);
            var twitterUsername = parseResult.GetRequiredValue(TwitterUsername);
            var company = parseResult.GetRequiredValue(Company);
            var location = parseResult.GetRequiredValue(Location);
            var hireable = parseResult.GetRequiredValue(Hireable);
            var bio = parseResult.GetRequiredValue(Bio);

            Validate(
                parseResult: parseResult,
                name: name,
                email: email,
                blog: blog,
                twitterUsername: twitterUsername,
                company: company,
                location: location,
                hireable: hireable,
                bio: bio,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Users.UsersUpdateAuthenticatedAsync(
                name: name,
                email: email,
                blog: blog,
                twitterUsername: twitterUsername,
                company: company,
                location: location,
                hireable: hireable,
                bio: bio,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}