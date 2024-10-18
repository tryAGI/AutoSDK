//HintName: G.Models.ModifyAssistantRequestToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModifyAssistantRequestToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_interpreter")]
        CodeInterpreter,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModifyAssistantRequestToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModifyAssistantRequestToolDiscriminatorType value)
        {
            return value switch
            {
                ModifyAssistantRequestToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                ModifyAssistantRequestToolDiscriminatorType.FileSearch => "file_search",
                ModifyAssistantRequestToolDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModifyAssistantRequestToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => ModifyAssistantRequestToolDiscriminatorType.CodeInterpreter,
                "file_search" => ModifyAssistantRequestToolDiscriminatorType.FileSearch,
                "function" => ModifyAssistantRequestToolDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}