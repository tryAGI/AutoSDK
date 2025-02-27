//HintName: G.Models.BetaCreateMessageParamsToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaCreateMessageParamsToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom")]
        Custom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer_20241022")]
        Computer20241022,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bash_20241022")]
        Bash20241022,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_editor_20241022")]
        TextEditor20241022,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer_20250124")]
        Computer20250124,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bash_20250124")]
        Bash20250124,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_editor_20250124")]
        TextEditor20250124,
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
                BetaCreateMessageParamsToolDiscriminatorType.Computer20250124 => "computer_20250124",
                BetaCreateMessageParamsToolDiscriminatorType.Bash20250124 => "bash_20250124",
                BetaCreateMessageParamsToolDiscriminatorType.TextEditor20250124 => "text_editor_20250124",
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
                "computer_20250124" => BetaCreateMessageParamsToolDiscriminatorType.Computer20250124,
                "bash_20250124" => BetaCreateMessageParamsToolDiscriminatorType.Bash20250124,
                "text_editor_20250124" => BetaCreateMessageParamsToolDiscriminatorType.TextEditor20250124,
                _ => null,
            };
        }
    }
}