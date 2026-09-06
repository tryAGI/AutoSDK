using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace AutoSDK.SnapshotTests;

/// <summary>
/// Guards the snapshot baselines against a failure that only reproduces on a case-sensitive
/// filesystem, so it passes locally on macOS/Windows and fails in CI on Linux.
///
/// Verify names each baseline after the generated file's hint name. When a collision group is
/// renumbered, a type can change only in casing (`ToolJsonSchema2` -> `ToolJSONSchema2`). On a
/// case-insensitive filesystem the new name resolves to the file already sitting there, so the
/// write lands inside it and git keeps recording the old spelling — while the generator emits,
/// and CI looks for, the new one.
///
/// Every baseline therefore has to be stored under the name its own `//HintName:` header declares.
/// </summary>
[TestClass]
public sealed class SnapshotFileNamingTests
{
    [TestMethod]
    public void EverySnapshotIsStoredUnderTheNameItsHintNameDeclares()
    {
        var snapshots = Path.Combine(GetProjectDirectory(), "Snapshots");
        if (!Directory.Exists(snapshots))
        {
            Assert.Inconclusive($"Snapshots directory was not found at '{snapshots}'.");
            return;
        }

        var mismatches = new ConcurrentBag<string>();
        Parallel.ForEach(
            Directory.EnumerateFiles(snapshots, "*.verified.cs", SearchOption.AllDirectories),
            path =>
            {
                var hintName = ReadHintName(path);
                if (hintName == null)
                {
                    return;
                }

                // "G.Models.Foo.g.cs" is stored as "_#G.Models.Foo.g.verified.cs".
                var expected = "_#" + hintName[..^".cs".Length] + ".verified.cs";
                var actual = Path.GetFileName(path);
                if (!string.Equals(expected, actual, StringComparison.Ordinal))
                {
                    mismatches.Add(
                        $"{Path.GetRelativePath(snapshots, path)}{Environment.NewLine}" +
                        $"    declares HintName: {hintName}{Environment.NewLine}" +
                        $"    so it must be stored as: {expected}");
                }
            });

        mismatches.Should().BeEmpty(
            "every snapshot must be stored under the name its HintName declares, otherwise it " +
            "reads as a missing file on a case-sensitive filesystem. Rename the offenders with " +
            "`git mv` (two steps on a case-insensitive filesystem, via a temporary name):" +
            Environment.NewLine + string.Join(Environment.NewLine, mismatches.OrderBy(x => x, StringComparer.Ordinal)));
    }

    /// <summary>
    /// The same hazard one level up. A `.verified.txt` baseline is named after its test method, so
    /// its own filename carries no casing to get wrong — but the directory holding it is derived
    /// from the spec's filename (`callerName` is <c>Path.GetFileNameWithoutExtension(fileName)</c>),
    /// and a directory can be mis-cased in exactly the same way a file can.
    ///
    /// A directory that matches a spec only when case is ignored is therefore a real defect; one
    /// that matches no spec at all is named after a test method (`Empty`, `ParallelGeneration`, …)
    /// and is none of this test's business.
    /// </summary>
    [TestMethod]
    public void EverySpecNamedSnapshotDirectoryMatchesItsSpecFileCasing()
    {
        var projectDirectory = GetProjectDirectory();
        var snapshots = Path.Combine(projectDirectory, "Snapshots");
        var specs = Path.GetFullPath(Path.Combine(projectDirectory, "..", "..", "..", "specs"));
        if (!Directory.Exists(snapshots) || !Directory.Exists(specs))
        {
            Assert.Inconclusive($"Expected '{snapshots}' and '{specs}' to exist.");
            return;
        }

        var specStemsByLowercase = Directory.EnumerateFiles(specs)
            .Select(Path.GetFileNameWithoutExtension)
            .OfType<string>()
            .Distinct(StringComparer.Ordinal)
            .ToLookup(x => x.ToLowerInvariant(), StringComparer.Ordinal);

        // Snapshots/<callerName>/... and Snapshots/CLI/<callerName>/...
        var candidates = Directory.EnumerateDirectories(snapshots)
            .Where(x => !string.Equals(Path.GetFileName(x), "CLI", StringComparison.Ordinal))
            .Concat(Directory.Exists(Path.Combine(snapshots, "CLI"))
                ? Directory.EnumerateDirectories(Path.Combine(snapshots, "CLI"))
                : []);

        var mismatches = new List<string>();
        foreach (var directory in candidates)
        {
            var name = Path.GetFileName(directory);
            var specStems = specStemsByLowercase[name.ToLowerInvariant()].ToArray();
            if (specStems.Length == 0 || specStems.Contains(name, StringComparer.Ordinal))
            {
                continue;
            }

            mismatches.Add(
                $"{Path.GetRelativePath(snapshots, directory)}{Environment.NewLine}" +
                $"    matches spec '{specStems[0]}' only when case is ignored");
        }

        mismatches.Should().BeEmpty(
            "a snapshot directory is named after its spec file, so a casing difference reads as a " +
            "missing directory on a case-sensitive filesystem:" +
            Environment.NewLine + string.Join(Environment.NewLine, mismatches.OrderBy(x => x, StringComparer.Ordinal)));
    }

    private static string? ReadHintName(string path)
    {
        using var reader = new StreamReader(path, detectEncodingFromByteOrderMarks: true);
        var firstLine = reader.ReadLine();

        const string prefix = "//HintName:";
        if (firstLine == null || !firstLine.StartsWith(prefix, StringComparison.Ordinal))
        {
            return null;
        }

        var hintName = firstLine[prefix.Length..].Trim();

        return hintName.EndsWith(".cs", StringComparison.Ordinal) ? hintName : null;
    }

    private static string GetProjectDirectory([CallerFilePath] string sourceFilePath = "")
    {
        return Path.GetDirectoryName(sourceFilePath) ?? string.Empty;
    }
}
