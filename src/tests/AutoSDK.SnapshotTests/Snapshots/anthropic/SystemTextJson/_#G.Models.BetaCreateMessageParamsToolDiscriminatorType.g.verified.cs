//HintName: G.Models.BetaCreateMessageParamsToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCreateMessageParamsToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Computer20241022,
        /// <summary>
        /// 
        /// </summary>
        Bash20241022,
        /// <summary>
        /// 
        /// </summary>
        TextEditor20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCreateMessageParamsToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCreateMessageParamsToolDiscriminatorType value)
        {
            return value switch
            {
                BetaCreateMessageParamsToolDiscriminatorType.Custom => "custom",
                BetaCreateMessageParamsToolDiscriminatorType.Computer20241022 => "computer_20241022",
                BetaCreateMessageParamsToolDiscriminatorType.Bash20241022 => "bash_20241022",
                BetaCreateMessageParamsToolDiscriminatorType.TextEditor20241022 => "text_editor_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCreateMessageParamsToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => BetaCreateMessageParamsToolDiscriminatorType.Custom,
                "computer_20241022" => BetaCreateMessageParamsToolDiscriminatorType.Computer20241022,
                "bash_20241022" => BetaCreateMessageParamsToolDiscriminatorType.Bash20241022,
                "text_editor_20241022" => BetaCreateMessageParamsToolDiscriminatorType.TextEditor20241022,
                _ => null,
            };
        }
    }
}