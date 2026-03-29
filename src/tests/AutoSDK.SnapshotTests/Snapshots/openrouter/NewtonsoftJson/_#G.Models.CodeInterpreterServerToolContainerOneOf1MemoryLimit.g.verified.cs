//HintName: G.Models.CodeInterpreterServerToolContainerOneOf1MemoryLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeInterpreterServerToolContainerOneOf1MemoryLimit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="16g")]
        x16g,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1g")]
        x1g,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="4g")]
        x4g,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="64g")]
        x64g,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterServerToolContainerOneOf1MemoryLimitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterServerToolContainerOneOf1MemoryLimit value)
        {
            return value switch
            {
                CodeInterpreterServerToolContainerOneOf1MemoryLimit.x16g => "16g",
                CodeInterpreterServerToolContainerOneOf1MemoryLimit.x1g => "1g",
                CodeInterpreterServerToolContainerOneOf1MemoryLimit.x4g => "4g",
                CodeInterpreterServerToolContainerOneOf1MemoryLimit.x64g => "64g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterServerToolContainerOneOf1MemoryLimit? ToEnum(string value)
        {
            return value switch
            {
                "16g" => CodeInterpreterServerToolContainerOneOf1MemoryLimit.x16g,
                "1g" => CodeInterpreterServerToolContainerOneOf1MemoryLimit.x1g,
                "4g" => CodeInterpreterServerToolContainerOneOf1MemoryLimit.x4g,
                "64g" => CodeInterpreterServerToolContainerOneOf1MemoryLimit.x64g,
                _ => null,
            };
        }
    }
}