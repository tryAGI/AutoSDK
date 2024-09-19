using AutoSDK.UnitTests.Helpers;

namespace AutoSDK.UnitTests;

public partial class Tests
{
    [TestMethod]
    public void PathBuilder_ValidParameters()
    {
        // Arrange
        const string threadId = "123";
        const string runId = "456";
        int? limit = 20;
        ListRunsOrder? order = ListRunsOrder.Desc;
        const string? after = "2023-01-01";
        const string? before = "2023-01-31";

        // Act
        var pathBuilder = new PathBuilder(
            path: $"/threads/{threadId}/runs/{runId}/steps",
            baseUri: new Uri("https://api.openai.com/v1"));
        pathBuilder
            .AddOptionalParameter("limit", limit?.ToString())
            .AddOptionalParameter("order", order?.ToValueString())
            .AddOptionalParameter("after", after)
            .AddOptionalParameter("before", before)
            ;
        var path = pathBuilder.ToString();

        // Assert
        path.Should()
            .Be("https://api.openai.com/v1/threads/123/runs/456/steps?limit=20&order=desc&after=2023-01-01&before=2023-01-31");
    }
    
    [TestMethod]
    public void PathBuilder_NoOptionalParameters()
    {
        // Arrange
        const string threadId = "123";
        const string runId = "456";
        int? limit = null;
        ListRunsOrder? order = null;
        const string? after = null;
        const string? before =null;

        // Act
        var pathBuilder = new PathBuilder(
            path: $"/threads/{threadId}/runs/{runId}/steps",
            baseUri: new Uri("https://api.openai.com/v1"));
        pathBuilder
            .AddOptionalParameter("limit", limit?.ToString())
            .AddOptionalParameter("order", order?.ToValueString())
            .AddOptionalParameter("after", after)
            .AddOptionalParameter("before", before)
            ;
        var path = pathBuilder.ToString();

        // Assert
        path.Should()
            .Be("https://api.openai.com/v1/threads/123/runs/456/steps");
    }

    [TestMethod]
    public void PathBuilder_NullOrder()
    {
        // Arrange
        const string threadId = "123";
        const string runId = "456";
        int? limit = 20;
        ListRunsOrder? order = null;
        const string? after = "2023-01-01";
        const string? before = "2023-01-31";

        // Act
        var pathBuilder = new PathBuilder(
            path: $"/threads/{threadId}/runs/{runId}/steps",
            baseUri: new Uri("https://api.openai.com/v1"));
        pathBuilder
            .AddOptionalParameter("limit", limit?.ToString())
            .AddOptionalParameter("order", order?.ToValueString())
            .AddOptionalParameter("after", after)
            .AddOptionalParameter("before", before)
            ;
        var path = pathBuilder.ToString();

        // Assert
        path.Should()
            .Be("https://api.openai.com/v1/threads/123/runs/456/steps?limit=20&after=2023-01-01&before=2023-01-31");
    }
}

/// <summary>
/// Default Value: desc
/// </summary>
[global::System.Runtime.Serialization.DataContract]
public enum ListRunsOrder
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.EnumMember(Value="asc")]
    Asc,
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.EnumMember(Value="desc")]
    Desc,
}

/// <summary>
/// Enum extensions to do fast conversions without the reflection.
/// </summary>
public static class ListRunsOrderExtensions
{
    /// <summary>
    /// Converts an enum to a string.
    /// </summary>
    public static string ToValueString(this ListRunsOrder value)
    {
        return value switch
        {
            ListRunsOrder.Asc => "asc",
            ListRunsOrder.Desc => "desc",
            _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
        };
    }
    /// <summary>
    /// Converts an string to a enum.
    /// </summary>
    public static ListRunsOrder? ToEnum(string value)
    {
        return value switch
        {
            "asc" => ListRunsOrder.Asc,
            "desc" => ListRunsOrder.Desc,
            _ => null,
        };
    }
}