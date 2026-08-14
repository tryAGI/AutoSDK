using System.Globalization;

namespace AutoSDK.Generation;

/// <summary>
/// Summary of how the direction analysis classified the types registered in the generated
/// JsonSerializerContext. Reported at generation time so a spec whose analysis degrades to
/// mostly-unclassified is visible without diffing generated output.
/// </summary>
public readonly struct JsonSerializationDirectionReport : IEquatable<JsonSerializationDirectionReport>
{
    public JsonSerializationDirectionReport(
        int requestOnly,
        int responseOnly,
        int bidirectional,
        int unclassified,
        bool fastPathAvailable)
    {
        RequestOnly = requestOnly;
        ResponseOnly = responseOnly;
        Bidirectional = bidirectional;
        Unclassified = unclassified;
        FastPathAvailable = fastPathAvailable;
    }

    /// <summary>
    /// Types reached only through request bodies or parameters.
    /// </summary>
    public int RequestOnly { get; }

    /// <summary>
    /// Types reached only through response bodies.
    /// </summary>
    public int ResponseOnly { get; }

    /// <summary>
    /// Types reached in both directions.
    /// </summary>
    public int Bidirectional { get; }

    /// <summary>
    /// Types that no operation reaches, which keep the default generation mode.
    /// </summary>
    public int Unclassified { get; }

    /// <summary>
    /// Whether the generated context can use source-generated fast-path serialization at all.
    /// It cannot once any converter is registered, which is why request-only types normally
    /// narrow to Metadata rather than Serialization.
    /// </summary>
    public bool FastPathAvailable { get; }

    /// <summary>
    /// Total number of classified registrations.
    /// </summary>
    public int Total => RequestOnly + ResponseOnly + Bidirectional + Unclassified;

    /// <inheritdoc />
    public override string ToString()
    {
        var counts = string.Format(
            CultureInfo.InvariantCulture,
            "Direction-aware JSON generation modes: {0} request-only, {1} response-only, {2} bidirectional, {3} unclassified of {4} registered types.",
            RequestOnly,
            ResponseOnly,
            Bidirectional,
            Unclassified,
            Total);

        return FastPathAvailable
            ? counts + " Request-only types without generated FromJson helpers use Serialization; response-only types use Metadata."
            : counts + " Registered converters disable source-generated fast-path serialization, so single-direction types use Metadata.";
    }

    /// <inheritdoc />
    public bool Equals(JsonSerializationDirectionReport other)
    {
        return RequestOnly == other.RequestOnly &&
               ResponseOnly == other.ResponseOnly &&
               Bidirectional == other.Bidirectional &&
               Unclassified == other.Unclassified &&
               FastPathAvailable == other.FastPathAvailable;
    }

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        return obj is JsonSerializationDirectionReport other && Equals(other);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var hash = RequestOnly;
        hash = (hash * 397) ^ ResponseOnly;
        hash = (hash * 397) ^ Bidirectional;
        hash = (hash * 397) ^ Unclassified;
        return (hash * 397) ^ (FastPathAvailable ? 1 : 0);
    }

    public static bool operator ==(JsonSerializationDirectionReport left, JsonSerializationDirectionReport right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(JsonSerializationDirectionReport left, JsonSerializationDirectionReport right)
    {
        return !left.Equals(right);
    }
}
