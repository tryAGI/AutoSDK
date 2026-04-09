namespace AutoSDK.JsonConverters;

public readonly partial struct TestOpenEnum : global::System.IEquatable<TestOpenEnum>
{
    public TestOpenEnum(string value)
    {
        Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
    }

    public string Value { get; }

    public static TestOpenEnum PullingManifest { get; } = new("pulling manifest");

    public static TestOpenEnum Success { get; } = new("success");

    public static TestOpenEnum FromValue(string value)
    {
        value = value ?? throw new global::System.ArgumentNullException(nameof(value));

        return value switch
        {
            "pulling manifest" => PullingManifest,
            "success" => Success,
            _ => new TestOpenEnum(value),
        };
    }

    public bool IsKnown => Value switch
    {
        "pulling manifest" => true,
        "success" => true,
        _ => false,
    };

    public override string ToString() => Value ?? string.Empty;

    public bool Equals(TestOpenEnum other)
    {
        return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
    }

    public override bool Equals(object? obj)
    {
        return obj is TestOpenEnum other && Equals(other);
    }

    public override int GetHashCode()
    {
        return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
    }

    public static bool operator ==(TestOpenEnum left, TestOpenEnum right) => left.Equals(right);

    public static bool operator !=(TestOpenEnum left, TestOpenEnum right) => !left.Equals(right);
}
