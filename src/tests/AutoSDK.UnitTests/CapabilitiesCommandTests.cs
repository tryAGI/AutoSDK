extern alias AutoSdkCli;

using System.CommandLine;
using CapabilitiesCommand = AutoSdkCli::AutoSDK.CLI.Commands.CapabilitiesCommand;

namespace AutoSDK.UnitTests;

/// <summary>
/// The tokens this command prints are checked by other repositories' `generate.sh` scripts, so they are
/// a compatibility surface rather than diagnostics. These tests exist to make renaming one a failure
/// here instead of a silent breakage downstream.
/// <para>
/// Not parallelised: these assertions read what the command wrote to <c>Console.Out</c>, which is
/// process-wide, so running them alongside each other makes one test capture another's output. The
/// symptom was two tests seeing an empty string while a third saw the plain listing where it expected
/// JSON, and each one passing on its own.
/// </para>
/// </summary>
[TestClass]
[DoNotParallelize]
public class CapabilitiesCommandTests
{
    [TestMethod]
    public void Capabilities_ListsTheBehaviourTokensDownstreamScriptsGateOn()
    {
        var output = Run("capabilities");

        // Named explicitly: tryAGI/Runway and tryAGI/Firecrawl refuse to regenerate without this one,
        // because a build that accepts --reject-unknown-enum-values but hardens response enums too
        // produces an SDK that throws on ordinary replies.
        output.Should().Contain("behavior:request-scoped-enum-rejection");
        output.Should().Contain("behavior:direction-aware-json-generation");

        // Each of these names a semantic that the flag's presence alone does not establish, and each was
        // checked against the committed source before being claimed here — a token is a promise.
        output.Should().Contain("behavior:pager-next-url-same-origin");
        output.Should().Contain("behavior:retry-handler-vendor-defaults");
        output.Should().Contain("behavior:idempotency-without-vendor-extension");
        output.Should().Contain("behavior:polymorphic-array-auto-detection");
        output.Should().Contain("behavior:call-scoped-auth");

        // Checked by tryAGI/AutoSDK's own regenerate-cli-completion.sh, which until now inferred the
        // capability from a file turning up after the fact.
        output.Should().Contain("behavior:cli-completion");
    }

    [TestMethod]
    public void Capabilities_DerivesFlagTokensFromTheOptionsActuallyRegistered()
    {
        var output = Run("capabilities");

        // Derived from the command's own options rather than a hand-kept list, so the listing cannot
        // claim a flag the build does not have.
        output.Should().Contain("flag:generate:reject-unknown-enum-values");
        output.Should().Contain("flag:cli-project:api-only");
    }

    [TestMethod]
    public void Capabilities_RequireSucceedsForASupportedToken()
    {
        Invoke("capabilities", "--require", "behavior:request-scoped-enum-rejection")
            .Should().Be(0);
    }

    [TestMethod]
    public void Capabilities_RequireFailsAndNamesOnlyWhatIsMissing()
    {
        var error = new StringWriter();
        var previous = Console.Error;
        Console.SetError(error);
        try
        {
            Invoke(
                "capabilities",
                "--require",
                "behavior:request-scoped-enum-rejection",
                "behavior:not-a-real-capability")
                .Should().Be(1, "one unsupported token is enough to fail the gate");
        }
        finally
        {
            Console.SetError(previous);
        }

        error.ToString().Should().Contain("behavior:not-a-real-capability");
        error.ToString().Should().NotContain(
            "behavior:request-scoped-enum-rejection",
            "a supported token must not be reported as missing");
    }

    [TestMethod]
    public void Capabilities_JsonCarriesTheSameTokens()
    {
        var output = Run("capabilities", "--json");

        output.Should().StartWith("[");
        output.Should().Contain("\"token\": \"behavior:request-scoped-enum-rejection\"");
    }

    private static int Invoke(params string[] args)
    {
        var root = new RootCommand("test");
        root.Subcommands.Add(new CapabilitiesCommand());

        return root.Parse(args).Invoke();
    }

    private static string Run(params string[] args)
    {
        var output = new StringWriter();
        var previous = Console.Out;
        Console.SetOut(output);
        try
        {
            Invoke(args).Should().Be(0);
        }
        finally
        {
            Console.SetOut(previous);
        }

        return output.ToString();
    }
}
