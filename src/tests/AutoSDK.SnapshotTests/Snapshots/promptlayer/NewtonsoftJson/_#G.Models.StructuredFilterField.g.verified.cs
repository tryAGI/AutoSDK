//HintName: G.Models.StructuredFilterField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The request log field to filter on.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StructuredFilterField
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cost")]
        Cost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="engine")]
        Engine,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_text")]
        InputText,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_tokens")]
        InputTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_variable_keys")]
        InputVariableKeys,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_variables")]
        InputVariables,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_json")]
        IsJson,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_plain_text")]
        IsPlainText,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is_tool_call")]
        IsToolCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latency_ms")]
        LatencyMs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="metadata")]
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="metadata_keys")]
        MetadataKeys,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output")]
        Output,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_keys")]
        OutputKeys,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_text")]
        OutputText,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_tokens")]
        OutputTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pl_id")]
        PlId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt_id")]
        PromptId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt_version_number")]
        PromptVersionNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="provider_type")]
        ProviderType,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="request_end_time")]
        RequestEndTime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="request_start_time")]
        RequestStartTime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="status")]
        Status,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tags")]
        Tags,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_names")]
        ToolNames,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StructuredFilterFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StructuredFilterField value)
        {
            return value switch
            {
                StructuredFilterField.Cost => "cost",
                StructuredFilterField.Engine => "engine",
                StructuredFilterField.InputText => "input_text",
                StructuredFilterField.InputTokens => "input_tokens",
                StructuredFilterField.InputVariableKeys => "input_variable_keys",
                StructuredFilterField.InputVariables => "input_variables",
                StructuredFilterField.IsJson => "is_json",
                StructuredFilterField.IsPlainText => "is_plain_text",
                StructuredFilterField.IsToolCall => "is_tool_call",
                StructuredFilterField.LatencyMs => "latency_ms",
                StructuredFilterField.Metadata => "metadata",
                StructuredFilterField.MetadataKeys => "metadata_keys",
                StructuredFilterField.Output => "output",
                StructuredFilterField.OutputKeys => "output_keys",
                StructuredFilterField.OutputText => "output_text",
                StructuredFilterField.OutputTokens => "output_tokens",
                StructuredFilterField.PlId => "pl_id",
                StructuredFilterField.PromptId => "prompt_id",
                StructuredFilterField.PromptVersionNumber => "prompt_version_number",
                StructuredFilterField.ProviderType => "provider_type",
                StructuredFilterField.RequestEndTime => "request_end_time",
                StructuredFilterField.RequestStartTime => "request_start_time",
                StructuredFilterField.Status => "status",
                StructuredFilterField.Tags => "tags",
                StructuredFilterField.ToolNames => "tool_names",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StructuredFilterField? ToEnum(string value)
        {
            return value switch
            {
                "cost" => StructuredFilterField.Cost,
                "engine" => StructuredFilterField.Engine,
                "input_text" => StructuredFilterField.InputText,
                "input_tokens" => StructuredFilterField.InputTokens,
                "input_variable_keys" => StructuredFilterField.InputVariableKeys,
                "input_variables" => StructuredFilterField.InputVariables,
                "is_json" => StructuredFilterField.IsJson,
                "is_plain_text" => StructuredFilterField.IsPlainText,
                "is_tool_call" => StructuredFilterField.IsToolCall,
                "latency_ms" => StructuredFilterField.LatencyMs,
                "metadata" => StructuredFilterField.Metadata,
                "metadata_keys" => StructuredFilterField.MetadataKeys,
                "output" => StructuredFilterField.Output,
                "output_keys" => StructuredFilterField.OutputKeys,
                "output_text" => StructuredFilterField.OutputText,
                "output_tokens" => StructuredFilterField.OutputTokens,
                "pl_id" => StructuredFilterField.PlId,
                "prompt_id" => StructuredFilterField.PromptId,
                "prompt_version_number" => StructuredFilterField.PromptVersionNumber,
                "provider_type" => StructuredFilterField.ProviderType,
                "request_end_time" => StructuredFilterField.RequestEndTime,
                "request_start_time" => StructuredFilterField.RequestStartTime,
                "status" => StructuredFilterField.Status,
                "tags" => StructuredFilterField.Tags,
                "tool_names" => StructuredFilterField.ToolNames,
                _ => null,
            };
        }
    }
}