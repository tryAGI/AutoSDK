//HintName: G.Models.WorkflowAnthropicBedrockModelModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the specific model that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowAnthropicBedrockModelModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-haiku-20241022")]
        Claude35Haiku20241022,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet-20240620")]
        Claude35Sonnet20240620,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet-20241022")]
        Claude35Sonnet20241022,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-7-sonnet-20250219")]
        Claude37Sonnet20250219,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-haiku-20240307")]
        Claude3Haiku20240307,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-opus-20240229")]
        Claude3Opus20240229,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-sonnet-20240229")]
        Claude3Sonnet20240229,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-haiku-4-5-20251001")]
        ClaudeHaiku4520251001,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-opus-4-20250514")]
        ClaudeOpus420250514,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-opus-4-5-20251101")]
        ClaudeOpus4520251101,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-opus-4-6")]
        ClaudeOpus46,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-sonnet-4-20250514")]
        ClaudeSonnet420250514,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-sonnet-4-5-20250929")]
        ClaudeSonnet4520250929,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-sonnet-4-6")]
        ClaudeSonnet46,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowAnthropicBedrockModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowAnthropicBedrockModelModel value)
        {
            return value switch
            {
                WorkflowAnthropicBedrockModelModel.Claude35Haiku20241022 => "claude-3-5-haiku-20241022",
                WorkflowAnthropicBedrockModelModel.Claude35Sonnet20240620 => "claude-3-5-sonnet-20240620",
                WorkflowAnthropicBedrockModelModel.Claude35Sonnet20241022 => "claude-3-5-sonnet-20241022",
                WorkflowAnthropicBedrockModelModel.Claude37Sonnet20250219 => "claude-3-7-sonnet-20250219",
                WorkflowAnthropicBedrockModelModel.Claude3Haiku20240307 => "claude-3-haiku-20240307",
                WorkflowAnthropicBedrockModelModel.Claude3Opus20240229 => "claude-3-opus-20240229",
                WorkflowAnthropicBedrockModelModel.Claude3Sonnet20240229 => "claude-3-sonnet-20240229",
                WorkflowAnthropicBedrockModelModel.ClaudeHaiku4520251001 => "claude-haiku-4-5-20251001",
                WorkflowAnthropicBedrockModelModel.ClaudeOpus420250514 => "claude-opus-4-20250514",
                WorkflowAnthropicBedrockModelModel.ClaudeOpus4520251101 => "claude-opus-4-5-20251101",
                WorkflowAnthropicBedrockModelModel.ClaudeOpus46 => "claude-opus-4-6",
                WorkflowAnthropicBedrockModelModel.ClaudeSonnet420250514 => "claude-sonnet-4-20250514",
                WorkflowAnthropicBedrockModelModel.ClaudeSonnet4520250929 => "claude-sonnet-4-5-20250929",
                WorkflowAnthropicBedrockModelModel.ClaudeSonnet46 => "claude-sonnet-4-6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowAnthropicBedrockModelModel? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-haiku-20241022" => WorkflowAnthropicBedrockModelModel.Claude35Haiku20241022,
                "claude-3-5-sonnet-20240620" => WorkflowAnthropicBedrockModelModel.Claude35Sonnet20240620,
                "claude-3-5-sonnet-20241022" => WorkflowAnthropicBedrockModelModel.Claude35Sonnet20241022,
                "claude-3-7-sonnet-20250219" => WorkflowAnthropicBedrockModelModel.Claude37Sonnet20250219,
                "claude-3-haiku-20240307" => WorkflowAnthropicBedrockModelModel.Claude3Haiku20240307,
                "claude-3-opus-20240229" => WorkflowAnthropicBedrockModelModel.Claude3Opus20240229,
                "claude-3-sonnet-20240229" => WorkflowAnthropicBedrockModelModel.Claude3Sonnet20240229,
                "claude-haiku-4-5-20251001" => WorkflowAnthropicBedrockModelModel.ClaudeHaiku4520251001,
                "claude-opus-4-20250514" => WorkflowAnthropicBedrockModelModel.ClaudeOpus420250514,
                "claude-opus-4-5-20251101" => WorkflowAnthropicBedrockModelModel.ClaudeOpus4520251101,
                "claude-opus-4-6" => WorkflowAnthropicBedrockModelModel.ClaudeOpus46,
                "claude-sonnet-4-20250514" => WorkflowAnthropicBedrockModelModel.ClaudeSonnet420250514,
                "claude-sonnet-4-5-20250929" => WorkflowAnthropicBedrockModelModel.ClaudeSonnet4520250929,
                "claude-sonnet-4-6" => WorkflowAnthropicBedrockModelModel.ClaudeSonnet46,
                _ => null,
            };
        }
    }
}