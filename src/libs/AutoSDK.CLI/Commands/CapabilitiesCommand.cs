using System.CommandLine;
using System.Text;
using System.Text.Json;

namespace AutoSDK.CLI.Commands;

/// <summary>
/// Reports what this build of the CLI can do, in a form a script can check.
/// <para>
/// This exists because downstream <c>generate.sh</c> scripts need to refuse to run against a CLI that
/// is too old: passing an opt-in flag to a build that accepts it but implements it differently produces
/// a wrong SDK rather than an error. The two obvious ways to detect that are both bad. Grepping
/// <c>--help</c> couples the check to prose that may be reworded. A version floor has to be looked up
/// after the fact and cannot express "this build behaves this way", so it fails open if versions ever
/// move out of order.
/// </para>
/// <para>
/// The token names printed here are a compatibility surface: other repositories check them, so treat
/// them as you would a public API. Add tokens, do not rename or remove them.
/// </para>
/// </summary>
internal sealed class CapabilitiesCommand : Command
{
    /// <summary>
    /// Semantics that no flag name captures on its own, so a script can tell apart builds that accept
    /// the same flag and do different things with it. Every entry must name behaviour this build
    /// actually has — a token here is a promise.
    /// </summary>
    private static readonly (string Token, string Description)[] BehaviourCapabilities =
    [
        ("behavior:request-scoped-enum-rejection",
            "--reject-unknown-enum-values hardens only enums that cannot appear in a response, including one-value enums, so a service shipping a new value does not break deserialization."),
        ("behavior:direction-aware-json-generation",
            "--direction-aware-json-generation-mode picks the narrowest JsonSourceGenerationMode per type from how that type is reached from the operation graph."),
    ];

    private Option<bool> AsJson { get; } = new(
        name: "--json")
    {
        DefaultValueFactory = _ => false,
        Description = "Emit the capabilities as JSON instead of one token per line.",
    };

    private Option<string[]> Require { get; } = new(
        name: "--require")
    {
        AllowMultipleArgumentsPerToken = true,
        DefaultValueFactory = _ => [],
        Description = "Exit non-zero unless every token given is supported. Names the missing ones on stderr. Lets a caller gate on behaviour without parsing help text or comparing versions.",
    };

    public CapabilitiesCommand() : base(
        name: "capabilities",
        description: "List what this build supports, as stable tokens a script can check. Use --require to gate on them.")
    {
        Options.Add(AsJson);
        Options.Add(Require);

        SetAction(Handle);
    }

    private int Handle(ParseResult parseResult)
    {
        var asJson = parseResult.GetRequiredValue(AsJson);
        var required = parseResult.GetRequiredValue(Require);

        var capabilities = Collect();

        if (required.Length > 0)
        {
            var known = new HashSet<string>(capabilities.Select(static x => x.Token), StringComparer.Ordinal);
            var missing = required.Where(x => !known.Contains(x)).ToArray();
            if (missing.Length > 0)
            {
                Console.Error.WriteLine(
                    $"error: this autosdk build does not support: {string.Join(", ", missing)}");
                return 1;
            }

            return 0;
        }

        if (asJson)
        {
            // Written by hand through Utf8JsonWriter: this CLI is trim- and AOT-clean, so the
            // reflection-based JsonSerializer overloads are not available to it.
            using var stream = new MemoryStream();
            using (var writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true }))
            {
                writer.WriteStartArray();
                foreach (var capability in capabilities)
                {
                    writer.WriteStartObject();
                    writer.WriteString("token", capability.Token);
                    writer.WriteString("description", capability.Description);
                    writer.WriteEndObject();
                }

                writer.WriteEndArray();
            }

            Console.WriteLine(Encoding.UTF8.GetString(stream.ToArray()));

            return 0;
        }

        var builder = new StringBuilder();
        foreach (var capability in capabilities)
        {
            builder.AppendLine(capability.Token);
        }

        Console.Write(builder.ToString());

        return 0;
    }

    /// <summary>
    /// Flag tokens are read off the options the commands actually register, so the listing cannot drift
    /// from the build the way a hand-kept list would. Behaviour tokens are curated, because a flag name
    /// says nothing about what the build does with it.
    /// </summary>
    private static List<(string Token, string Description)> Collect()
    {
        var capabilities = new List<(string Token, string Description)>(BehaviourCapabilities);

        foreach (var command in new Command[] { new GenerateCommand(), new CliProjectCommand() })
        {
            foreach (var option in command.Options)
            {
                if (option.Name.StartsWith("--", StringComparison.Ordinal))
                {
                    capabilities.Add((
                        $"flag:{command.Name}:{option.Name[2..]}",
                        option.Description ?? string.Empty));
                }
            }
        }

        capabilities.Sort(static (left, right) => string.CompareOrdinal(left.Token, right.Token));

        return capabilities;
    }
}
