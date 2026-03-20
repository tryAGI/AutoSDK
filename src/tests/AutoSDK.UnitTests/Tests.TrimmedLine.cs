using AutoSDK.Extensions;

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
    public void Inject_ReturnsSpaceForEmptyInput()
    {
        // When Inject() receives only whitespace/empty strings, it returns " " (the TrimmedLine value).
        // This ensures that empty template selections still produce a trimmed line.
        var result = Enumerable.Empty<string>().Inject();
        result.Should().Be(" ");
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
}
