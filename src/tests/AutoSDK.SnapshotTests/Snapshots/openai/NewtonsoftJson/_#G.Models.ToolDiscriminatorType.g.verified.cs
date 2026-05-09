//HintName: G.Models.ToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_interpreter")]
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer_use_preview")]
        ComputerUsePreview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_search")]
        FileSearch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_generation")]
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="local_shell")]
        LocalShell,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp")]
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolDiscriminatorType value)
        {
            return value switch
            {
                ToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                ToolDiscriminatorType.ComputerUsePreview => "computer_use_preview",
                ToolDiscriminatorType.FileSearch => "file_search",
                ToolDiscriminatorType.Function => "function",
                ToolDiscriminatorType.ImageGeneration => "image_generation",
                ToolDiscriminatorType.LocalShell => "local_shell",
                ToolDiscriminatorType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => ToolDiscriminatorType.CodeInterpreter,
                "computer_use_preview" => ToolDiscriminatorType.ComputerUsePreview,
                "file_search" => ToolDiscriminatorType.FileSearch,
                "function" => ToolDiscriminatorType.Function,
                "image_generation" => ToolDiscriminatorType.ImageGeneration,
                "local_shell" => ToolDiscriminatorType.LocalShell,
                "mcp" => ToolDiscriminatorType.Mcp,
                _ => null,
            };
        }
    }
}