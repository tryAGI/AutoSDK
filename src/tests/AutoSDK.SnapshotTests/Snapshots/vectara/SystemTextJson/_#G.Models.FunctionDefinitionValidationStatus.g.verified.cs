//HintName: G.Models.FunctionDefinitionValidationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The validation status of the code.<br/>
    /// Example: valid
    /// </summary>
    public enum FunctionDefinitionValidationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Invalid,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Valid,
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
                FunctionDefinitionValidationStatus.Invalid => "invalid",
                FunctionDefinitionValidationStatus.Pending => "pending",
                FunctionDefinitionValidationStatus.Valid => "valid",
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
                "invalid" => FunctionDefinitionValidationStatus.Invalid,
                "pending" => FunctionDefinitionValidationStatus.Pending,
                "valid" => FunctionDefinitionValidationStatus.Valid,
                _ => null,
            };
        }
    }
}