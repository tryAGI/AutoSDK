//HintName: G.Models.TestToolResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TestToolResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
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
                TestToolResponseDiscriminatorType.Success => "success",
                TestToolResponseDiscriminatorType.Error => "error",
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
                "success" => TestToolResponseDiscriminatorType.Success,
                "error" => TestToolResponseDiscriminatorType.Error,
                _ => null,
            };
        }
    }
}