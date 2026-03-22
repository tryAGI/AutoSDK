//HintName: G.Models.TestToolResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestToolResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestToolResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestToolResponseDiscriminatorType value)
        {
            return value switch
            {
                TestToolResponseDiscriminatorType.Error => "error",
                TestToolResponseDiscriminatorType.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestToolResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => TestToolResponseDiscriminatorType.Error,
                "success" => TestToolResponseDiscriminatorType.Success,
                _ => null,
            };
        }
    }
}