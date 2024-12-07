//HintName: G.Models.BetaCountMessageTokensParamsToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCountMessageTokensParamsToolDiscriminatorType
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
    public static class BetaCountMessageTokensParamsToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCountMessageTokensParamsToolDiscriminatorType value)
        {
            return value switch
            {
                BetaCountMessageTokensParamsToolDiscriminatorType.Custom => "custom",
                BetaCountMessageTokensParamsToolDiscriminatorType.Computer20241022 => "computer_20241022",
                BetaCountMessageTokensParamsToolDiscriminatorType.Bash20241022 => "bash_20241022",
                BetaCountMessageTokensParamsToolDiscriminatorType.TextEditor20241022 => "text_editor_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCountMessageTokensParamsToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => BetaCountMessageTokensParamsToolDiscriminatorType.Custom,
                "computer_20241022" => BetaCountMessageTokensParamsToolDiscriminatorType.Computer20241022,
                "bash_20241022" => BetaCountMessageTokensParamsToolDiscriminatorType.Bash20241022,
                "text_editor_20241022" => BetaCountMessageTokensParamsToolDiscriminatorType.TextEditor20241022,
                _ => null,
            };
        }
    }
}