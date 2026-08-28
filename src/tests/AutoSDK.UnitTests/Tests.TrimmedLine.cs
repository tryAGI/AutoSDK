using AutoSDK.Extensions;
using AutoSDK.Generation;

namespace AutoSDK.UnitTests;

[TestClass]
public class TrimmedLineTests
{
    [TestMethod]
    public void RemoveBlankLinesWhereOnlyWhitespaces_RemovesWhitespaceOnlyLines()
    {
        // A single space " " is a whitespace-only line — it should be removed.
        // This is the core behavior that Sources.TrimmedLine relies on.
        var input = "line1\n \nline2";
        var result = input.RemoveBlankLinesWhereOnlyWhitespaces();
        result.Should().Be("line1\nline2");
    }

    [TestMethod]
    public void RemoveBlankLinesWhereOnlyWhitespaces_PreservesTrulyEmptyLines()
    {
        // An empty line (length 0) is preserved — this is intentional spacing.
        var input = "line1\n\nline2";
        var result = input.RemoveBlankLinesWhereOnlyWhitespaces();
        result.Should().Be("line1\n\nline2");
    }

    [TestMethod]
    public void RemoveBlankLinesWhereOnlyWhitespaces_RemovesMultipleSpaceLines()
    {
        // Lines with multiple spaces or tabs are also whitespace-only and removed.
        var input = "line1\n    \nline2\n\t\t\nline3";
        var result = input.RemoveBlankLinesWhereOnlyWhitespaces();
        result.Should().Be("line1\nline2\nline3");
    }

    [TestMethod]
    public void RemoveBlankLinesWhereOnlyWhitespaces_PreservesTrailingWhitespaceWithoutSplittingLines()
    {
        var input = "line1  \r\nline2\t\rline3";

        var result = input.RemoveBlankLinesWhereOnlyWhitespaces();

        result.Should().Be("line1  \nline2\t\nline3");
    }

    [TestMethod]
    public void RemoveBlankLinesWhereOnlyWhitespaces_ReturnsOriginalInstanceWhenAlreadyNormalized()
    {
        var input = new string("line1  \nline2".ToCharArray());

        var result = input.RemoveBlankLinesWhereOnlyWhitespaces();

        ReferenceEquals(input, result).Should().BeTrue();
    }

    [TestMethod]
    public void Inject_ReturnsSpaceForEmptyInput()
    {
        // When Inject() receives only whitespace/empty strings, it returns " " (the TrimmedLine value).
        // This ensures that empty template selections still produce a trimmed line.
        var result = Enumerable.Empty<string>().Inject();
        result.Should().Be(" ");
    }

    [TestMethod]
    public void Inject_TrimsOnlyOuterLineBreaksAcrossValues()
    {
        var result = new[] { "\r\n", "first\n", "second", "\n\r" }.Inject();

        result.Should().Be("first\nsecond");
    }

    [TestMethod]
    public void AddIndent_PreservesEmptyAndTrailingLines()
    {
        var result = "first\n\nsecond\n".AddIndent(level: 1);

        result.Should().Be("    first\n\n    second\n");
    }

    [TestMethod]
    public void TrimmedLine_InTernaryTemplate_SuppressesLine()
    {
        // Simulates the pattern used in Sources templates:
        // {(condition ? "content" : TrimmedLine)} where TrimmedLine = " "
        const string trimmedLine = " ";
        var condition = false;
        var template = $@"before
{(condition ? "    [SomeAttribute]" : trimmedLine)}
after";

        var result = template.RemoveBlankLinesWhereOnlyWhitespaces();
        result.Should().Be("before\nafter");
    }

    [TestMethod]
    public void TrimmedLine_InTernaryTemplate_PreservesContentWhenConditionTrue()
    {
        const string trimmedLine = " ";
        var condition = true;
        var template = $@"before
{(condition ? "    [SomeAttribute]" : trimmedLine)}
after";

        var result = template.RemoveBlankLinesWhereOnlyWhitespaces();
        result.Should().Be("before\n    [SomeAttribute]\nafter");
    }

    [TestMethod]
    public void NormalizedString_MatchesPostGenerationNormalizationAcrossFormattedValues()
    {
        var first = "first\r";
        var lineFeedAndWhitespace = "\n   \n";
        var value = 42;

        var result = NormalizedString.Create($@"{first}{lineFeedAndWhitespace}
value: {value:D3}

 ");
        var expected = $@"{first}{lineFeedAndWhitespace}
value: {value:D3}

 ".RemoveBlankLinesWhereOnlyWhitespaces();

        result.Should().Be(expected);
    }

    [TestMethod]
    public void IndentedString_MatchesAddIndentAcrossFormattedValueBoundaries()
    {
        var first = "first\n";
        var emptyAndSecond = "\nsecond\r";

        var result = IndentedString.Create(2, $"{first}{emptyAndSecond}\nthird\n");
        var expected = $"{first}{emptyAndSecond}\nthird\n".AddIndent(level: 2);

        result.Should().Be(expected);
    }

    [TestMethod]
    public void NormalizedString_WithIndentationMatchesNormalizeThenAddIndent()
    {
        var first = "first\r";
        var lineFeedAndWhitespace = "\n   \n";

        var result = NormalizedString.Create(2, $"{first}{lineFeedAndWhitespace}\nsecond\n");
        var expected = $"{first}{lineFeedAndWhitespace}\nsecond\n"
            .RemoveBlankLinesWhereOnlyWhitespaces()
            .AddIndent(level: 2);

        result.Should().Be(expected);
    }

    [TestMethod]
    public void NormalizedPooledStringBuilder_MatchesNormalizationAcrossAppendBoundaries()
    {
        using var builder = new NormalizedPooledStringBuilder();
        builder.Append("first\r");
        builder.Append('\n');
        builder.Append("   \n");
        builder.Append("second");
        builder.Append('\n', 2);
        builder.Append("\t\nthird");

        var result = builder.ToString();
        var expected = "first\r\n   \nsecond\n\n\t\nthird"
            .RemoveBlankLinesWhereOnlyWhitespaces();

        result.Should().Be(expected);
    }
}
