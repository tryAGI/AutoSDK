﻿//HintName: G.Models.CreateRunRequestToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRunRequestToolDiscriminatorType
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
    public static class CreateRunRequestToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRunRequestToolDiscriminatorType value)
        {
            return value switch
            {
                CreateRunRequestToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                CreateRunRequestToolDiscriminatorType.FileSearch => "file_search",
                CreateRunRequestToolDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRunRequestToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => CreateRunRequestToolDiscriminatorType.CodeInterpreter,
                "file_search" => CreateRunRequestToolDiscriminatorType.FileSearch,
                "function" => CreateRunRequestToolDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}