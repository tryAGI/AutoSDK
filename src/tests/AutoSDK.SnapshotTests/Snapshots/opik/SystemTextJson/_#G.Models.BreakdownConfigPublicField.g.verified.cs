//HintName: G.Models.BreakdownConfigPublicField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BreakdownConfigPublicField
    {
        /// <summary>
        /// 
        /// </summary>
        ErrorInfo,
        /// <summary>
        /// 
        /// </summary>
        ErrorType,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Provider,
        /// <summary>
        /// 
        /// </summary>
        Tags,
        /// <summary>
        /// 
        /// </summary>
        Type,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BreakdownConfigPublicFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BreakdownConfigPublicField value)
        {
            return value switch
            {
                BreakdownConfigPublicField.ErrorInfo => "error_info",
                BreakdownConfigPublicField.ErrorType => "error_type",
                BreakdownConfigPublicField.Metadata => "metadata",
                BreakdownConfigPublicField.Model => "model",
                BreakdownConfigPublicField.Name => "name",
                BreakdownConfigPublicField.None => "none",
                BreakdownConfigPublicField.Provider => "provider",
                BreakdownConfigPublicField.Tags => "tags",
                BreakdownConfigPublicField.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BreakdownConfigPublicField? ToEnum(string value)
        {
            return value switch
            {
                "error_info" => BreakdownConfigPublicField.ErrorInfo,
                "error_type" => BreakdownConfigPublicField.ErrorType,
                "metadata" => BreakdownConfigPublicField.Metadata,
                "model" => BreakdownConfigPublicField.Model,
                "name" => BreakdownConfigPublicField.Name,
                "none" => BreakdownConfigPublicField.None,
                "provider" => BreakdownConfigPublicField.Provider,
                "tags" => BreakdownConfigPublicField.Tags,
                "type" => BreakdownConfigPublicField.Type,
                _ => null,
            };
        }
    }
}