//HintName: G.Models.FunctionDefinitionValidationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The validation status of the code.<br/>
    /// Example: valid
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionDefinitionValidationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDefinitionValidationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDefinitionValidationStatus value)
        {
            return value switch
            {
                FunctionDefinitionValidationStatus.Pending => "pending",
                FunctionDefinitionValidationStatus.Valid => "valid",
                FunctionDefinitionValidationStatus.Invalid => "invalid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDefinitionValidationStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => FunctionDefinitionValidationStatus.Pending,
                "valid" => FunctionDefinitionValidationStatus.Valid,
                "invalid" => FunctionDefinitionValidationStatus.Invalid,
                _ => null,
            };
        }
    }
}