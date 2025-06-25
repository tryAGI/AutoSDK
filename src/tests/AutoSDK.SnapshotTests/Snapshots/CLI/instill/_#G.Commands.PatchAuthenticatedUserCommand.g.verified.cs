//HintName: G.Commands.PatchAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PatchAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"Resource ID (used in `name` as the last segment). This conforms to
RFC-1034, which restricts to letters, numbers, and hyphen, with the first
character a letter, the last a letter or a number, and a 63 character
maximum.

Note that the ID can be updated.",
        };

        private global::System.CommandLine.Argument<string> Email { get; } = new(
            name: "email")
        {
            Description = @"Email.",
        };

        private global::System.CommandLine.Argument<bool> NewsletterSubscription { get; } = new(
            name: "newsletterSubscription")
        {
            Description = @"This defines whether the user is subscribed to Instill AI's newsletter.",
        };

        private global::System.CommandLine.Option<string?> Uid { get; } = new(
            name: "uid")
        {
            Description = @"User UUID. This field is optionally set by users on creation (it will be
server-generated if unspecified).",
        };

        private global::System.CommandLine.Option<string?> Role { get; } = new(
            name: "role")
        {
            Description = @"Role.

It must be one of the following allowed roles:
- `manager`
- `ai-researcher`
- `ai-engineer`
- `data-engineer`
- `data-scientist`
- `analytics-engineer`
- `hobbyist`",
        };

        private global::System.CommandLine.Option<string?> CookieToken { get; } = new(
            name: "cookieToken")
        {
            Description = @"Console cookie token.",
        };

        private global::System.CommandLine.Option<global::G.OnboardingStatus?> OnboardingStatus { get; } = new(
            name: "onboardingStatus")
        {
            Description = @"Onboarding Status.",
        };
        public PatchAuthenticatedUserCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "patch",
            description: @"Updates the information of the authenticated user.

In REST requests, only the supplied user fields will be taken into account
when updating the resource.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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