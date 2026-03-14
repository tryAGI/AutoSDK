//HintName: G.Models.TestLambdaToolResponseValidationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Overall validation status.<br/>
    /// Example: valid
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TestLambdaToolResponseValidationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="valid")]
        Valid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid")]
        Invalid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestLambdaToolResponseValidationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestLambdaToolResponseValidationStatus value)
        {
            return value switch
            {
                TestLambdaToolResponseValidationStatus.Valid => "valid",
                TestLambdaToolResponseValidationStatus.Invalid => "invalid",
                TestLambdaToolResponseValidationStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestLambdaToolResponseValidationStatus? ToEnum(string value)
        {
            return value switch
            {
                "valid" => TestLambdaToolResponseValidationStatus.Valid,
                "invalid" => TestLambdaToolResponseValidationStatus.Invalid,
                "pending" => TestLambdaToolResponseValidationStatus.Pending,
                _ => null,
            };
        }
    }
}