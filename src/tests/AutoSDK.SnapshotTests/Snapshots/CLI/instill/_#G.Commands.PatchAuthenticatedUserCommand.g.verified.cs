//HintName: G.Commands.PatchAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PatchAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? uid,
            string id,
            string email,
            string? role,
            bool newsletterSubscription,
            string? cookieToken,
            global::G.OnboardingStatus? onboardingStatus,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PatchAuthenticatedUserResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Email { get; } = new(
            name: "email")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<bool> NewsletterSubscription { get; } = new(
            name: "newsletterSubscription")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Uid { get; } = new(
            name: "uid")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Role { get; } = new(
            name: "role")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CookieToken { get; } = new(
            name: "cookieToken")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OnboardingStatus?> OnboardingStatus { get; } = new(
            name: "onboardingStatus")
        {
            Description = "",
        };
        public PatchAuthenticatedUserCommand(G.IApi client) : base(
            name: "patch",
            description: @"Updates the information of the authenticated user.

In REST requests, only the supplied user fields will be taken into account
when updating the resource.")
        {
            _client = client;

            Arguments.Add(Id);
            Arguments.Add(Email);
            Arguments.Add(NewsletterSubscription);
            Options.Add(Uid);
            Options.Add(Role);
            Options.Add(CookieToken);
            Options.Add(OnboardingStatus);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var uid = parseResult.GetRequiredValue(Uid);
            var id = parseResult.GetRequiredValue(Id);
            var email = parseResult.GetRequiredValue(Email);
            var role = parseResult.GetRequiredValue(Role);
            var newsletterSubscription = parseResult.GetRequiredValue(NewsletterSubscription);
            var cookieToken = parseResult.GetRequiredValue(CookieToken);
            var onboardingStatus = parseResult.GetRequiredValue(OnboardingStatus);

            Validate(
                parseResult: parseResult,
                uid: uid,
                id: id,
                email: email,
                role: role,
                newsletterSubscription: newsletterSubscription,
                cookieToken: cookieToken,
                onboardingStatus: onboardingStatus,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.PatchAuthenticatedUserAsync(
                uid: uid,
                id: id,
                email: email,
                role: role,
                newsletterSubscription: newsletterSubscription,
                cookieToken: cookieToken,
                onboardingStatus: onboardingStatus,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}