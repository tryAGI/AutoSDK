//HintName: G.Models.GetRequestSearchSuggestionsField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRequestSearchSuggestionsField
    {
        /// <summary>
        /// 
        /// </summary>
        Engine,
        /// <summary>
        /// 
        /// </summary>
        InputVariableKeys,
        /// <summary>
        /// 
        /// </summary>
        InputVariableValues,
        /// <summary>
        /// 
        /// </summary>
        MetadataKeys,
        /// <summary>
        /// 
        /// </summary>
        MetadataValues,
        /// <summary>
        /// 
        /// </summary>
        OutputKeys,
        /// <summary>
        /// 
        /// </summary>
        OutputValues,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        PromptId,
        /// <summary>
        /// 
        /// </summary>
        ProviderType,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        Tags,
        /// <summary>
        /// 
        /// </summary>
        ToolNames,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRequestSearchSuggestionsFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRequestSearchSuggestionsField value)
        {
            return value switch
            {
                GetRequestSearchSuggestionsField.Engine => "engine",
                GetRequestSearchSuggestionsField.InputVariableKeys => "input_variable_keys",
                GetRequestSearchSuggestionsField.InputVariableValues => "input_variable_values",
                GetRequestSearchSuggestionsField.MetadataKeys => "metadata_keys",
                GetRequestSearchSuggestionsField.MetadataValues => "metadata_values",
                GetRequestSearchSuggestionsField.OutputKeys => "output_keys",
                GetRequestSearchSuggestionsField.OutputValues => "output_values",
                GetRequestSearchSuggestionsField.Prompt => "prompt",
                GetRequestSearchSuggestionsField.PromptId => "prompt_id",
                GetRequestSearchSuggestionsField.ProviderType => "provider_type",
                GetRequestSearchSuggestionsField.Status => "status",
                GetRequestSearchSuggestionsField.Tags => "tags",
                GetRequestSearchSuggestionsField.ToolNames => "tool_names",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRequestSearchSuggestionsField? ToEnum(string value)
        {
            return value switch
            {
                "engine" => GetRequestSearchSuggestionsField.Engine,
                "input_variable_keys" => GetRequestSearchSuggestionsField.InputVariableKeys,
                "input_variable_values" => GetRequestSearchSuggestionsField.InputVariableValues,
                "metadata_keys" => GetRequestSearchSuggestionsField.MetadataKeys,
                "metadata_values" => GetRequestSearchSuggestionsField.MetadataValues,
                "output_keys" => GetRequestSearchSuggestionsField.OutputKeys,
                "output_values" => GetRequestSearchSuggestionsField.OutputValues,
                "prompt" => GetRequestSearchSuggestionsField.Prompt,
                "prompt_id" => GetRequestSearchSuggestionsField.PromptId,
                "provider_type" => GetRequestSearchSuggestionsField.ProviderType,
                "status" => GetRequestSearchSuggestionsField.Status,
                "tags" => GetRequestSearchSuggestionsField.Tags,
                "tool_names" => GetRequestSearchSuggestionsField.ToolNames,
                _ => null,
            };
        }
    }
}